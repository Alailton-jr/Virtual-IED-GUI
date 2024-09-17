using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels.Iec61850;

namespace Virtual_IED_GUI.Commands.IecDataSet.GooseSender
{
    internal class AddNewGooseSenderCommand : CommandBase
    {
        private GooseSenderStore _gooseSenderStore;
        private ModalNavegationStore _modalNavegationStore;
        private ConfigGooseSenderViewModel _viewData;

        public AddNewGooseSenderCommand(ConfigGooseSenderViewModel viewData, GooseSenderStore gooseSenderStore, ModalNavegationStore modalNavegationStore)
        {
            _viewData = viewData;
            _gooseSenderStore = gooseSenderStore;
            _modalNavegationStore = modalNavegationStore;
        }

        public override void Execute(object? parameter)
        {
            _gooseSenderStore.AddGooseData(_viewData.GoData);
            _modalNavegationStore.CloseModal();
        }
    }
}
