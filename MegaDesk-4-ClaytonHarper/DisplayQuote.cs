using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ClaytonHarper
{
    public partial class DisplayQuote : Form
    {



        public DisplayQuote(DeskQuote deskQuote, Desk desk)
        {

            InitializeComponent();
            customerName.Text = deskQuote.CustomerName;
            deskSize.Text = deskQuote.DeskSize().ToString();
            drawers.Text = desk.Drawers.ToString();
            deskMaterial.Text = desk.DeskMaterial;
            rushOrder.Text = deskQuote.RushOrder.ToString();
            totalPrice.Text = string.Format("{0:C}", deskQuote.GetQuote());

            
            
        }

        private void saveQuoteButton_Click(object sender, EventArgs e)
        {

            quoteDate.Text = DateTime.Now.ToString();

            string path = "quotes.txt";

            if (!File.Exists(path))
            {
                using (TextWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", customerName.Text,deskSize.Text,drawers.Text,deskMaterial.Text, rushOrder.Text,totalPrice.Text.Replace(",",""), quoteDate.Text);                
                }
            } else
            {
                using (TextWriter sw = new StreamWriter(path, append: true))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", customerName.Text, deskSize.Text, drawers.Text, deskMaterial.Text, rushOrder.Text, totalPrice.Text.Replace(",", ""), quoteDate.Text);
                }
            }

            saveQuoteButton.Enabled = false;

            quoteDate.Visible = true;


        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu addMainMenu = new MainMenu();
            addMainMenu.Show();
            this.Hide();
        }
    }
}
