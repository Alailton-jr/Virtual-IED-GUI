using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Commands.IecDataSet.GooseSender;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class ConfigGooseSenderViewModel : ViewModelBase
    {
        private readonly GooseSenderStore _gooseSenderStore;
        private readonly ModalNavegationStore _modalNavegationStore;
        private readonly MMSDataSetStore _mmsDataSetStore;

        //private readonly GoData? _oldGooseData;

        public ICommand CancelCommand { get; }
        public ICommand SubmitCommand { get; }
        public bool EnableConfirm => true;
        
        public ObservableCollection<string> DataSetNames => new ObservableCollection<string>(_mmsDataSetStore.DataSets.Select(x=>x.Name));
        public int SelectedDataSet { get; set; }

        private GooseData goData;

        public GooseData GoData
        {
            get => goData;
            set
            {
                goData = value;
                OnPropertyChanged(nameof(GoData));
            }
        }

        private string _namePattern = "[^a-zA-Z0-9]";
        public string Name
        {
            get => goData.Name ?? "";
            set
            {
                goData.Name = Regex.Replace(value, _namePattern, "");
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => goData.Description ?? "";
            set
            {
                goData.Description = value;
                OnPropertyChanged();
            }
        }
        public string DataSet
        {
            get => goData.DataSet ?? "";
            set
            {
                goData.DataSet = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<string> VLanPriorityItems { get; } =
        [
            "0", "1", "2", "3", "4", "5", "6", "7"
        ];
        public string AppID
        {
            get => $"0x{goData.AppID:X}";
            set
            {
                if (value.StartsWith("0x"))
                {
                    string cleanedValue = value.Substring(2);
                    if (ushort.TryParse(cleanedValue, System.Globalization.NumberStyles.HexNumber, null, out ushort result))
                    {
                        goData.AppID = result;
                        OnPropertyChanged();
                    }
                }
                else
                {
                    if (ushort.TryParse(value, out ushort result))
                    {
                        goData.AppID = result;
                        OnPropertyChanged();
                    }
                }
                
            }
        }
        public string VLanID
        {
            get => $"0x{goData.VLanID:X}";
            set
            {
                if (value.StartsWith("0x"))
                {
                    string cleanedValue = value.Substring(2);
                    if (ushort.TryParse(cleanedValue, System.Globalization.NumberStyles.HexNumber, null, out ushort result))
                    {
                        goData.VLanID = result;
                        OnPropertyChanged();
                    }
                }
                else
                {
                    if (ushort.TryParse(value, out ushort result))
                    {
                        goData.VLanID = result;
                        OnPropertyChanged();
                    }
                }
            }
        }
        public string VLanPriority
        {
            get => goData.VLanPriority.ToString() ?? "";
            set
            {
                if (byte.TryParse(value, out byte result))
                {
                    goData.VLanPriority = result;
                    OnPropertyChanged();
                }
            }
        }
        public string MacAddress
        {
            get => goData.MacAddress ?? "";
            set
            {
                goData.MacAddress = value;
                OnPropertyChanged();
            }
        }
        public string MinTime
        {
            set => goData.MinTime = ushort.Parse(value);
            get => goData.MinTime.ToString();
        }
        public string MaxTime
        {
            set => goData.MaxTime = ushort.Parse(value);
            get => goData.MaxTime.ToString();
        }
        public string ConfigRev
        {
            set => goData.ConfigRev = uint.Parse(value);
            get => goData.ConfigRev.ToString();
        }

        public ConfigGooseSenderViewModel(GooseSenderStore gooseSenderStore, ModalNavegationStore modalNavegationStore, MMSDataSetStore mmsDataSetStore, GooseData? oldGoData=null)
        {
            _gooseSenderStore = gooseSenderStore;
            _modalNavegationStore = modalNavegationStore;
            _mmsDataSetStore = mmsDataSetStore;

            CancelCommand = new CloseModalCommand(_modalNavegationStore);

            if (oldGoData == null)
            {
                goData = _gooseSenderStore.GetDefaultGooseData();
                SubmitCommand = new AddNewGooseSenderCommand(this, _gooseSenderStore, _modalNavegationStore);
            }
            else
            {
                goData = oldGoData;
                SubmitCommand = new UpdateGooseSenderCommand(this, _gooseSenderStore, _modalNavegationStore);
            }
        }

        public void test(object obj)
        {

        }
    }
}
