using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Stores
{
    public class ModalNavegationStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                CurrentViewModelChange?.Invoke();
            }
        }

        public event Action CurrentViewModelChange;

        public bool IsModalOpen => CurrentViewModel != null;

        public void CloseModal()
        {
            CurrentViewModel = null;
        }

        public void OpenModal(ViewModelBase viewModel)
        {
            CurrentViewModel = viewModel;
        }


    }
}
