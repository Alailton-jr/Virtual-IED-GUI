using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Components
{
    public class TreeNode : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public ObservableCollection<TreeNode> Children { get; set; } = new();

        public TreeNode(string name, TreeNode? parent)
        {
            Name = name;
            _parent = parent;
            HasData = false;

        }

        private TreeNode? _parent;

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

        public event PropertyChangedEventHandler? PropertyChanged;

        public void PropagateHasDataToParents(bool hasData)
        {
            this.HasData = hasData;
            if (_parent != null)
            {
                _parent.HasData = hasData;
                _parent.PropagateHasDataToParents(hasData);
            }
        }

    }
}
