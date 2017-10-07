using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_3_ClaytonHarper
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            string path = "quotes.json";
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string  readQuotes = sr.ReadToEnd();

                var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(readQuotes);

                    displayQuotesTable.DataSource = quotes.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.Drawers,
                        SurfaceMaterial = d.Desk.DeskMaterial,
                        DeliveryType = d.RushOrder,
                        QuoteAmount = d.QuotePrice
                    }).ToList();

                }
            }
            catch (FileNotFoundException)
            {
                displayError.Visible = true;
                displayError.Text = "There are no quotes yet";
            }
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu addMainMenu = new MainMenu();
            addMainMenu.Show();
            this.Hide();
        }
    }
}
