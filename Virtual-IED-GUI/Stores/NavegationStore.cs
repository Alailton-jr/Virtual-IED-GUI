using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Stores
{
    public class NavegationStore
    {
        private ViewModelBase _currentViewModel;

        public NavegationStore()
        {
            _currentViewModel = null;
        }

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                ViewModelChanged?.Invoke();
            }
        }

        public event Action? ViewModelChanged;
    }
}
