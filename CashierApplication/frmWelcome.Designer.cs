namespace CashierApplication
{
    partial class frmWelcome
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Button btnOk;

        private void InitializeComponent()
        {
            lblWelcomeMessage = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Location = new Point(14, 10);
            lblWelcomeMessage.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(0, 15);
            lblWelcomeMessage.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(230, 78);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 27);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 117);
            Controls.Add(btnOk);
            Controls.Add(lblWelcomeMessage);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmWelcome";
            Text = "Welcome";
            Load += frmWelcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
