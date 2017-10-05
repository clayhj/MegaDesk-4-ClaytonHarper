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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            materialSearch.DataSource = Enum.GetValues(typeof(Desk.Material));
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {

            string path = "quotes.txt";

            searchQuotesTable.Rows.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] quotes = sr.ReadLine().Split(',');
                        if (quotes.Contains(materialSearch.Text))
                        {
                            searchQuotesTable.Rows.Add(quotes[0], quotes[1], quotes[2], quotes[3], quotes[4], quotes[5], quotes[6]);
                            searchError.Visible = false;
                        }
                        else
                        {
                            searchError.Visible = true;
                            searchError.Text = "No Matches";
                        }

                    }
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
