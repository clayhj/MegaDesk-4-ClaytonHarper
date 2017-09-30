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
    public partial class DisplayQuote : Form
    {
        AddQuote ownerForm = null;
        public DisplayQuote(AddQuote ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            DeskQuote deskQuote = new DeskQuote();
        }
    }
}
