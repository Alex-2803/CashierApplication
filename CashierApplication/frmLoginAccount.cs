using System;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;

        public frmLoginAccount()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●'; // Hide password characters

            // Set the cashier account with required credentials
            cashier = new Cashier("Clarisa Castro", "Finance", "cashier101", "123456");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (cashier.validateLogin(username, password))
            {
                this.Hide();
                frmWelcome welcomeForm = new frmWelcome(cashier.getFullName(), cashier.getDepartment());
                welcomeForm.ShowDialog(); // Show as a dialog
                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                purchaseForm.Show(); // Show the purchase form
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
