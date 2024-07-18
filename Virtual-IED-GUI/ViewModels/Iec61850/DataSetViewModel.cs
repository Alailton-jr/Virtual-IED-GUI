using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Commands.IecDataSet;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class DataSetViewModel : ViewModelBase
    {

        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly IED _ied;

        public ICommand AddDataSet { get; }
        public ICommand RemoveDataSet { get; }
        public ICommand EditDataSet { get; }

        public int CurrentSelectedItem { get; set; }

        public DataSetViewModel(ModalNavegationStore modalNavegationStore, IED ied)
        {
            _modalNavegationStore = modalNavegationStore;
            this._ied = ied;


            AddDataSet = new AddDataSetCommand(modalNavegationStore, () => new EditDataSetViewModel(_modalNavegationStore,_ied));
            //RemoveDataSet = new RelayCommand(RemoveDataSet);
            //EditDataSet = new RelayCommand(EditDataSet);
        }
    }
}
