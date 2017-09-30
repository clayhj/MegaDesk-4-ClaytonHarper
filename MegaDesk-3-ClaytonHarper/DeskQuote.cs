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

        const int basePrice = 200;
        const int pricePerInchSquared = 1;
        const int pricePerDrawer = 50;
        const int oakPrice = 200;
        const int laminatePrice = 100;
        const int pinePrice = 50;
        const int rosewoodPrice = 300;
        const int veneerPrice = 125;
        int rushOrder3 = 60;
        int rushOrder5 = 40;
        int rushOrder7 = 30;


        public Desk desk;

        public string CustomerName { get; set; }

        public int RushOrder { get; set; }

        public Desk Desk { get; set; }


        public decimal GetQuote()
        {

            decimal totalPrice;

            totalPrice = basePrice + (pricePerDrawer * Desk.Drawers);
            
            return totalPrice;
        }
    }
}
