using ItemNamespace;
using System;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form load if needed
        }

        private void btnComputeTotal_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);

                DiscountedItem item = new DiscountedItem(name, price, quantity, discount);
                double total = item.getTotalPrice();

                lblTotalAmount.Text = total.ToString("F2"); // F2 for fixed-point format with 2 decimal places
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for price, quantity, and discount.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double payment = Convert.ToDouble(txtPaymentReceived.Text);

                string name = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);

                DiscountedItem item = new DiscountedItem(name, price, quantity, discount);
                item.getTotalPrice();
                item.setPayment(payment);

                double change = item.getChange();
                lblChange.Text = change.ToString("F2"); // F2 for fixed-point format with 2 decimal places
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for payment received.");
            }
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
        }

        private void exitApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
