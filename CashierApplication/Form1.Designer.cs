namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtItemName = new TextBox();
            txtDiscount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            btnComputeTotal = new Button();
            label5 = new Label();
            lblTotalAmount = new Label();
            label7 = new Label();
            txtPaymentReceived = new TextBox();
            btnSubmit = new Button();
            label8 = new Label();
            lblChange = new Label();
            menuStrip1 = new MenuStrip();
            menuStrip = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(13, 51);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(209, 23);
            txtItemName.TabIndex = 1;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(236, 51);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 33);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Discount (%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 83);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(52, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 23);
            txtPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 88);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(298, 83);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(41, 23);
            txtQuantity.TabIndex = 7;
            // 
            // btnComputeTotal
            // 
            btnComputeTotal.Location = new Point(158, 111);
            btnComputeTotal.Name = "btnComputeTotal";
            btnComputeTotal.Size = new Size(75, 23);
            btnComputeTotal.TabIndex = 8;
            btnComputeTotal.Text = "Compute";
            btnComputeTotal.UseVisualStyleBackColor = true;
            btnComputeTotal.Click += btnComputeTotal_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 151);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 9;
            label5.Text = "Total amount:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(120, 151);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 15);
            lblTotalAmount.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 187);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 11;
            label7.Text = "Payment Received:";
            // 
            // txtPaymentReceived
            // 
            txtPaymentReceived.Location = new Point(147, 187);
            txtPaymentReceived.Name = "txtPaymentReceived";
            txtPaymentReceived.Size = new Size(100, 23);
            txtPaymentReceived.TabIndex = 12;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(264, 187);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 228);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 14;
            label8.Text = "Change:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(147, 228);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(0, 15);
            lblChange.TabIndex = 15;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuStrip, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(363, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuStrip
            // 
            menuStrip.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem1, exitApplicationToolStripMenuItem1 });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(37, 20);
            menuStrip.Text = "File";
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(157, 22);
            logOutToolStripMenuItem1.Text = "Logout";
            logOutToolStripMenuItem1.Click += logOutToolStripMenuItem1_Click;
            // 
            // exitApplicationToolStripMenuItem1
            // 
            exitApplicationToolStripMenuItem1.Name = "exitApplicationToolStripMenuItem1";
            exitApplicationToolStripMenuItem1.Size = new Size(157, 22);
            exitApplicationToolStripMenuItem1.Text = "Exit Application";
            exitApplicationToolStripMenuItem1.Click += exitApplicationToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(180, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(180, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 269);
            Controls.Add(lblChange);
            Controls.Add(label8);
            Controls.Add(btnSubmit);
            Controls.Add(txtPaymentReceived);
            Controls.Add(label7);
            Controls.Add(lblTotalAmount);
            Controls.Add(label5);
            Controls.Add(btnComputeTotal);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDiscount);
            Controls.Add(txtItemName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "frmPurchaseDiscountedItem";
            Text = "PurchaseDiscountedItem";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtItemName;
        private TextBox txtDiscount;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtQuantity;
        private Button btnComputeTotal;
        private Label label5;
        private Label lblTotalAmount;
        private Label label7;
        private TextBox txtPaymentReceived;
        private Button btnSubmit;
        private Label label8;
        private Label lblChange;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private ToolStripMenuItem exitApplicationToolStripMenuItem1;
    }
}
