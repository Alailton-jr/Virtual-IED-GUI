using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using Virtual_IED_GUI.Commands;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;

namespace Virtual_IED_GUI.ViewModels.Iec61850
{
    public class SampledValueViewModel : ViewModelBase
    {
        private readonly SCLImportedStore _sclImportedStore;

        public ObservableCollection<TreeViewItensClass> IedDataList
        {
            get => ConvertSvList2TreeViewItem(_sclImportedStore.ImportedIeds);
        }

        private List<TreeViewItensClass> GetSvItens(List<MMSData> SvData)
        {
            var treeViewItens = new List<TreeViewItensClass>();
            foreach (var data in SvData)
            {
                TreeViewItensClass item = new();
                if (data.IsSubType)
                {
                    if (data.StData!= null && data.StData.Exists(x => x.DaName == data.DaName.Split(".")[1]))
                    {
                        data.StData = null;
                    }
                }
                item.Name = $"{data?.DoName}.{data?.DaName} - {data.Type}";
                if (data.StData != null && data.StData.Count > 0)
                {
                    item.Itens = GetSvItens(data.StData);
                }
                treeViewItens.Add(item);
            }
            return treeViewItens;
        }

        private List<TreeViewItensClass> GetIedItens(List<SampledValueData> SvList)
        {
            var treeViewItens = new List<TreeViewItensClass>();
            foreach (var Sv in SvList)
            {
                TreeViewItensClass item = new()
                {
                    Name = Sv.Name,
                };
                if(Sv.allData.Count > 0)
                {
                    item.Itens = GetSvItens(Sv.allData);
                }
                treeViewItens.Add(item);
            }
            return treeViewItens;
        }

        private ObservableCollection<TreeViewItensClass> ConvertSvList2TreeViewItem(List<Ied61850Data> iedData)
        {
            var filteredIedData = iedData.Where(x => x.SvList.Count > 0).ToList();
            var treeViewItens = new ObservableCollection<TreeViewItensClass>();
            foreach(var ied in filteredIedData)
            {
                TreeViewItensClass item = new()
                {
                    Name = ied.Name,
                };
                if (ied.SvList.Count > 0)
                {
                    item.Itens = GetIedItens(ied.SvList);
                }
                treeViewItens.Add(item);
            }
            var observable = new ObservableCollection<TreeViewItensClass>(treeViewItens);
            return observable;
        }

        public SampledValueViewModel(SCLImportedStore sclImportedStore)
        {
            _sclImportedStore = sclImportedStore;


            var x = 2312;
        }


        private void RunCommand(object obj)
        {
            var sv = new SampledValueData();

            sv.LoadSvFromScl(null);


        }

    }
}
