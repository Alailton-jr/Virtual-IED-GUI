using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Commands.IecDataSet.GooseSender
{
    internal class OpenGooseSenderConfigCommand : CommandBase
    {
        private GooseSenderStore _gooseSenderStore;
        private ModalNavegationStore _modalNavegationStore;
        private Func<ViewModelBase> _createModalViewFunc;

        public OpenGooseSenderConfigCommand(
            GooseSenderStore gooseSenderStore, 
            ModalNavegationStore modalNavegationStore,
            Func<ViewModelBase> createModalView)
        {
            _gooseSenderStore = gooseSenderStore;
            _modalNavegationStore = modalNavegationStore;
            _createModalViewFunc = createModalView;
        }

        public override void Execute(object? parameter)
        {
            _modalNavegationStore.OpenModal(_createModalViewFunc());
        }
    }
}
