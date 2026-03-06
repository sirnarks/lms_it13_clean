namespace lms_it13
{
    partial class TermsControl
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
            termsandconidition = new Label();
            txtTerms = new TextBox();
            SuspendLayout();
            // 
            // termsandconidition
            // 
            termsandconidition.AutoSize = true;
            termsandconidition.Dock = DockStyle.Top;
            termsandconidition.Font = new Font("Segoe UI", 20F);
            termsandconidition.Location = new Point(0, 0);
            termsandconidition.Name = "termsandconidition";
            termsandconidition.Size = new Size(244, 37);
            termsandconidition.TabIndex = 0;
            termsandconidition.Text = "(Terms & Conditions)";
            // 
            // txtTerms
            // 
            txtTerms.Dock = DockStyle.Fill;
            txtTerms.Location = new Point(0, 37);
            txtTerms.Multiline = true;
            txtTerms.Name = "txtTerms";
            txtTerms.ReadOnly = true;
            txtTerms.Size = new Size(532, 236);
            txtTerms.TabIndex = 2;
            txtTerms.TextChanged += textBox1_TextChanged;
            // 
            // TermsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtTerms);
            Controls.Add(termsandconidition);
            Name = "TermsControl";
            Size = new Size(532, 273);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label termsandconidition;
        private TextBox txtTerms;
    }
}
