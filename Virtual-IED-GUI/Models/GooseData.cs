using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    [Serializable]
    public class GooseData
    {

        public string LDevice { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string MacAddress { get; set; }
        public ushort? appID { get; set; }
        public ushort? VLanID { get; set; }
        public byte VLanPriority { get; set; }
        public ushort MinTime { get; set; }
        public ushort MaxTime { get; set; }
        public uint ConfigRev { get; set; }
        public string DataSet { get; set; }
        public Guid ID;

        public GooseData()
        {
            LDevice = "CFG";
        }


    }

}
