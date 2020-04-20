using System.Windows.Forms;

namespace LicenceValidation
{
    public partial class Useit : Form
    {
        public Useit()
        {
            InitializeComponent();
        }

        private void Useit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
