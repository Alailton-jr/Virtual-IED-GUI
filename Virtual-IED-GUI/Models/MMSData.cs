using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    public  class MMSData
    {

        //string name;
        public string Type { get; set; }
        public string DoName { get; set; }
        public string DaName { get; set; }


        public bool IsSubType => DaName.Contains(".");

        public bool HasChildren => StData != null && StData.Count > 0 && !IsSubType;

        // If struct
        public List<MMSData> StData;
        // if Enum
        public List<KeyValuePair<int, string>> EnumData { get; set; }

        public enum MmsType
        {
            Struct,
            Enum,
            INT32,
        }

    }
}
