using lms_it13.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace lms_it13
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = UserRepository.Users
                .FirstOrDefault(u =>
                    u.Name.Equals(username, StringComparison.OrdinalIgnoreCase)
                    && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            UserRole role = Enum.Parse<UserRole>(user.Role);

            MainDashboard dashboard = new MainDashboard(role, user.Name);
            dashboard.Show();

            this.Hide();
            btnLogin.MouseEnter += (s, e) =>
            {
                btnLogin.BackColor = ColorTranslator.FromHtml("#7AAACE");
            };

            btnLogin.MouseLeave += (s, e) =>
            {
                btnLogin.BackColor = ColorTranslator.FromHtml("#355872");
            };
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

    }
}