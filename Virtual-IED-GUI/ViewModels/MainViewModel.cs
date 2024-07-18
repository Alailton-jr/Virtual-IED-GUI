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
        private readonly IecNavegationStore _iecNavegationStore;
        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly IED _ied;

        public ViewModelBase ModalCurrentViewModel => _modalNavegationStore.CurrentViewModel;

        public ICommand ProtViewCommand { get; }
        public ICommand PtocViewCommand { get; }
        public ICommand Iec61850ViewCommand { get; }

        public bool IsModalOpen => _modalNavegationStore.IsModalOpen;

        public ViewModelBase CurrentViewModel => _navegationStore.CurrentViewModel;

        public MainViewModel(NavegationStore navegationStore, IecNavegationStore iecNavegationStore,
            ModalNavegationStore modalNavegationStore, IED ied)
        {
            _navegationStore = navegationStore;
            _iecNavegationStore = iecNavegationStore;
            _modalNavegationStore = modalNavegationStore;
            _ied = ied;

            PtocViewCommand = new NavegationCommand(_navegationStore, () => new DataSetViewModel(_modalNavegationStore, _ied));
            ProtViewCommand = new NavegationCommand(_navegationStore, () => new ProtectionViewModel());
            Iec61850ViewCommand = new NavegationCommand(_navegationStore, () => new Iec61850ViewModel(_iecNavegationStore, _modalNavegationStore, _ied));

            _navegationStore.StateChanged += CurrentViewModelChanged;
            _modalNavegationStore.CurrentViewModelChange += CurrentModalChanged;
        }

        ~MainViewModel()
        {
            Dispose();
        }

        public override void Dispose()
        {
            _navegationStore.StateChanged -= CurrentViewModelChanged;
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
