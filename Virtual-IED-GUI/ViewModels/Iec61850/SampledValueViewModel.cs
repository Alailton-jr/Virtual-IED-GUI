using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Models;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class SampledValueViewModel : ViewModelBase
    {

        public ICommand TestCommand { get; }

        public SampledValueViewModel()
        {
            TestCommand = new SimpleCommand(RunCommand);
        }


        private void RunCommand(object obj)
        {
            var sv = new SampledValueData();

            sv.LoadSvFromScl(null);


        }

    }
}
