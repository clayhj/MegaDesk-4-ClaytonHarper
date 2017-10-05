using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ClaytonHarper
{
    public class Desk
    {

        public enum Material
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine,
        };

        public string DeskMaterial { get; set; }

        public int Width { get; set; }

        public int Depth { get; set; }

        public int Drawers { get; set; }

    }
}
