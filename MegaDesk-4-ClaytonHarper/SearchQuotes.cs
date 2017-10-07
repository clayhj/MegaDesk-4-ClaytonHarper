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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            var materials = new List<Desk.Material>();

            materials = Enum.GetValues(typeof(Desk.Material))
                .Cast<Desk.Material>()
                .ToList();

            materialSearch.DataSource = materials;

           
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {

            string path = "quotes.json";

            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    string readQuotes = sr.ReadToEnd();

                    var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(readQuotes);



                searchQuotesTable.DataSource = quotes.Where(s => s.Desk.DeskMaterial == materialSearch.SelectedValue.ToString() )
                        .Select(d => new
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
                searchError.Visible = true;
                searchError.Text = "There are no quotes yet";
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
