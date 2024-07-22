using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Commands.IecDataSet.DataSet
{
    public class OpenDataSetConfigCommand : CommandBase
    {

        private readonly ModalNavegationStore _modalNavegationStore;
        private Func<ViewModelBase> _createModalView { get; }


        public OpenDataSetConfigCommand(ModalNavegationStore modalNavegationStore, Func<ViewModelBase> createModalView)
        {
            _modalNavegationStore = modalNavegationStore;
            _createModalView = createModalView;
        }

        public override void Execute(object? parameter)
        {
            _modalNavegationStore.OpenModal(_createModalView());
        }
    }
}
