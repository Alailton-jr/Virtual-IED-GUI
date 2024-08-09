using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Virtual_IED_GUI.Models.SclClass;
using static Virtual_IED_GUI.Models.GooseData;

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

        static MmsData FindDaType(tDA DA, string doName, tDataTypeTemplates dataTypesTemp)
        {
            var mmsData = new MmsData();

            mmsData.DaName = DA.name;
            mmsData.DoName = doName;
            mmsData.Type = DA.bType.ToString();

            if (DA.type != null)
            {
                if (DA.type != null)
                {
                    if (DA.bType == tBasicTypeEnum.Enum)
                    {
                        FillEnumData(mmsData, DA.type, dataTypesTemp.EnumType);
                    }
                    else
                    {

                    }
                }
            }

            return mmsData;
        }

        static void FillEnumData(MmsData data, string enumID, tEnumType[] enums)
        {
            data.EnumData = new();
            var enumType = enums.FirstOrDefault(en => en.id == enumID);
            if (enumType == null) return;
            foreach (var en in enumType.EnumVal)
            {
                var enumData = new KeyValuePair<int, string>(en.ord, en.Value);
                data.EnumData.Add(enumData);
            }
        }
       
        static private MmsData? FindFcdaData(tFCDA fcda, tLDevice[] lDevices, tDataTypeTemplates dataTypesTemp)
        {
            MmsData fcdaData;

            var doName = fcda.doName;
            var daName = fcda.daName;
            var ldInst = fcda.ldInst;
            var prefix = fcda.prefix;
            var lnClass = fcda.lnClass;
            var lnInst = fcda.lnInst;
            var fc = fcda.fc;

            var ld = lDevices.FirstOrDefault(ld => ld.inst == ldInst);
            var ln = ld?.LN.FirstOrDefault(ln => ln.lnClass == lnClass && ln.inst == lnInst && ln.prefix == prefix);

            if (ln == null) return null;

            var lnTypeID = ln.lnType;

            var lnType = dataTypesTemp.LNodeType.FirstOrDefault(lnType => lnType.id == lnTypeID && lnType.lnClass == lnClass);
            if (lnType == null) return null;

            var lnTypeDO = lnType.DO.FirstOrDefault(doType => doType.name == doName);
            var doType = dataTypesTemp.DOType.FirstOrDefault(doType => doType.id == lnTypeDO?.type);

            // If daName is null -> it's a struct of all values of DO

            if (daName == null)
            {
                fcdaData = new MmsData()
                {
                    Type = "Struct",
                    DoName = doName??"",
                    DaName = daName??"",
                    StData = new List<MmsData>(),
                };
                foreach(var da in doType?.Items.OfType<tDA>())
                {
                    if (da.fc == fc)
                    {
                        fcdaData.StData.Add(FindDaType(da, doName, dataTypesTemp));
                    }
                }
            }
            else
            {
                var daType = doType?.Items.OfType<tDA>().FirstOrDefault(daType => daType.name == daName);
               
                fcdaData = FindDaType(daType, doName, dataTypesTemp);

                var dsa = 2;
            }


            return fcdaData;
        }

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
                    GooseList = new (),
                    SvList = new (),
                };
                foreach(tAccessPoint acessPoint in sclFile.IED[i].AccessPoint)
                {
                    foreach(tServer server in acessPoint.Items)
                    {
                        foreach(tLDevice ld in server.LDevice)
                        {
                            tLN0 ln0 = ld.LN0;

                            if (ln0.GSEControl != null)
                            {
                                foreach (tGSEControl gseControl in ln0.GSEControl)
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

                                        //Data
                                        allData = new(),

                                        // Network
                                        MacAddress = macAddress ?? "",
                                        AppID = appId == null ? null : ushort.Parse(appId, System.Globalization.NumberStyles.HexNumber),
                                        VLanID = vLanId == null ? null : ushort.Parse(vLanId, System.Globalization.NumberStyles.HexNumber),
                                        VLanPriority = vLanPriority == null ? (byte)0 : byte.Parse(vLanPriority),
                                    };

                                    // Find DataSet

                                    var datSet = ln0.DataSet.FirstOrDefault(ds => ds.name == goose.DataSet);
                                    if (datSet != null)
                                    {
                                        foreach (tFCDA fcda in datSet.Items)
                                        {
                                            var fcdaData = FindFcdaData(fcda, server.LDevice, sclFile.DataTypeTemplates);
                                            if (fcdaData != null)
                                            {
                                                goose.allData.Add(fcdaData);
                                            }
                                        }
                                    }
                                    else
                                    {

                                    }
                                    ied.GooseList.Add(goose);
                                }
                            }
                            if (ln0.SampledValueControl != null)
                            {
                                foreach (tSampledValueControl svControl in ln0.SampledValueControl)
                                {
                                    var subNetworks = sclFile.Communication.SubNetwork.SelectMany(subnet => subnet.ConnectedAP);
                                    var sv = subNetworks.SelectMany(ap => ap.SMV);
                                    tSMV? netSV = sv.FirstOrDefault(sv => sv.cbName == svControl.name);
                                    if (netSV == null) continue;
                                    string? macAddress = netSV.Address.FirstOrDefault(addr => addr.type == "MAC-Address")?.Value;
                                    string? vLanId = netSV.Address.FirstOrDefault(addr => addr.type == "VLAN-ID")?.Value;
                                    string? vLanPriority = netSV.Address.FirstOrDefault(addr => addr.type == "VLAN-PRIORITY")?.Value;
                                    string? appId = netSV.Address.FirstOrDefault(addr => addr.type == "APPID")?.Value;

                                    SampledValueData svData = new()
                                    {
                                        LDevice = ld.inst,
                                        Name = svControl.name,
                                        Description = svControl.desc,
                                        ConfRev = svControl.confRev,
                                        DatSetName = svControl.datSet,
                                        ID = Guid.NewGuid(),

                                        //Data
                                        allData = new(),

                                        // Network
                                        MacAddress = macAddress ?? "",
                                        AppID = appId == null ? null : ushort.Parse(appId, System.Globalization.NumberStyles.HexNumber),
                                        VLanID = vLanId == null ? null : ushort.Parse(vLanId, System.Globalization.NumberStyles.HexNumber),
                                        VLanPriority = vLanPriority == null ? (byte)0 : byte.Parse(vLanPriority),
                                    };

                                    // Find DataSet

                                    var datSet = ln0.DataSet.FirstOrDefault(ds => ds.name == svData.DatSetName);
                                    if (datSet != null)
                                    {
                                        foreach (tFCDA fcda in datSet.Items)
                                        {
                                            MMSData? fcdaData = FindFcdaData(fcda, server.LDevice, sclFile.DataTypeTemplates);
                                            if (fcdaData != null)
                                            {
                                                svData.allData.Add(fcdaData);
                                            }
                                        }
                                    }
                                    else
                                    {

                                    }
                                    ied.SvList.Add(svData);
                                }

                            }
                        }
                    }
                }

            }

            return iedList;
        }


    }
}
