using System;
using System.Windows.Forms;

namespace LicenceValidation
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void Warning_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Warning_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
