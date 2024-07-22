using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Commands.IecDataSet;
using Virtual_IED_GUI.Commands.IecDataSet.DataSet;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class ConfigDataSetViewModel : ViewModelBase
    {

        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly MMSDataSetStore mmsDataSetStore;
        private readonly IED _ied;


        public ICommand CancelCommand { get; }
        public ICommand SubmitCommand { get; }


        private string _namePattern = "[^a-zA-Z0-9]";
        private string _name;
		public string Name
		{
			get { return _name; }
			set
			{
                _name = Regex.Replace(value, _namePattern, "");
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(EnableConfirm));
            }
		}

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(EnableConfirm));
            }
        }

        private ObservableCollection<SCLTreeNode> _IedData;
        public ObservableCollection<SCLTreeNode> IedData
        {
            get => _IedData;
            set
            {
                _IedData = value;
                OnPropertyChanged(nameof(IedData));
                OnPropertyChanged(nameof(EnableConfirm));
            }
        }

        private int _selectedFc;
        public int SelectedFc
        {
            get => _selectedFc;
            set
            {
                if (value != _selectedFc)
                {
                    LoadSCLData($"{_FcCollection[value][0]}{_FcCollection[value][1]}");
                }
                _selectedFc = value;
                OnPropertyChanged(nameof(SelectedFc));
            }
        }

        private ObservableCollection<string> _FcCollection;
        public ObservableCollection<string> FcCollection
        {
            get => _FcCollection;
            set
            {
                _FcCollection = value;
                OnPropertyChanged(nameof(FcCollection));
            }
        }

        private ObservableCollection<SCLTreeNode> _selectedData;
        public ObservableCollection<SCLTreeNode> SelectedData
        {
            get => _selectedData;
            set
            {
                _selectedData = value;
                OnPropertyChanged(nameof(SelectedData));
            }
        }

        public ICommand DropCommand { get; set; }
        public ICommand DeleteDataSetItemCommand { get; set; }

        public bool IsEdit { get; set; }
        public bool EnableConfirm => !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Description) && SelectedData.Count > 0;

        private int _currentSelectedItem { get; set; }
        public int CurrentSelectedItem
        {
            get => _currentSelectedItem;
            set
            {
                _currentSelectedItem = value;
                if (value >= 0)
                {
                    OnPropertyChanged(nameof(CurrentSelectedItem));
                }
            }
        }

        public Guid OldID;

        public ConfigDataSetViewModel(ModalNavegationStore modalNavegationStore, IED ied, MMSDataSetStore mmsDataSetStore, MMSDataSet? previousDataSet = null)
        {
            _modalNavegationStore = modalNavegationStore;
            this.mmsDataSetStore = mmsDataSetStore;

            CancelCommand = new CloseModalCommand(_modalNavegationStore);
            if (previousDataSet != null)
            {
                SubmitCommand = new UpdateDataSetCommand(this, this.mmsDataSetStore, _modalNavegationStore);
            }
            else
            {
                SubmitCommand = new AddNewDataSetCommand(this, this.mmsDataSetStore, _modalNavegationStore);
            }

            _selectedData = new ObservableCollection<SCLTreeNode>();

            this._ied = ied;
            _FcCollection = [
                "ST (Status Information)", 
                "MX (Measurands)", 
                "CO (Control)", 
                "CF (Configuration)", 
                "DC (Description)", 
                "EX (Extended Definition)"
            ];
            LoadSCLData("ST");

            DropCommand = new SimpleCommand(OnDrop);
            DeleteDataSetItemCommand = new SimpleCommand(DeleteDataSetItem);

            if (previousDataSet != null)
            {
                IsEdit = true;
                Name = previousDataSet.Name;
                Description = previousDataSet.Description;
                OldID = previousDataSet.ID; 
                SelectedData = new ObservableCollection<SCLTreeNode>(previousDataSet.Data);
            }
        }

        private void OnDrop(object parameters)
        {
            if (parameters is SCLTreeNode node)
            {
                if (!SelectedData.Contains(node))
                {
                    SelectedData.Add(node);
                    OnPropertyChanged(nameof(EnableConfirm));
                }
            }
        }

        private void LoadSCLData(string fc)
        {
            IedData = _ied.data.GetTreeNode(fc);
        }

        private void DeleteDataSetItem(object sender)
        {
            if (sender is SCLTreeNode node)
            {
                SelectedData.Remove(node);
            }
        }


    }
}
