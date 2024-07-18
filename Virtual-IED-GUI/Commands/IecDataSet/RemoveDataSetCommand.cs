using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.Commands.IecDataSet
{
    public class RemoveDataSetCommand: CommandBase
    {
        private Action _execAction { get; }

        public RemoveDataSetCommand(Action execAction)
        {
            _execAction = execAction;
        }

        public override void Execute(object? parameter)
        {
            _execAction();
        }
    }
}
