using System;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmWelcome : Form
    {
        private string fullName;
        private string department;

        public frmWelcome(string fullName, string department)
        {
            InitializeComponent();
            this.fullName = fullName;
            this.department = department;
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = $"Welcome {fullName} of {department}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the welcome form
        }
    }
}
