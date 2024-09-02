using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Virtual_IED_GUI.Commands.IecDataSet.General;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850;

public class GeneralViewModel: ViewModelBase
{

  private readonly SCLImportedStore _sclImportedStore;
  public ICommand ImportSCLCommand { get; set; }
  OpenFileDialog openFileDialog = new();


  public GeneralViewModel(SCLImportedStore sclImportedStore)
  {
    _sclImportedStore = sclImportedStore;
    ImportSCLCommand = new ImportSCLCommand(_sclImportedStore, ()=> ImportSclFunction(null));

    openFileDialog.Filter = "SCD files (*.scd)|*.scd|CID files (*.cid)|*.cid|All files (*.*)|*.*";
    openFileDialog.FilterIndex = 1;

  }
  private string ImportSclFunction(object parameter)
  {
    bool? result = openFileDialog.ShowDialog();
    if (result == true)
    {
      string selectedFilePath = openFileDialog.FileName;
      return selectedFilePath;
    }
    return null;
  }

    
    
}