using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.Commands.IecDataSet.GooseSender
{
    internal class RemoveGooseSenderCommand : CommandBase
    {
        private GooseSenderStore _gooseSendersStore;

        public RemoveGooseSenderCommand(GooseSenderStore gooseSendersStore)
        {
            _gooseSendersStore = gooseSendersStore;
        }

        public override void Execute(object? parameter)
        {
            _gooseSendersStore.RemoveGooseData();
        }
    }
}
