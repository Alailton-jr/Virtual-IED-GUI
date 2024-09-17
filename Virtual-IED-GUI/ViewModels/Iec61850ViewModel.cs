using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels.Iec61850;
using Virtual_IED_GUI.Views;
using static System.Net.Mime.MediaTypeNames;

namespace Virtual_IED_GUI.ViewModels
{
    public class Iec61850ViewModel:ViewModelBase
    {

        private readonly IecNavegationStore _iecNavegationStore;
        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly IED _ied;
        private readonly MMSDataSetStore _mmsDataSetStore;
        private readonly GooseSenderStore _gooseSenderStore;
    private readonly SCLImportedStore _importedSCLStore;

        public ViewModelBase CurrentView => _iecNavegationStore.CurrentViewModel;

        public bool GooseTransmitChecked => CurrentView is GooseSenderViewModel;
        public bool DataSetViewChecked => CurrentView is DataSetViewModel;

        public ICommand GooseTransmitView { get; }
        public ICommand DataSetView { get; }
        public ICommand SampledValueView { get; }
        
        public ICommand GeneralView { get; }

        public Iec61850ViewModel(IecNavegationStore iecNavegationStore, ModalNavegationStore modalNavegationStore,
            IED ied, MMSDataSetStore mmsDataSetStore, GooseSenderStore gooseSenderStore, SCLImportedStore importedSclStore)
        {
            _iecNavegationStore = iecNavegationStore;
            _modalNavegationStore = modalNavegationStore;
            _mmsDataSetStore = mmsDataSetStore;
            _gooseSenderStore = gooseSenderStore;
            _ied = ied;
      _importedSCLStore = importedSclStore;

            GooseTransmitView = new IecNavegationCommand(_iecNavegationStore, () => new GooseSenderViewModel(_gooseSenderStore, _modalNavegationStore, _mmsDataSetStore));

            DataSetView = new IecNavegationCommand(_iecNavegationStore, () => new DataSetViewModel(_modalNavegationStore, _ied, this._mmsDataSetStore));

            SampledValueView = new IecNavegationCommand(_iecNavegationStore, () => new SampledValueViewModel(_importedSCLStore));
            
            GeneralView = new IecNavegationCommand(_iecNavegationStore, () => new GeneralViewModel(_importedSCLStore));

            _iecNavegationStore.StateChanged += IecViewModelChanged;
            SampledValueView.Execute(null);
        }

        private void IecViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
            OnPropertyChanged(nameof(GooseTransmitChecked));
            OnPropertyChanged(nameof(DataSetViewChecked));
        }

        public override void Dispose()
        {
            _iecNavegationStore.StateChanged -= IecViewModelChanged;
            base.Dispose();
        }
    }
}
