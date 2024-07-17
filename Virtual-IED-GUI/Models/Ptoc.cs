using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    public class Ptoc : BaseProtFunc
    {

        public Type type { get; }
        public double pickup { get; set; }
        public double time_dial { get; set; }
        public string curve { get; set; }

        public enum Type
        {
            phase,
            neutral,
            ground
        }

        Ptoc(Type type, double pickup, double time_dial, string curve)
        {
            this.type = type;
            this.pickup = pickup;
            this.time_dial = time_dial;
            this.curve = curve;
        }


    }
}
