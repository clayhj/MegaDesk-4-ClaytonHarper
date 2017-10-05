using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ClaytonHarper
{
    public class DeskQuote
    {

        const int basePrice = 200;
        const int pricePerInchSquared = 1;
        const int pricePerDrawer = 50;
        const int oakPrice = 200;
        const int laminatePrice = 100;
        const int pinePrice = 50;
        const int rosewoodPrice = 300;
        const int veneerPrice = 125;
        Desk desk;


        public string CustomerName { get; set; }

        public int RushOrder { get; set; }

        public DateTime QuoteDate { get; set; }

        public DeskQuote(Desk desk)
        {
            this.desk = desk;

        }

        public int DeskSize()
        {
            int size = desk.Width * desk.Depth;
            return size;
        }

        public decimal GetQuote()
        {
            int drawers = desk.Drawers;
            decimal totalPrice;
            int size = DeskSize();
            string material = desk.DeskMaterial;
            int materialPrice = 0;
            int rushPrice;
            int sizePrice;


            if (size > 1000)
            {
                sizePrice = (size - 1000) * pricePerInchSquared;
            }
            else
            {
                sizePrice = 0;
            }

            switch(material)
            {
                case "Laminate":
                    materialPrice = laminatePrice;
                    break;
                case "Oak":
                    materialPrice = oakPrice;
                    break;
                case "Rosewood":
                    materialPrice = rosewoodPrice;
                    break;
                case "Veneer":
                    materialPrice = veneerPrice;
                    break;
                case "Pine":
                    materialPrice = pinePrice;
                    break;
            }

            switch(RushOrder)
            {
                case 3:
                    if (size >= 1000 || size <= 2000)
                    {
                        rushPrice = 70;
                    }
                    else if (size > 2000)
                    {
                        rushPrice = 80;
                    }
                    else
                    {
                        rushPrice = 60;
                    }
                    break;
                case 5:
                    if (size >= 1000 || size <= 2000)
                    {
                        rushPrice = 50;
                    }
                    else if (size > 2000)
                    {
                        rushPrice = 60;
                    }
                    else
                    {
                        rushPrice = 40;
                    }
                    break;
                case 7:
                    if (size >= 1000 || size <= 2000)
                    {
                        rushPrice = 35;
                    }
                    else if (size > 2000)
                    {
                        rushPrice = 40;
                    }
                    else
                    {
                        rushPrice = 30;
                    }
                    break;
                default:
                    rushPrice = 0;
                    break;
            }

            

            totalPrice = basePrice + sizePrice + (pricePerDrawer * drawers) + materialPrice + rushPrice;
            
            return totalPrice;
        }
    }
}
