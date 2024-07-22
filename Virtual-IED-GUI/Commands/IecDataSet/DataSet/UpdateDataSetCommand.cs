using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels.Iec61850;

namespace Virtual_IED_GUI.Commands.IecDataSet.DataSet
{
    internal class UpdateDataSetCommand : CommandBase
    {
        private readonly MMSDataSetStore mmsDataSetStore;
        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly ConfigDataSetViewModel _view;


        public UpdateDataSetCommand(ConfigDataSetViewModel viewData, MMSDataSetStore mmsDataSetStore, ModalNavegationStore modalNavegationStore)
        {
            this.mmsDataSetStore = mmsDataSetStore;
            _modalNavegationStore = modalNavegationStore;
            _view = viewData;
        }

        public override void Execute(object? parameter)
        {
            MMSDataSet dataSet = new MMSDataSet()
            {
                Name = _view.Name,
                Description = _view.Description,
                Data = _view.SelectedData.ToList(),
                ID = _view.OldID
            };
            mmsDataSetStore.UpdateDataSet(dataSet);
            _modalNavegationStore.CloseModal();
        }
    }
}
