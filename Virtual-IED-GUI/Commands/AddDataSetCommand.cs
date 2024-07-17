using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Commands
{
    public class AddDataSetCommand : CommandBase
    {

        private readonly ModalNavegationStore _modalNavegationStore;
        private ViewModelBase _newViewModel { get; }


        public AddDataSetCommand(ModalNavegationStore modalNavegationStore, ViewModelBase newViewModel)
        {
            _modalNavegationStore = modalNavegationStore;
            _newViewModel = newViewModel;
        }

        public override void Execute(object? parameter)
        {
            _modalNavegationStore.OpenModal(_newViewModel);
        }
    }
}
