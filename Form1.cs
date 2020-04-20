using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceValidation
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //Two Variable for Time Span

            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Parse("22/04/2020");
            
            //If Date is lower than Time span then We will give it to Run.
            //Otherwise not.
            if (fromDate >= toDate)
            {
                Warning objWarning = new Warning();
                objWarning.Show();
                objWarning.TopMost = true;
                objWarning.Activate();
                this.Enabled = false;   //Current Form will Disabled & Control goes to New one
            }
            else
            {
                Useit objUseit = new Useit();
                objUseit.Show();
                this.Hide();               
                //Do your Stuff here.
                //Continue to using this software.
            }
        }
    }
}
