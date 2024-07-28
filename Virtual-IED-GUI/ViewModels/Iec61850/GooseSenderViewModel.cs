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
        public ICommand EditGooseSender { get; set; }
        public ICommand RemoveGooseSender { get; set; }

        private int _currentSelectedItem;
        public int CurrentSelectedItem
        {
            get => _currentSelectedItem;
            set
            {
                _currentSelectedItem = value;
                if (_currentSelectedItem >= 0 && _currentSelectedItem < GooseDataList.Count)
                {
                    _gooseSenderStore.SelectedGooseData = GooseDataList[_currentSelectedItem];
                    OnPropertyChanged(nameof(CurrentSelectedItem));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Description));
                    OnPropertyChanged(nameof(DataSet));
                    OnPropertyChanged(nameof(MacAddress));
                    OnPropertyChanged(nameof(LogicalDevice));
                    OnPropertyChanged(nameof(AppId));
                    OnPropertyChanged(nameof(Vlanid));
                    OnPropertyChanged(nameof(VlanPriority));
                    OnPropertyChanged(nameof(EnableEdit));
                }
            }
        }


        public bool EnableEdit => CurrentSelectedItem >= 0;
        public GooseData? SelectedGooseData => _gooseSenderStore.SelectedGooseData;

        public string Name => SelectedGooseData?.Name ?? "";
        public string Description => SelectedGooseData?.Description ?? "";
        public string DataSet => SelectedGooseData?.DataSet ?? "";
        public string LogicalDevice => SelectedGooseData?.LDevice ?? "";
        public string AppId => SelectedGooseData?.AppID.ToString() ?? "";
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

            EditGooseSender = new OpenGooseSenderConfigCommand(
                               _gooseSenderStore,
                                modalNavegationStore,
                () => new ConfigGooseSenderViewModel(_gooseSenderStore, _modalNavegationStore, _mmsDataSetStore, SelectedGooseData)
            );

            RemoveGooseSender = new RemoveGooseSenderCommand(_gooseSenderStore);

            _gooseSenderStore.GooseListChanged += GooseListChanged;
            CurrentSelectedItem = -1;
        }

        private void GooseListChanged()
        {
            OnPropertyChanged(nameof(GooseDataList));
        }


        public override void Dispose()
        {
            if (_gooseSenderStore.GooseListChanged != null) _gooseSenderStore.GooseListChanged -= GooseListChanged;
            base.Dispose();
        }

    }

}
