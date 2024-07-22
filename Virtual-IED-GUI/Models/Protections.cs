using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    [Serializable]
    public class Protections
    {

        public Protections()
        {
        }

        public List<BaseProtFunc> protList { get; } = new();

        public void AddProtection(BaseProtFunc prot)
        {
            protList.Add(prot);
        }

        public void RemoveProtection(BaseProtFunc prot)
        {
            protList.Remove(prot);
        }

        public void RemoveProtection(int index)
        {
            protList.RemoveAt(index);
        }

        public void ClearProtections()
        {
            protList.Clear();
        }

        public void EditProtection(int index, BaseProtFunc prot)
        {
            protList[index] = prot;
        }

        public BaseProtFunc GetProtection(int index)
        {
            return protList[index];
        }
    }
}
