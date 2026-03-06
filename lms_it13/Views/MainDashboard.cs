using lms_it13.Views;
using System;
<<<<<<< HEAD
=======
using System.Drawing;   // ✅ Added this
>>>>>>> @{-1}
using System.Windows.Forms;

namespace lms_it13
{
    public partial class MainDashboard : Form
    {
        private UserRole currentRole;
        private string loggedInUser;

        public MainDashboard(UserRole role, string username)
        {
            InitializeComponent();
            ApplyTheme();
<<<<<<< HEAD
=======

>>>>>>> @{-1}
            currentRole = role;
            loggedInUser = username;

            lblLoggedUser.Text = $"Logged in as: {loggedInUser}";

            LoadUserControl(new DashboardControl());
            ApplyRolePermissions();
        }

<<<<<<< HEAD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashboardControl());
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageBooksControl());
        }

=======
>>>>>>> @{-1}
        private void LoadUserControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void ApplyRolePermissions()
        {
<<<<<<< HEAD
            // Reset all
=======
            // Reset all visibility first
>>>>>>> @{-1}
            btnDashboard.Visible = true;
            btnManageBooks.Visible = true;
            btnBrowseBooks.Visible = true;
            btnUsers.Visible = true;
            btnReports.Visible = true;
            btnSales.Visible = true;
            btnPayments.Visible = true;
            btnFines.Visible = true;
            btnTNC.Visible = true;
            btnManageMyBooks.Visible = true;

            switch (currentRole)
            {
                case UserRole.Member:
<<<<<<< HEAD
                    btnManageBooks.Visible = false;   // Cannot manage
                    btnUsers.Visible = false;
                    btnReports.Visible = false;
                    btnSales.Visible = false;

                    break;

                case UserRole.Librarian:
                    btnBrowseBooks.Visible = false;  // Not needed
=======
                    btnManageBooks.Visible = false;
                    btnUsers.Visible = false;
                    btnReports.Visible = false;
                    btnSales.Visible = false;
                    break;

                case UserRole.Librarian:
                    btnBrowseBooks.Visible = false;
>>>>>>> @{-1}
                    btnUsers.Visible = false;
                    btnManageMyBooks.Visible = false;
                    btnReports.Visible = false;
                    break;

                case UserRole.Admin:
                    btnBrowseBooks.Visible = false;
                    btnTNC.Visible = false;
                    btnManageMyBooks.Visible = false;
                    break;

                case UserRole.SuperAdmin:
<<<<<<< HEAD
                    // Everything visible
=======
>>>>>>> @{-1}
                    break;
            }
        }

<<<<<<< HEAD
        private void btnBrowseBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BrowseBooksControl());
        }
        private void btnMyBorrowedBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageMyBooksControl());
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReportsControl());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnTNC_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TermsControl());
        }
        private void btnPayments_Click(object sender, EventArgs e)
        {
            LoadUserControl(new PaymentsControl());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserManagementControl(currentRole));
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {

        }
=======
        private void btnDashboard_Click(object sender, EventArgs e)
            => LoadUserControl(new DashboardControl());

        private void btnManageBooks_Click(object sender, EventArgs e)
            => LoadUserControl(new ManageBooksControl());

        private void btnBrowseBooks_Click(object sender, EventArgs e)
            => LoadUserControl(new BrowseBooksControl());

        private void btnMyBorrowedBooks_Click(object sender, EventArgs e)
            => LoadUserControl(new ManageMyBooksControl());

        private void btnReports_Click(object sender, EventArgs e)
            => LoadUserControl(new ReportsControl());

        private void btnTNC_Click(object sender, EventArgs e)
            => LoadUserControl(new TermsControl());

        private void btnPayments_Click(object sender, EventArgs e)
            => LoadUserControl(new PaymentsControl());

        private void btnUsers_Click(object sender, EventArgs e)
            => LoadUserControl(new UserManagementControl(currentRole));
>>>>>>> @{-1}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
<<<<<<< HEAD
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );
=======
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
>>>>>>> @{-1}

            if (confirm == DialogResult.Yes)
            {
                this.Hide();
<<<<<<< HEAD

                LoginForm login = new LoginForm();
                login.Show();

                this.Close();

            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            
        }
    
=======
                new LoginForm().Show();
                this.Close();
            }
        }

>>>>>>> @{-1}
        private void ApplyTheme()
        {
            this.BackColor = ColorTranslator.FromHtml("#F7F8F0");

            panelSidebar.BackColor = ColorTranslator.FromHtml("#355872");
            panelTop.BackColor = ColorTranslator.FromHtml("#7AAACE");
            panelContent.BackColor = ColorTranslator.FromHtml("#F7F8F0");

            StyleSidebarButtons();
        }
<<<<<<< HEAD
=======

>>>>>>> @{-1}
        private void StyleSidebarButtons()
        {
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;
                    btn.BackColor = ColorTranslator.FromHtml("#355872");
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    btn.Height = 45;

                    btn.MouseEnter += (s, e) =>
<<<<<<< HEAD
                    {
                        btn.BackColor = ColorTranslator.FromHtml("#7AAACE");
                    };

                    btn.MouseLeave += (s, e) =>
                    {
                        btn.BackColor = ColorTranslator.FromHtml("#355872");
                    };
                }
            }
        }
=======
                        btn.BackColor = ColorTranslator.FromHtml("#7AAACE");

                    btn.MouseLeave += (s, e) =>
                        btn.BackColor = ColorTranslator.FromHtml("#355872");
                }
            }
        }

>>>>>>> @{-1}
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
<<<<<<< HEAD
=======
    
    private void panelContent_Paint(object sender, PaintEventArgs e) { }

        private void lblLoggedUser_Click(object sender, EventArgs e) { }

        private void panelTop_Paint(object sender, PaintEventArgs e) { }

        private void MainDashboard_Load(object sender, EventArgs e) { }

>>>>>>> @{-1}
    }
}
