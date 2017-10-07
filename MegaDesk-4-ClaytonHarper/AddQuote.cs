using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ClaytonHarper
{
    public partial class AddQuote : Form
    {


        public AddQuote()
        {
            InitializeComponent();
            deskMaterial.DataSource = Enum.GetValues(typeof(Desk.Material));
        }

        private void rushOrderCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rushOrderCheck.Checked == true)
            {
                rushNumberOfDays.Visible = true;
                dayLabel.Visible = true;
            }
            else if (rushOrderCheck.Checked == false)
            {
                rushNumberOfDays.Visible = false;
                dayLabel.Visible = false;
            }
        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            if (customerName.Text.Contains(',') || String.IsNullOrEmpty(customerName.Text))
            {
                customerName.BackColor = Color.Red;
                errorName.Visible = true;
            }
            else
            {
                Desk desk = new Desk();
                desk.Width = (int)deskWidth.Value;
                desk.Depth = (int)deskDepth.Value;
                desk.Drawers = (int)numberOfDrawers.Value;
                desk.DeskMaterial = deskMaterial.SelectedItem.ToString();
                DeskQuote deskQuote = new DeskQuote(desk);
                deskQuote.CustomerName = customerName.Text;
                deskQuote.QuoteDate = DateTime.Now;
                deskQuote.QuotePrice = deskQuote.GetQuote();

                if (rushOrderCheck.Checked == true)
                {
                    deskQuote.RushOrder = (int)rushNumberOfDays.Value;
                }
                else
                {
                    deskQuote.RushOrder = 14;
                }


                DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote, desk);
                displayQuoteForm.Show();
                this.Hide();

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
