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
            string path = "C:\\Users\\clayh\\Desktop\\CIT365\\quotes.txt";
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    displayQuotes.Text = sr.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                displayQuotes.Text = "There are no quotes yet";
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
