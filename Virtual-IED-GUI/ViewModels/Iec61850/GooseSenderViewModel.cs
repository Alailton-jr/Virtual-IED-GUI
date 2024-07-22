using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Commands.IecDataSet.GooseSender;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class GooseSenderViewModel : ViewModelBase
    {

        private readonly GooseSenderStore _gooseSenderStore;
        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly MMSDataSetStore _mmsDataSetStore;

        public ObservableCollection<GooseData> GooseDataList =>
            new ObservableCollection<GooseData>(_gooseSenderStore.GooseDataList);

        public ICommand AddGooseSender { get; set; }

        private int _currentSelectedItem;
        public int CurrentSelectedItem
        {
            get => _currentSelectedItem;
            set
            {

                _currentSelectedItem = value;
                if (_currentSelectedItem >= 0 && _currentSelectedItem < GooseDataList.Count)
                {
                    SelectedGooseData = GooseDataList[_currentSelectedItem];
                    OnPropertyChanged(nameof(CurrentSelectedItem));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Description));
                    OnPropertyChanged(nameof(DataSet));
                    OnPropertyChanged(nameof(MacAddress));
                    OnPropertyChanged(nameof(LogicalDevice));
                    OnPropertyChanged(nameof(AppId));
                    OnPropertyChanged(nameof(Vlanid));
                    OnPropertyChanged(nameof(VlanPriority));
                }
            }
        }

        public GooseData? SelectedGooseData { get; set; }

        public string Name => SelectedGooseData?.Name ?? "";
        public string Description => SelectedGooseData?.Description ?? "";
        public string DataSet => SelectedGooseData?.DataSet ?? "";
        public string LogicalDevice => SelectedGooseData?.LDevice ?? "";
        public string AppId => SelectedGooseData?.appID.ToString() ?? "";
        public string Vlanid => SelectedGooseData?.VLanID.ToString() ?? "";
        public string VlanPriority => SelectedGooseData?.VLanPriority.ToString() ?? "";
        public string MacAddress => SelectedGooseData?.MacAddress ?? "";

        public GooseSenderViewModel(GooseSenderStore gooseSenderStore, ModalNavegationStore modalNavegationStore, MMSDataSetStore mmsDataSetStore)
        {
            _gooseSenderStore = gooseSenderStore;
            _modalNavegationStore = modalNavegationStore;
            _mmsDataSetStore = mmsDataSetStore;

            AddGooseSender = new OpenGooseSenderConfigCommand(
                _gooseSenderStore,
                modalNavegationStore,
                () => new ConfigGooseSenderViewModel(_gooseSenderStore, _modalNavegationStore, _mmsDataSetStore)
            );
        }


        public override void Dispose()
        {
            base.Dispose();
        }

    }

}
