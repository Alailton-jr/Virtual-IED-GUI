using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.ViewModels.Iec61850;

namespace Virtual_IED_GUI.Commands.IecDataSet.DataSet
{
    public class AddNewDataSetCommand : CommandBase
    {
        private readonly MMSDataSetStore mmsDataSetStore;
        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly ConfigDataSetViewModel _view;


        public AddNewDataSetCommand(ConfigDataSetViewModel viewData, MMSDataSetStore mmsDataSetStore, ModalNavegationStore modalNavegationStore)
        {
            this.mmsDataSetStore = mmsDataSetStore;
            _modalNavegationStore = modalNavegationStore;
            _view = viewData;
        }

        public override void Execute(object? parameter)
        {
            Models.MMSDataSet? dataSet = new Models.MMSDataSet()
            {
                Name = _view.Name,
                Description = _view.Description,
                Data = _view.SelectedData.ToList(),
                ID = Guid.NewGuid()
            };
            mmsDataSetStore.AddDataSet(dataSet);
            _modalNavegationStore.CloseModal();
        }
    }
}
