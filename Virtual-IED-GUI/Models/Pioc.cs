using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{

    public class Pioc : BaseProtFunc
    {
        public Type type { get; }
        public double pickup { get; set; }
        public double time_dial { get; set; }

        public enum Type
        {
            phase,
            neutral,
            ground
        }

        Pioc(Type type, double pickup, double time_dial)
        {
            this.type = type;
            this.pickup = pickup;
            this.time_dial = time_dial;
        }
    }
}
