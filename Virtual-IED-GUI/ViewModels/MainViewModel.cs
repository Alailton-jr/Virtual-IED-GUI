using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels
{

    public class MainViewModel: ViewModelBase
    {
        private readonly NavegationStore _navegationStore;
        private readonly IecNavegationStore _iecNavegationStore;
        private readonly ModalNavegationStore _modalNavegationStore;

        public ViewModelBase ModalCurrentViewModel => _modalNavegationStore.CurrentViewModel;

        public ViewModelBase PtocView = new();
        public ViewModelBase ProtectionsView = new();

        public ICommand ProtViewCommand { get; }
        public ICommand PtocViewCommand { get; }
        public ICommand Iec61850ViewCommand { get; }

        public bool IsModalOpen => _modalNavegationStore.IsModalOpen;

        public ViewModelBase CurrentViewModel => _navegationStore.CurrentViewModel;

        public MainViewModel(NavegationStore navegationStore, IecNavegationStore iecNavegationStore, ModalNavegationStore modalNavegationStore)
        {
            _navegationStore = navegationStore;
            _iecNavegationStore = iecNavegationStore;
            _modalNavegationStore = modalNavegationStore;

            PtocViewCommand = new NavegationCommand(_navegationStore, new PtocViewModel());
            ProtViewCommand = new NavegationCommand(_navegationStore, new ProtectionViewModel());
            Iec61850ViewCommand = new NavegationCommand(_navegationStore, new Iec61850ViewModel(_iecNavegationStore, _modalNavegationStore));

            _navegationStore.StateChanged += () => OnPropertyChanged(nameof(CurrentViewModel));
            _modalNavegationStore.CurrentViewModelChange += CurrentModalChanged;

        }

        private void CurrentModalChanged()
        {
            OnPropertyChanged(nameof(ModalCurrentViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }

    }
}
