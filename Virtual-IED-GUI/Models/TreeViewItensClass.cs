using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    public class TreeViewItensClass
    {
        public string Name { get; set; }
        public bool HasChildren => Itens?.Count > 0;
        public List<TreeViewItensClass> Itens { get; set; }
    }
}
