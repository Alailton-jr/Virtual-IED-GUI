using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class ConfigGooseSenderViewModel : ViewModelBase
    {
        private readonly GooseSenderStore _gooseSenderStore;
        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly MMSDataSetStore _mmsDataSetStore;

        //private readonly GoData? _oldGooseData;

        public ICommand CancelCommand { get; }
        public ICommand SubmitCommand { get; }
        public bool EnableConfirm => true;
        
        public ObservableCollection<string> DataSetNames => new ObservableCollection<string>(_mmsDataSetStore.DataSets.Select(x=>x.Name));
        public int SelectedDataSet { get; set; }

        private GooseData goData;

        public GooseData GoData
        {
            get => goData;
            set
            {
                goData = value;
                OnPropertyChanged(nameof(GoData));
            }
        }

        //public string Name => goData.Name ?? "";
        //public string Description => goData.Description ?? "";
        //public string DataSet => goData.DataSet ?? "";
        //public string LogicalDevice => goData.LDevice ?? "";
        //public string AppId => goData.appID.ToString() ?? "";
        //public string Vlanid => goData.VLanID.ToString() ?? "";
        //public string VlanPriority => goData.VLanPriority.ToString() ?? "";
        //public string MacAddress => goData.MacAddress ?? "";

        public ConfigGooseSenderViewModel(GooseSenderStore gooseSenderStore, ModalNavegationStore modalNavegationStore, MMSDataSetStore mmsDataSetStore, GooseData? oldGoData=null)
        {
            _gooseSenderStore = gooseSenderStore;
            _modalNavegationStore = modalNavegationStore;
            _mmsDataSetStore = mmsDataSetStore;

            CancelCommand = new CloseModalCommand(_modalNavegationStore);
            SubmitCommand = new SimpleCommand(test);

            if (oldGoData == null)
            {
                oldGoData = _gooseSenderStore.GetDefaultGooseData();
            }

            goData = oldGoData;

        }

        public void test(object obj)
        {

        }
    }
}
