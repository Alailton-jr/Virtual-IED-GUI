using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Virtual_IED_GUI.App;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI.Commands.IecDataSet.General
{
  internal class ImportSCLCommand : CommandBase
  {

    private readonly SCLImportedStore _sclImportedStore;
    private Func<string> _importSCL;

    public ImportSCLCommand(SCLImportedStore sclImportedStore, Func<string> importSCL)
    {
      _sclImportedStore = sclImportedStore;
      _importSCL = importSCL;
    }
    

    public override void Execute(object? parameter)
    {
      string? path = _importSCL();
      if (path != null)
      {
        _sclImportedStore.ImportSCL(path);
      }
    }

  }
}
