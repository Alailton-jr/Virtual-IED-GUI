using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.Commands.IecDataSet.DataSet
{
    public class RemoveDataSetCommand : CommandBase
    {

        private MMSDataSetStore MmsDataSetStore { get; }

        public RemoveDataSetCommand(MMSDataSetStore mmsDataSetStore)
        {
            MmsDataSetStore = mmsDataSetStore;
        }

        public override void Execute(object? parameter)
        {
            MmsDataSetStore.RemoveDataSet();
        }
    }
}
