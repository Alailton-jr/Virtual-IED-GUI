using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.Views;
using static System.Net.Mime.MediaTypeNames;

namespace Virtual_IED_GUI.ViewModels
{
    public class Iec61850ViewModel:ViewModelBase
    {

        private readonly IecNavegationStore _iecNavegationStore;
        private readonly ModalNavegationStore _modalNavegationStore;

        public ViewModelBase CurrentView => _iecNavegationStore.CurrentViewModel;

        private bool _gooseTransmitChecked;
        public bool GooseTransmitChecked
        {
            get => _gooseTransmitChecked;
            set
            {
                _gooseTransmitChecked = value;
                OnPropertyChanged(nameof(GooseTransmitChecked));
            }
        }

        private bool _dataSetViewChecked;

        public bool DataSetViewChecked
        {
            get => _dataSetViewChecked;
            set
            {
                _dataSetViewChecked = value;
                OnPropertyChanged(nameof(DataSetViewChecked));
            }
        }

        public ICommand GooseTransmitView { get; }
        public ICommand DataSetView { get; }

        public Iec61850ViewModel(IecNavegationStore iecNavegationStore, ModalNavegationStore modalNavegationStore)
        {
            _iecNavegationStore = iecNavegationStore;
            _modalNavegationStore = modalNavegationStore;

            GooseTransmitView = new IecNavegationCommand(iecNavegationStore, new GooseTransmitViewModel());
            DataSetView = new IecNavegationCommand(_iecNavegationStore, new Iec61850DataSetViewModel(_modalNavegationStore));

            _iecNavegationStore.StateChanged += () => OnPropertyChanged(nameof(CurrentView));
            _iecNavegationStore.StateChanged += () => OnPropertyChanged(nameof(GooseTransmitChecked));

        }
    }
}
