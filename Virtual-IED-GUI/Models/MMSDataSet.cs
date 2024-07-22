using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    [Serializable]
    public class MMSDataSet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ID { get; set; }
        public List<SCLTreeNode> Data { get; set; } = new();
    }
}
