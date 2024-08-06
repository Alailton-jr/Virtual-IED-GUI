using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using Virtual_IED_GUI.Models;

namespace Virtual_IED_GUI.Stores
{
    [Serializable]
    public class MMSDataSetStore
    {
        private readonly List<MMSDataSet> _dataSets;
        public List<MMSDataSet> DataSets => _dataSets;
        public MMSDataSet? SelectedDataSet;

        private SclData _sclData = new();

        [NonSerialized]
        private Dictionary<string, ObservableCollection<SCLTreeNode>> _sclTree = new();
        [XmlIgnore]
        public Dictionary<string, ObservableCollection<SCLTreeNode>> SCLTree => _sclTree;

        [field: XmlIgnore]
        public event Action<MMSDataSet>? DataSetChanged;

        public MMSDataSetStore()
        {
            _dataSets = new List<MMSDataSet>();
        }

        public ObservableCollection<SCLTreeNode> GetSclNodeTree(string fc)
        {
            if (!SCLTree.ContainsKey(fc))
            {
                SCLTree[fc] = _sclData.GetTreeNode(fc);
            }
            return SCLTree[fc];
        }

        public void AddDataSet(MMSDataSet? dataSet)
        {
            _dataSets.Add(dataSet);
            DataSetChanged?.Invoke(dataSet);
        }

        public void UpdateDataSet(MMSDataSet mmsDataSet)
        {
            var existingDataSet = _dataSets.FirstOrDefault(ds => ds.ID == mmsDataSet.ID);
            if (existingDataSet == null) return;
            existingDataSet.Name = mmsDataSet.Name;
            existingDataSet.Description = mmsDataSet.Description;
            existingDataSet.Data = mmsDataSet.Data;
            DataSetChanged?.Invoke(mmsDataSet);
        }

        public void RemoveDataSet()
        {
            if (SelectedDataSet == null) return;
            var dataSet = _dataSets.FirstOrDefault(ds => ds.ID == SelectedDataSet.ID);
            if (dataSet == null) return;
            _dataSets.Remove(dataSet);
            DataSetChanged?.Invoke(dataSet);
        }

        public void Load(MMSDataSetStore appDataMmsDataSetStore)
        {
            _dataSets.Clear();
            foreach (var dataSet in appDataMmsDataSetStore.DataSets)
            {
                _dataSets.Add(dataSet);
            }
            DataSetChanged?.Invoke(null);
        }
    }
}
