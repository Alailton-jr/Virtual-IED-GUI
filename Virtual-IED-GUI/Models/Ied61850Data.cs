using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Virtual_IED_GUI.Models.SclClass;


namespace Virtual_IED_GUI.Models
{
    public class Ied61850Data
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string ConfigVersion { get; set; }
        public string Description { get; set; }
        public Guid ID { get; set; }
        public List<GooseData> GooseList { get; set; }
        public List<SampledValueData> SvList { get; set; }

        static public List<Ied61850Data> ExtractIedFromScl(SCL sclFile)
        {
            List<Ied61850Data> iedList = new();
            
            for (int i = 0; i < sclFile.IED.Length; i++)
            {
                Ied61850Data ied = new()
                {
                    Name = sclFile.IED[i].name,
                    Type = sclFile.IED[i].type,
                    Manufacturer = sclFile.IED[i].manufacturer,
                    ConfigVersion = sclFile.IED[i].configVersion,
                    Description = sclFile.IED[i].desc,
                };
                foreach(tAccessPoint acessPoint in sclFile.IED[i].AccessPoint)
                {
                    foreach(tServer server in acessPoint.Items)
                    {
                        foreach(tLDevice ld in server.LDevice)
                        {
                            tLN0 ln0 = ld.LN0;
                            foreach(tGSEControl gseControl in ln0.GSEControl)
                            {
                                var subNetworks = sclFile.Communication.SubNetwork.SelectMany(subnet => subnet.ConnectedAP);
                                var gse = subNetworks.SelectMany(ap => ap.GSE);
                                tGSE? netGSE = gse.FirstOrDefault(gse => gse.cbName == gseControl.name);
                                if (netGSE == null) continue;
                                string? macAddress = netGSE.Address.FirstOrDefault(addr => addr.type == "MAC-Address")?.Value;
                                string? vLanId = netGSE.Address.FirstOrDefault(addr => addr.type == "VLAN-ID")?.Value;
                                string? vLanPriority = netGSE.Address.FirstOrDefault(addr => addr.type == "VLAN-PRIORITY")?.Value;
                                string? appId = netGSE.Address.FirstOrDefault(addr => addr.type == "APPID")?.Value;
                                ushort minTime = (ushort)netGSE.MinTime.Value;
                                ushort maxTime = (ushort)netGSE.MaxTime.Value;

                                GooseData goose = new()
                                {
                                    LDevice = ld.inst,
                                    Name = gseControl.name,
                                    Description = gseControl.desc,
                                    ConfigRev = gseControl.confRev,
                                    DataSet = gseControl.datSet,
                                    ID = Guid.NewGuid(),
                                    MinTime = minTime,
                                    MaxTime = maxTime,

                                    // Network
                                    MacAddress = macAddress ?? "",
                                    AppID = appId == null ? null : ushort.Parse(appId, System.Globalization.NumberStyles.HexNumber),
                                    VLanID = vLanId == null ? null : ushort.Parse(vLanId, System.Globalization.NumberStyles.HexNumber),
                                    VLanPriority = vLanPriority == null ? (byte)0 : byte.Parse(vLanPriority),
                                };
                                ied.GooseList.Add(goose);
                            }
                        }
                    }
                }

            }

            return iedList;
        }


    }
}
