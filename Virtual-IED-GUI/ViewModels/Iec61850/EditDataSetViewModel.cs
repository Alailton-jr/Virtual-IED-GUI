using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Components;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class EditDataSetViewModel : ViewModelBase
    {

        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly IED _ied;
        public ICommand CancelCommand { get; }


		private string _name;
		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				OnPropertyChanged(nameof(Name));
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
            }
        }

        private ObservableCollection<TreeNode> _IedData;
        public ObservableCollection<TreeNode> IedData
        {
            get => _IedData;
            set
            {
                _IedData = value;
                OnPropertyChanged(nameof(IedData));
            }
        }

        public EditDataSetViewModel(ModalNavegationStore modalNavegationStore, IED ied)
        {
            _modalNavegationStore = modalNavegationStore;
            this._ied = ied;


            CancelCommand = new CloseModalCommand(_modalNavegationStore);
            IedData = _ied.data.GetTreeNode("ST");

            var x = 2;
        }

    }
}
