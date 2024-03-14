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

        // Example deck for testing.
        // In the future, this information should be stored in separate files.
        string[] prompts =
        {
            "What color is the sky?",
            "How many hours are in a day?",
            "What programming language do Windows forms use?",
            "How many feet are in a mile?",
            "What year did the USA declare independence?"
        };
        string[] answers = { "blue", "24", "c#", "5280", "1776" };
        string userAnswer = "";

        private void frmStudy_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Placeholder behavior
            userAnswer = txtAnswer.Text;
            txtAnswer.Clear();
            txtAnswer.Focus();
        }
    }
}
