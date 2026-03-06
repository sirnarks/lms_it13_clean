namespace lms_it13
{
    partial class PaymentsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            payments = new Label();
            lblFineDue = new Label();
            btnPayFine = new Button();
            dgvPayments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // payments
            // 
            payments.Dock = DockStyle.Top;
            payments.Font = new Font("Segoe UI", 20F);
            payments.Location = new Point(0, 0);
            payments.Name = "payments";
            payments.Size = new Size(593, 50);
            payments.TabIndex = 0;
            payments.Text = "Payments";
            // 
            // lblFineDue
            // 
            lblFineDue.AutoSize = true;
            lblFineDue.Dock = DockStyle.Top;
            lblFineDue.Location = new Point(0, 50);
            lblFineDue.Name = "lblFineDue";
            lblFineDue.Size = new Size(65, 15);
            lblFineDue.TabIndex = 1;
            lblFineDue.Text = "Fine Due: 0";
            // 
            // btnPayFine
            // 
            btnPayFine.Location = new Point(98, 46);
            btnPayFine.Name = "btnPayFine";
            btnPayFine.Size = new Size(75, 23);
            btnPayFine.TabIndex = 2;
            btnPayFine.Text = "Pay Fine";
            btnPayFine.UseVisualStyleBackColor = true;
            btnPayFine.Click += btnPayFine_Click;
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.Location = new Point(0, 65);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.Size = new Size(593, 336);
            dgvPayments.TabIndex = 3;
            // 
            // PaymentsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPayments);
            Controls.Add(btnPayFine);
            Controls.Add(lblFineDue);
            Controls.Add(payments);
            Name = "PaymentsControl";
            Size = new Size(593, 401);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label payments;
        private Label lblFineDue;
        private Button btnPayFine;
        private DataGridView dgvPayments;
    }
}
