using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Virtual_IED_GUI.Models.SclClass;
using static Virtual_IED_GUI.Models.GooseData;
using System.Windows.Controls;

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

    /// <summary>
    /// Extract the IED data from the SCL file
    /// </summary>
    /// <param name="sclFile"></param>
    /// <returns> A list of Ied61850Data </returns>
    public static List<Ied61850Data>? ExtractIedFromScl(SCL sclFile)
    {
      List<Ied61850Data> iedList = new();

      foreach (tIED iedScl in sclFile.IED)
      {
        Ied61850Data ied = new()
        {
          Name = iedScl.name,
          Type = iedScl.type,
          Manufacturer = iedScl.manufacturer,
          ConfigVersion = iedScl.configVersion,
          Description = iedScl.desc,
          GooseList = new List<GooseData>(),
          SvList = new List<SampledValueData>()
        };

        IEnumerable<tLDevice> LdeviceList = iedScl
          .AccessPoint
          .SelectMany(x => x.Items)
          .OfType<tServer>()
          .SelectMany(x => x.LDevice)
          .ToArray();

        foreach (tLDevice ld in LdeviceList)
        {
          tLN0? ln0 = ld.LN0; // It's supposed to always have a LN0
          if (ln0 == null) continue;

          if (ln0.GSEControl != null)
            ied.GooseList.AddRange(FindGooseControl(sclFile, ln0, ld, LdeviceList));

          if (ln0.SampledValueControl != null)
            ied.SvList.AddRange(FindSampledValueControl(sclFile, ln0, ld, LdeviceList));
        }

        iedList.Add(ied);
      }

      return iedList;
    }

    private static List<MMSData> FindDaType(string id, tDataTypeTemplates dataTypesTemp)
    {

      var dataList = new List<MMSData>();
      var daType = dataTypesTemp.DAType.FirstOrDefault(x => x.id == id);

      foreach (var bda in daType.BDA)
      {
        MMSData bdaData = new()
        {
          DaName = bda.name,
          Type = bda.bType.ToString()
        };
        if (bda.bType == tBasicTypeEnum.Enum)
        {
          FillEnumData(bdaData, bda.type, dataTypesTemp.EnumType);
        }
        else if (bda.bType == tBasicTypeEnum.Struct)
        {
          bdaData.StData = new List<MMSData>();
          var bdaType = dataTypesTemp.DAType.FirstOrDefault(x => x.id == bda.type);
          if (bdaType != null)
          {
            foreach (var bdaBda in bdaType.BDA)
            {
              bdaData.StData = FindDaType(bdaBda.type, dataTypesTemp);
            }
          }
        }
        dataList.Add(bdaData);
      }

      return dataList;
    }

    private static void FillEnumData(MMSData data, string enumID, tEnumType[] enums)
    {
      data.EnumData = [];
      var enumType = enums.FirstOrDefault(en => en.id == enumID);
      if (enumType == null) return;
      foreach (var en in enumType.EnumVal)
      {
        var enumData = new KeyValuePair<int, string>(en.ord, en.Value);
        data.EnumData.Add(enumData);
      }
    }

    private static MMSData? FindFcdaData(tFCDA fcda, IEnumerable <tLDevice> lDeviceList, tDataTypeTemplates dataTypesTemp)
    {
      MMSData fcdaData = new();

      string? doName = fcda.doName;
      string? daName = fcda.daName;
      string? ldInst = fcda.ldInst;
      string? prefix = fcda.prefix;
      string? lnClass = fcda.lnClass;
      string? lnInst = fcda.lnInst;
      tFCEnum fc = fcda.fc;

      // Options
      // 1 - DaName and DoName are not empty
      // 2 - DaName is empty
      // 3 - DaName has "."
      // 4 - DoName has "."

      // Find the FCDA Logical Device
      var ld = lDeviceList.FirstOrDefault(ld => ld.inst == ldInst);
      // Find the FCDA Logical Node
      var ln = ld?.LN.FirstOrDefault(ln => ln.lnClass == lnClass && ln.inst == lnInst && ln.prefix == prefix);
      // Use the Logical Node ID and Class to find the Logical Node Type
      var lnType = dataTypesTemp.LNodeType.FirstOrDefault(lnType => lnType.id == ln?.lnType && lnType.lnClass == lnClass);
      if (lnType == null) return null; // If the Logical Node Type is not found, return null

      if (doName.Contains("."))
      {
        // Option 4 - DoName has "."
        // TODO: Implement the case where the DoName has a "."
        throw new NotImplementedException();
      }

      // Using the Logical Node Type, find the Data Object Type
      tDO? doLnType = lnType.DO.FirstOrDefault(doType => doType.name == doName);
      var doType = dataTypesTemp.DOType.FirstOrDefault(doType => doType.id == doLnType?.type);
      if (doType == null) return null; // If the DOType is not found, return null

      if (String.IsNullOrEmpty(daName))
      {
        // If the DaName is empty, then the FCDA is a Struct
        FcdaDataWithoutDa(dataTypesTemp, fcdaData, doName, doType, fc);
      }
      else 
      {
        if (!daName.Contains("."))
        {
          // Option 1 - DaName and DoName are not empty
          if (FcdaDataWithDaAndDo(dataTypesTemp, doType, daName, fcdaData, doName)) return null;
        }
        else
        {
          // Option 3 - DaName has "."
          if (FcdaDataWithDaDot(dataTypesTemp, daName, doType, fcdaData)) return null;
        }
      }
      return fcdaData;
    }

    private static void FcdaDataWithoutDa(tDataTypeTemplates dataTypesTemp, MMSData fcdaData, string doName,
      tDOType? doType,
      tFCEnum fc)
    {
      fcdaData.Type = "Struct";
      fcdaData.DoName = doName ?? "";
      fcdaData.DaName = "";
      fcdaData.StData = new List<MMSData>();

      foreach (var item in doType?.Items)
        if (item is tDA da)
        {
          if (da.fc == fc)
          {
            var daData = new MMSData();
            daData.DaName = da.name;
            daData.Type = da.bType.ToString();
            if (da.bType == tBasicTypeEnum.Enum)
              FillEnumData(daData, da.type, dataTypesTemp.EnumType);
            else if (da.bType == tBasicTypeEnum.Struct) 
              daData.StData = FindDaType(da.type, dataTypesTemp);

            fcdaData.StData.Add(daData);
          }
        }
        else if (item is tSDO sdo)
        {
          //TODO: Implement the SDO
          throw new NotImplementedException();
        }
    }

    private static bool FcdaDataWithDaDot(tDataTypeTemplates dataTypesTemp, string daName, tDOType? doType, MMSData fcdaData)
    {
      var daNameSplit = daName.Split('.');
      var daType = doType?.Items.OfType<tDA>().FirstOrDefault(daType => daType.name == daNameSplit[0]);
      if (daType == null) return true;
          
      fcdaData.DaName = daName;
      fcdaData.StData = FindDaType(daType.type!, dataTypesTemp);
      fcdaData.Type = fcdaData.StData.FirstOrDefault(x => x.DaName == daNameSplit[1])?.Type??"";
      return false;
    }

    private static bool FcdaDataWithDaAndDo(tDataTypeTemplates dataTypesTemp, tDOType? doType, string daName,
      MMSData fcdaData,
      string doName)
    {
      var daType = doType?.Items.OfType<tDA>().FirstOrDefault(daType => daType.name == daName);
      if (daType == null) return true;

      fcdaData.DaName = daName;
      fcdaData.DoName = doName;
      fcdaData.Type = daType?.bType.ToString() ?? "";

      if (daType?.bType == tBasicTypeEnum.Enum)
        FillEnumData(fcdaData, daType?.type!, dataTypesTemp.EnumType);
      else if (daType?.bType == tBasicTypeEnum.Struct) 
        fcdaData.StData = FindDaType(daType.type, dataTypesTemp);

      return false;
    }

    private static List<SampledValueData> FindSampledValueControl(SCL sclFile, tLN0 ln0, tLDevice ld, IEnumerable<tLDevice> lDeviceList)
    {
      List<SampledValueData> svList = new();
      foreach (var svControl in ln0.SampledValueControl)
      {
        var smvList = sclFile.Communication.SubNetwork
          .Where(x => x.ConnectedAP != null)
          .SelectMany(subnet => subnet.ConnectedAP) // Get all the AccessPoint of the SubNetwork
          .Where(x => x.SMV != null)
          .SelectMany(ap => ap.SMV); // Get all the GSE of the AccessPoint

        var netSV = smvList.FirstOrDefault(x => x.cbName == svControl.name);


        if (netSV == null) continue;

        var macAddress = netSV.Address.FirstOrDefault(addr => addr.type == "MAC-Address")?.Value;

        var vLanId = netSV.Address.FirstOrDefault(addr => addr.type == "VLAN-ID")?.Value;
        var vLanPriority = netSV.Address.FirstOrDefault(addr => addr.type == "VLAN-PRIORITY")?.Value;
        var appId = netSV.Address.FirstOrDefault(addr => addr.type == "APPID")?.Value;

        SampledValueData svData = new()
        {
          LDevice = ld.inst,
          Name = svControl.name,
          Description = svControl.desc,
          ConfRev = svControl.confRev,
          DatSetName = svControl.datSet,
          ID = Guid.NewGuid(),
          //Data
          allData = new List<MMSData>(),
          // Network
          MacAddress = macAddress ?? "",
          AppID = appId == null
            ? null
            : ushort.Parse(appId, NumberStyles.HexNumber),
          VLanID = vLanId == null
            ? null
            : ushort.Parse(vLanId, NumberStyles.HexNumber),
          VLanPriority = vLanPriority == null ? (byte)0 : byte.Parse(vLanPriority)
        };

        // Find DataSet
        var datSet = ln0.DataSet.FirstOrDefault(ds => ds.name == svData.DatSetName);
        if (datSet != null)
          foreach (var fcda in datSet.Items)
          {
            var fcdaData = FindFcdaData(fcda, lDeviceList,
              sclFile.DataTypeTemplates);
            if (fcdaData != null) svData.allData.Add(fcdaData);
          }
        svList.Add(svData);
      }
      return svList;
    }

    private static List<GooseData> FindGooseControl(SCL sclFile, tLN0 ln0, tLDevice ld, IEnumerable <tLDevice> lDeviceList)
    {
      List<GooseData> goList = new();
      foreach (var gseControl in ln0.GSEControl)
      {
        // Find the Goose Control Block on the communication Field
        // 1 - Find the SubNetwork of the GSEControl
        var gseList = sclFile.Communication.SubNetwork
          .Where(x => x.ConnectedAP != null)
          .SelectMany(subnet => subnet.ConnectedAP) // Get all the AccessPoint of the SubNetwork
          .Where(x => x.GSE != null)
          .SelectMany(ap => ap.GSE); // Get all the GSE of the AccessPoint
        var netGse = gseList.FirstOrDefault(_gse => _gse.cbName == gseControl.name);


        // 2 - Get the Network Information
        var macAddress = netGse.Address.FirstOrDefault(_addr => _addr.type == "MAC-Address")?.Value;
        var vLanId = netGse.Address.FirstOrDefault(_addr => _addr.type == "VLAN-ID")?.Value;
        var vLanPriority = netGse.Address.FirstOrDefault(_addr => _addr.type == "VLAN-PRIORITY")?.Value;
        var appId = netGse.Address.FirstOrDefault(_addr => _addr.type == "APPID")?.Value;
        var minTime = (ushort)netGse.MinTime.Value;
        var maxTime = (ushort)netGse.MaxTime.Value;

        // Create the GooseData
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
          allData = new List<MMSData>(),
          // Network
          MacAddress = macAddress ?? "",
          AppID = appId == null
            ? null
            : ushort.Parse(appId, NumberStyles.HexNumber),
          VLanID = vLanId == null
            ? null
            : ushort.Parse(vLanId, NumberStyles.HexNumber),
          VLanPriority = vLanPriority == null ? (byte)0 : byte.Parse(vLanPriority)
        };

        // Find DataSet
        var datSet = ln0.DataSet.FirstOrDefault(ds => ds.name == goose.DataSet);
        if (datSet != null)
        {
          foreach (var fcda in datSet.Items)
          {
            var fcdaData = FindFcdaData(fcda, lDeviceList,
              sclFile.DataTypeTemplates);
            if (fcdaData != null) goose.allData.Add(fcdaData);
          }

          goList.Add(goose);
        }
      }

      return goList;
    }
  }
}
