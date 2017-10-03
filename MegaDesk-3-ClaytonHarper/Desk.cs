using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ClaytonHarper
{
    public class Desk
    {
        private int width = 0;
        private int depth = 0;
        private int drawers = 0;
        private string deskMaterial = "";

        public enum Material
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine,
        };

        public string DeskMaterial { get; set; }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                this.depth = value;
            }
        }

        public int Drawers
        {
            get
            {
                return this.drawers;
            }
            set
            {
                this.drawers = value;
            }
        }

        public int DeskSize()
        {
            int size = this.width * this.depth;
            return size;
        }

    }
}
