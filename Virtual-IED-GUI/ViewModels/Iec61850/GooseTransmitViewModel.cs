using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class GooseTransmitViewModel : ViewModelBase
    {

        public ObservableCollection<GooseTransmitInfo> GooseInfo { get; set; }

        public GooseTransmitViewModel()
        {
            GooseInfo = new ObservableCollection<GooseTransmitInfo>()
            {
                new GooseTransmitInfo(){Name = "GO1", Description = "First GOOSE", MacAddress = "ff:ff:ff:ff:ff"},
                new GooseTransmitInfo(){Name = "GO2", Description = "Second GOOSE"},
                new GooseTransmitInfo(){Name = "GO3", Description = "Third GOOSE"},
            };
        }

        private int _currentSelectedItem;
        public int CurrentSelectedItem
        {
            get => _currentSelectedItem;
            set
            {
                _currentSelectedItem = value;
                OnPropertyChanged(nameof(CurrentSelectedItem));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(DataSet));
                OnPropertyChanged(nameof(MacAddress));
                OnPropertyChanged(nameof(LogicalDevice));
                OnPropertyChanged(nameof(AppId));
                OnPropertyChanged(nameof(vLANID));
                OnPropertyChanged(nameof(vLANPriority));

            }
        }

        public string Name => GooseInfo[CurrentSelectedItem].Name;
        public string Description => GooseInfo[CurrentSelectedItem].Description;
        public string DataSet => GooseInfo[CurrentSelectedItem].DataSet;
        public string LogicalDevice => GooseInfo[CurrentSelectedItem].LogicalDevice;
        public string AppId => GooseInfo[CurrentSelectedItem].AppID;
        public string vLANID => GooseInfo[CurrentSelectedItem].vLANID;
        public string vLANPriority => GooseInfo[CurrentSelectedItem].vLANPriority;
        public string MacAddress => GooseInfo[CurrentSelectedItem].MacAddress;

        public class GooseTransmitInfo
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string MacAddress { get; set; }
            public string DataSet { get; set; }
            public string LogicalDevice { get; set; }
            public string AppID { get; set; }
            public string vLANID { get; set; }
            public string vLANPriority { get; set; }
        }

        public override void Dispose()
        {
            base.Dispose();
        }

    }

}
