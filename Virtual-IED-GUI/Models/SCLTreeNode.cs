using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    [Serializable]
    public class SCLTreeNode
    {
        public string Name { get; set; }
        public ObservableCollection<SCLTreeNode> Children { get; set; } = new();
        public string LDInst { get; set; }
        public string LnClass { get; set; }
        public string LnInst { get; set; }
        public string DoName { get; set; }
        public string DaName { get; set; }
        public string DataType { get; set; }

        private SCLTreeNode? _parent;

        private bool _hasData;
        public bool HasData
        {
            get => _hasData;
            set
            {
                _hasData = value;

            }
        }

        private string _FC;
        public string FC
        {
            get => _FC;
            set
            {
                _FC = value;
            }
        }

        public bool HasChildren => Children.Count > 0;

        // LDInst.LnClassLnInst.DoName.DaName
        public string Path => $"{LDInst}.{LnClass}{LnInst}.{DoName}.{DaName}";

        public SCLTreeNode() {}

        public SCLTreeNode(string name, SCLTreeNode? parent)
        {
            Name = name;
            _parent = parent;
            HasData = false;

            LDInst = _parent?.LDInst ?? "";
            LnClass = _parent?.LnClass ?? "";
            LnInst = _parent?.LnInst ?? "";
            DoName = _parent?.DoName ?? "";
            DaName = _parent?.DaName ?? "";
            DataType = _parent?.DataType ?? "";
            FC = _parent?.FC ?? "";
        }

        public void PropagateHasDataToParents(bool hasData)
        {
            HasData = hasData;
            if (_parent != null)
            {
                _parent.HasData = hasData;
                _parent.PropagateHasDataToParents(hasData);
            }
        }

    }
}
