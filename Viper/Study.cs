using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viper
{
    public partial class frmStudy : Form
    {
        public frmStudy()
        {
            InitializeComponent();
        }

        Deck deck1 = new Deck("Deck1");

        private void frmStudy_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Placeholder behavior
            txtAnswer.Clear();
            txtAnswer.Focus();
        }
    }
}
