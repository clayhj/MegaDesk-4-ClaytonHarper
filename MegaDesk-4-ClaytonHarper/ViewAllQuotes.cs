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

namespace MegaDesk_3_ClaytonHarper
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            string path = "quotes.txt";
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] quotes = sr.ReadLine().Split(',');
                        displayQuotesTable.Rows.Add(quotes[0], quotes[1], quotes[2], quotes[3], quotes[4], quotes[5], quotes[6]);

                    }
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
