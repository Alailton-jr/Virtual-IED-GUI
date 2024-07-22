using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Commands
{
    public class SimpleCommand : CommandBase
    {
        private readonly Action<object> _execute;

        public SimpleCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public override void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
