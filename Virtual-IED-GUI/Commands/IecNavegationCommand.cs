using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Commands
{
    public class IecNavegationCommand : CommandBase
    {
        private readonly IecNavegationStore _navegationStore;
        private ViewModelBase _newViewModel { get; }

        public IecNavegationCommand(IecNavegationStore navegationStore, ViewModelBase newViewModel)
        {
            _navegationStore = navegationStore;
            _newViewModel = newViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navegationStore.CurrentViewModel = _newViewModel;
        }
    }
}
