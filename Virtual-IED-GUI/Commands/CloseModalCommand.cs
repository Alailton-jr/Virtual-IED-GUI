using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.Commands
{
    public class CloseModalCommand : CommandBase
    {
        public readonly ModalNavegationStore _ModalNavegationStore;

        public CloseModalCommand(ModalNavegationStore modalNavegationStore)
        {
            _ModalNavegationStore = modalNavegationStore;
        }

        public override void Execute(object? parameter)
        {
            _ModalNavegationStore.CurrentViewModel = null;
        }
    }
}
