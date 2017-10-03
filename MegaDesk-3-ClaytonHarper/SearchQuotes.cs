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

            quoteResults.Visible = true;

            string path = "C:\\Users\\clayh\\Desktop\\CIT365\\quotes.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        var quote = sr.ReadLine();
                        if (quote.Contains(materialSearch.SelectedItem.ToString()))
                        {
                            quoteResults.Text = quote; 
                        }

                    }
                }
            }
            catch (FileNotFoundException exception)
            {
                quoteResults.Text = "There are no quotes yet";
            }

            mainMenuButton.Visible = true;

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu addMainMenu = new MainMenu();
            addMainMenu.Show();
            this.Hide();
        }
    }
}
