using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels
{
    public class Iec61850DataSetViewModel : ViewModelBase
    {

        private readonly ModalNavegationStore _modalNavegationStore;

        public ICommand AddDataSet { get; }
        public ICommand RemoveDataSet { get; }
        public ICommand EditDataSet { get; }

        public Iec61850DataSetViewModel(ModalNavegationStore modalNavegationStore)
        {
            _modalNavegationStore = modalNavegationStore;
            AddDataSet = new AddDataSetCommand(modalNavegationStore, new PiocViewModel(1));
            //RemoveDataSet = new RelayCommand(RemoveDataSet);
            //EditDataSet = new RelayCommand(EditDataSet);
        }
    }
}
