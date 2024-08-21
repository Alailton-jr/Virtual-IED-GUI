using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    [Serializable]
    public class IED
    {

        // Three Main Attributes: 
        // 1. IED Configuration
        // 2. Protection Functions
        // 3. IEC 61850 Configuration
        // 4. Socket Communication

        // IED Configuration will Cover the following:
        // 1. IED IP Address
        // 2. IED Port Number
        // 3. Methods to Change IP and Port Number
        // 4. Methods to Save and Load Configuration
        // 5. Methods to Reset Configuration


        public string? IedIpAddress { get; set; }
        public int? IedPortNumber { get; set; }

        private Protections prot { get; set; }
        private Iec61850 iec { get; set; }
        private SocketCom socket { get; set; }
        public SclData data { get; set; }

        public IED()
        {
            this.prot = new Protections();
            this.iec = new Iec61850();
            this.socket = new SocketCom();
            this.data = new SclData();
        }

        public void load()
        {

        }

        public bool loadConfiguration(Stream config)
        {
            // Load Configuration from File
            // Will use deserialization to load the configuration


            return true;
        }

        public bool saveConfiguration()
        {
            // Save Configuration to File
            // Will use serialization to save the configuration

            return true;
        }


        public void Load(IED appDataIed)
        {

        }
    }
}
