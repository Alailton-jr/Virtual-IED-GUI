using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels.Iec61850;

namespace Virtual_IED_GUI.ViewModels
{

    public class MainViewModel: ViewModelBase
    {
        private readonly NavegationStore _navegationStore;
        private readonly ModalNavegationStore _modalNavegationStore;

        public ViewModelBase ModalCurrentViewModel => _modalNavegationStore.CurrentViewModel;

        public ICommand ProtViewCommand { get; }
        public ICommand PtocViewCommand { get; }
        public ICommand Iec61850ViewCommand { get; }

        public bool IsModalOpen => _modalNavegationStore.IsModalOpen;

        public ViewModelBase CurrentViewModel => _navegationStore.CurrentViewModel;

        public MainViewModel(NavegationStore navegationStore, IecNavegationStore iecNavegationStore,
            ModalNavegationStore modalNavegationStore, IED ied, MMSDataSetStore mmsDataSetStore, GooseSenderStore gooseSenderStore)
        {
            _navegationStore = navegationStore;
            _modalNavegationStore = modalNavegationStore;

            ProtViewCommand = new NavegationCommand(_navegationStore, () => new ProtectionViewModel());
            
            Iec61850ViewCommand = new NavegationCommand(_navegationStore, () => new Iec61850ViewModel(iecNavegationStore, _modalNavegationStore, ied, mmsDataSetStore, gooseSenderStore));
            
            PtocViewCommand = new NavegationCommand(_navegationStore, () => new PtocViewModel());


            _navegationStore.ViewModelChanged += CurrentViewModelChanged;
            _modalNavegationStore.CurrentViewModelChange += CurrentModalChanged;
        }

        ~MainViewModel()
        {
            Dispose();
        }

        public override void Dispose()
        {
            _navegationStore.ViewModelChanged -= CurrentViewModelChanged;
            _modalNavegationStore.CurrentViewModelChange -= CurrentModalChanged;

            ModalCurrentViewModel.Dispose();
            CurrentViewModel.Dispose();
            base.Dispose();
        }

        private void CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void CurrentModalChanged()
        {
            OnPropertyChanged(nameof(ModalCurrentViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }

    }
}
