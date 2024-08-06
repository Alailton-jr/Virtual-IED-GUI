using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Commands.IecDataSet;
using Virtual_IED_GUI.Commands.IecDataSet.DataSet;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class DataSetViewModel : ViewModelBase
    {

        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly MMSDataSetStore mmsDataSetStore;  
        private readonly IED _ied;

        public ICommand AddDataSet { get; }
        public ICommand RemoveDataSet { get; }
        public ICommand EditDataSet { get; }

        private int _currentSelectedItem { get; set; }
        public int CurrentSelectedItem
        {
            get => _currentSelectedItem;
            set
            {
                _currentSelectedItem = value;
                if (value >= 0 && value < mmsDataSetStore.DataSets.Count)
                {
                    mmsDataSetStore.SelectedDataSet = mmsDataSetStore.DataSets[value];
                    OnPropertyChanged(nameof(SelectedDataSet));
                    OnPropertyChanged(nameof(CurrentSelectedItem));
                    OnPropertyChanged(nameof(AnyDataSetSelected));
                }
                else
                {
                    mmsDataSetStore.SelectedDataSet = null;
                    OnPropertyChanged(nameof(SelectedDataSet));
                    OnPropertyChanged(nameof(CurrentSelectedItem));
                    OnPropertyChanged(nameof(AnyDataSetSelected));
                }
            }
        }

        public bool AnyDataSetSelected => mmsDataSetStore.SelectedDataSet != null;

        public ObservableCollection<MMSDataSet> DataSets
        {
            get => new ObservableCollection<MMSDataSet>(mmsDataSetStore.DataSets);
        }

        public MMSDataSet? SelectedDataSet => mmsDataSetStore.SelectedDataSet;

        public DataSetViewModel(ModalNavegationStore modalNavegationStore, IED ied, MMSDataSetStore mmsDataSetStore)
        {
            _modalNavegationStore = modalNavegationStore;
            this.mmsDataSetStore = mmsDataSetStore;
            this._ied = ied;

            AddDataSet = new OpenDataSetConfigCommand(modalNavegationStore, () => new ConfigDataSetViewModel(_modalNavegationStore,_ied, this.mmsDataSetStore));
            EditDataSet = new OpenDataSetConfigCommand(modalNavegationStore, () => new ConfigDataSetViewModel(_modalNavegationStore, _ied, this.mmsDataSetStore, mmsDataSetStore.SelectedDataSet));
            RemoveDataSet = new RemoveDataSetCommand(this.mmsDataSetStore);

            this.mmsDataSetStore.DataSetChanged += MmsDataSetStoreChanged;
            CurrentSelectedItem = -1;
        }

        public override void Dispose()
        {
            mmsDataSetStore.DataSetChanged -= MmsDataSetStoreChanged;
            base.Dispose();
        }

        private void MmsDataSetStoreChanged(MMSDataSet? obj)
        {
            OnPropertyChanged(nameof(AnyDataSetSelected));
            OnPropertyChanged(nameof(SelectedDataSet));
            OnPropertyChanged(nameof(CurrentSelectedItem));
            OnPropertyChanged(nameof(DataSets));
        }
    }
}
