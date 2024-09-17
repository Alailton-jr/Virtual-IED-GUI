using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Virtual_IED_GUI.Models;
using static Virtual_IED_GUI.Models.SclClass;

namespace Virtual_IED_GUI.Stores
{
    public class SCLImportedStore
    {
        public readonly List<SclClass.SCL> ImportedScls = new();
        public readonly List<Ied61850Data> ImportedIeds = new();

        public bool ImportSCL(string path)
        {

            var serializer = new XmlSerializer(typeof(SCL));
            using var reader = new StreamReader(path);
            var deserializedData = serializer.Deserialize(reader);
            if (deserializedData is SCL scl2)
            {
                List<Ied61850Data>? x = Ied61850Data.ExtractIedFromScl(scl2);
                ImportedScls.Add(scl2);
                foreach (var ied in x)
                {
                    if (ied != null)
                    {
                        if (ImportedIeds.Exists(x => x.Name == ied.Name))
                        {
                            continue;
                        }
                        else
                        {
                            ImportedIeds.Add(ied);
                        }
                    }
                }
                return true;
            }
            else return false;
        }


    }
}
