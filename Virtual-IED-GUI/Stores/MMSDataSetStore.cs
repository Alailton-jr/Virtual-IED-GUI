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

        [field: XmlIgnore]
        public event Action<MMSDataSet> DataSetAdded;
        [field: XmlIgnore]
        public event Action<MMSDataSet> DataSetUpdated;
        [field: XmlIgnore]
        public event Action<MMSDataSet> DataSetRemoved;

        public MMSDataSetStore()
        {
            _dataSets = new List<MMSDataSet?>();
        }

        public void AddDataSet(MMSDataSet? dataSet)
        {
            _dataSets.Add(dataSet);
            DataSetAdded?.Invoke(dataSet);
        }

        public void UpdateDataSet(MMSDataSet mmsDataSet)
        {
            var existingDataSet = _dataSets.FirstOrDefault(ds => ds.ID == mmsDataSet.ID);
            if (existingDataSet == null) return;
            existingDataSet.Name = mmsDataSet.Name;
            existingDataSet.Description = mmsDataSet.Description;
            existingDataSet.Data = mmsDataSet.Data;
            DataSetUpdated?.Invoke(mmsDataSet);
        }

        public void RemoveDataSet()
        {
            if (SelectedDataSet == null) return;
            var dataSet = _dataSets.FirstOrDefault(ds => ds.ID == SelectedDataSet.ID);
            if (dataSet == null) return;
            _dataSets.Remove(dataSet);
            DataSetRemoved?.Invoke(dataSet);
        }

        public void Load(MMSDataSetStore appDataMmsDataSetStore)
        {
            _dataSets.Clear();
            foreach (var dataSet in appDataMmsDataSetStore.DataSets)
            {
                _dataSets.Add(dataSet);
            }
        }
    }
}
