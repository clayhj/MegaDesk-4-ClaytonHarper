﻿using System;
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
            }
            else if (rushOrderCheck.Checked == false)
            {
                rushNumberOfDays.Visible = false;
            }
        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Show();
            this.Hide();
        }
    }
}