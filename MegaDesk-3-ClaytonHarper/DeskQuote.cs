using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ClaytonHarper
{
    public class DeskQuote
    {
        private string customerName;
        private int rushOrder;
        private DateTime quoteDate;

        int basePrice = 200;
        int pricePerInchSquared;
        int pricePerDrawer = 50;
        int oakPrice = 200;
        int laminatePrice = 100;
        int pinePrice = 50;
        int rosewoodPrice = 300;
        int veneerPrice = 125;
        Desk desk;


        public string CustomerName { get; set; }

        public int RushOrder { get; set; }

        public DateTime QuoteDate { get; set; }

        public DeskQuote(Desk desk)
        {
            this.desk = desk;

        }

        public decimal GetQuote()
        {
            int drawers = desk.Drawers;
            decimal totalPrice;
            int size = desk.DeskSize();
            string material = desk.DeskMaterial;
            int materialPrice = 0;
            int rushPrice = 0;


            if (size > 1000)
            {
                pricePerInchSquared = size - 1000 * 1;
            }
            else
            {
                pricePerInchSquared = 0;
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
            }

            

            totalPrice = basePrice + (pricePerInchSquared) + (pricePerDrawer * drawers) + materialPrice + rushPrice;
            
            return totalPrice;
        }
    }
}
