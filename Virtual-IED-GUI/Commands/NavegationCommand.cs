using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Commands
{
    class NavegationCommand : CommandBase
    {
        private readonly NavegationStore _navegationStore;
        private Func<ViewModelBase> _createViewModel;

        public NavegationCommand(NavegationStore navegationStore, Func<ViewModelBase> createViewModel)
        {
            _navegationStore = navegationStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navegationStore.CurrentViewModel = _createViewModel();

        }

    }
}
