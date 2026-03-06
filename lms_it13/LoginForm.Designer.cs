namespace lms_it13
{
    partial class LoginForm
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
            lmglogin = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            username = new Label();
            password = new Label();
            panelLogin = new Panel();
            label1 = new Label();
            label2 = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lmglogin
            // 
            lmglogin.Font = new Font("Segoe UI", 20F);
            lmglogin.Location = new Point(3, 225);
            lmglogin.Name = "lmglogin";
            lmglogin.Size = new Size(97, 46);
            lmglogin.TabIndex = 0;
            lmglogin.Text = "LOGIN";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(122, 262);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(160, 23);
            txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(53, 88, 114);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(122, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 297);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 3;
            // 
            // username
            // 
            username.Location = new Point(53, 265);
            username.Name = "username";
            username.Size = new Size(63, 15);
            username.TabIndex = 4;
            username.Text = "Username:";
            username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(56, 297);
            password.Name = "password";
            password.Size = new Size(60, 15);
            password.TabIndex = 5;
            password.Text = "Password:";
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(password);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(username);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Location = new Point(201, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(350, 400);
            panelLogin.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(53, 88, 114);
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 50);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Location = new Point(98, 74);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 7;
            label2.Text = "Library Management System";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 240);
            ClientSize = new Size(747, 451);
            Controls.Add(panelLogin);
            Controls.Add(lmglogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lmglogin;
        private TextBox txtUsername;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label username;
        private Label password;
        private Panel panelLogin;
        private Label label2;
        private Label label1;
    }
}
