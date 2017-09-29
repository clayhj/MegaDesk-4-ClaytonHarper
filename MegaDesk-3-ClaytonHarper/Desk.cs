using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ClaytonHarper
{
    class Desk
    {
        private int width = 0;
        private int depth = 0;
        private int drawers = 0;
        private string material;

        public enum Material
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine,
        };

        public Desk(int width, int depth, int drawers, string material)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = material;
        }

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

        public int Size()
        {
            return width* depth;
        }

    }
}
