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
using Newtonsoft.Json;

namespace MegaDesk_3_ClaytonHarper
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;
        private Desk _desk;


        public DisplayQuote(DeskQuote deskQuote, Desk desk)
        {

            InitializeComponent();
            customerName.Text = deskQuote.CustomerName;
            deskSize.Text = deskQuote.DeskSize().ToString();
            drawers.Text = desk.Drawers.ToString();
            deskMaterial.Text = desk.DeskMaterial;
            rushOrder.Text = deskQuote.RushOrder.ToString();
            totalPrice.Text = string.Format("{0:C}", deskQuote.QuotePrice);

            _deskQuote = deskQuote;
            _desk = desk;
        }



        private void saveQuoteButton_Click(object sender, EventArgs e)
        {

            quoteDate.Text = DateTime.Now.ToString();

            string path = "quotes.json";
            string newQuotes;

            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
               
                {
                    var deskQuotes = new List<DeskQuote> { _deskQuote };
                  var myDeskQuote = JsonConvert.SerializeObject(deskQuotes);
                    sw.Write(myDeskQuote);

                }
            } else
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string readQuote = sr.ReadToEnd();
                    var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(readQuote);
                    quotes.Add(_deskQuote);
                    newQuotes = JsonConvert.SerializeObject(quotes);
                }

                File.WriteAllText(path, newQuotes);
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
