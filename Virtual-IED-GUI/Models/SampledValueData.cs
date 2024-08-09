using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Virtual_IED_GUI.Models.SclClass;
using System.Xml.Serialization;

namespace Virtual_IED_GUI.Models
{
    public class SampledValueData
    {

        public string IEDName { get; set; }
        public string SubNetWorkName { get; set; }
        public string ApName { get; set; }
        public string LDevice { get; set; }
        public string CbName { get; set; }
        public string MacAddress { get; set; }
        public ushort? VLanID { get; set; }
        public byte VLanPriority { get; set; }
        public ushort? AppID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ID;

        public string DatSetName { get; set; }
        public uint ConfRev { get; set; }
        public uint SmpRate { get; set; }
        public uint NofAsdu { get; set; }
        public string SmvID { get; set; }
        public bool MultiCast { get; set; }

        public List<MMSData> allData { get; set; }


        public bool LoadSvFromScl(string? path)
        {
            //path = @"C:\\Users\\alail\\OneDrive\\Área de Trabalho\\SES Station.scd";
            path = @"C:\\Users\\alail\\OneDrive\\Área de Trabalho\\Nari - SE_SOUZA_ALT.scd";
            List<SampledValueData> svList = new();
            var serializer = new XmlSerializer(typeof(SCL));
            SCL? sclData;
            try
            {
                using var reader = new StreamReader(path);
                var deserializedData = serializer.Deserialize(reader);
                if (deserializedData is SCL scl)
                    sclData = scl;
                else
                    return false;
            }
            catch
            {
                return false;
            }
            
            if (sclData.Communication == null) return false;
            else if (sclData.Communication.SubNetwork == null) return false;
                
            foreach (var subNetwork in sclData.Communication.SubNetwork!)
            {
                foreach (var connectedAp in subNetwork.ConnectedAP)
                {
                    if (connectedAp.SMV == null) continue;
                    foreach (var smv in connectedAp.SMV)
                    {
                        SampledValueData svData = new()
                        {
                            IEDName = connectedAp.iedName,
                            SubNetWorkName = subNetwork.name,
                            ApName = connectedAp.apName,
                            LdInst = smv.ldInst,
                            CbName = smv.cbName,
                        };

                        foreach (tP item in smv.Address)
                        {
                            switch (item.type)
                            {
                                case "MAC-Address":
                                    svData.MacAddress = item.Value;
                                    break;
                                case "VLAN-ID":
                                    svData.VLanID = item.Value;
                                    break;
                                case "VLAN-PRIORITY":
                                    svData.VLanPriority = item.Value;
                                    break;
                                case "APPID":
                                    svData.AppID = item.Value;
                                    break;
                            }
                        }

                        var ap = connectedAp;
                        tIED? ied = sclData.IED.FirstOrDefault(x => x.name == ap.iedName);
                        tAccessPoint? accessPoint = ied?.AccessPoint.FirstOrDefault(x => x.name == connectedAp.apName);
                        tLN0? ln0 = accessPoint?.Items
                            .OfType<tServer>() 
                            .SelectMany(server => server.LDevice)
                            .FirstOrDefault(lDevice => lDevice.inst == svData.LdInst)
                            ?.LN0;
                        
                        if (ln0 != null)
                        {
                            tSampledValueControl? svControl = ln0.SampledValueControl
                                .FirstOrDefault(x => x.name == svData.CbName);
                            if (svControl != null)
                            {
                                svData.DatSetName = svControl.datSet;
                                svData.ConfRev = svControl.confRev;
                                svData.SmpRate = svControl.smpRate;
                                svData.NofAsdu = svControl.nofASDU;
                                svData.SmvID = svControl.smvID;
                                svData.MultiCast = svControl.multicast;
                            }

                            tDataSet? dataSet = ln0.DataSet?.FirstOrDefault(x => x.name == svData.DatSetName);
                            if (dataSet != null)
                            {
                                foreach (tFCDA fcda in dataSet.Items)
                                {
                                    // svData.FcdaData.Add(fcda);
                                }
                            }
                        }
                    }
                }
            }


            return true;
        }


    }
}
