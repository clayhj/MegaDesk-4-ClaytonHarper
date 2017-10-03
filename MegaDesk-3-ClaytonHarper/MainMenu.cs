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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
            this.Hide();

        }

        

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewQuoteForm = new ViewAllQuotes();
            addViewQuoteForm.Show();
            this.Hide();
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes addSearchQuoteForm = new SearchQuotes();
            addSearchQuoteForm.Show();
            this.Hide();
        }
    }
}
