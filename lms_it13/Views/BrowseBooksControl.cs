using System;
using System.Drawing;
using System.Windows.Forms;
using lms_it13.Repositories;
using lms_it13.Models;

namespace lms_it13.Views
{
    public partial class BrowseBooksControl : UserControl
    {
        private Label lblTitle;
        private Label lblAllBooks;
        private Label lblRemaining;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnImport;
        private DataGridView gridBooks;
        private Panel topPanel;
        private Button btnBorrow;


        public BrowseBooksControl()
        {
            BuildUI();
            LoadDummyData();
        }

        private void BuildUI()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = ColorTranslator.FromHtml("#F7F8F0");

            // ===== GRID =====
            gridBooks = new DataGridView();
            gridBooks.Dock = DockStyle.Fill;
            gridBooks.BackgroundColor = Color.White;
            gridBooks.BorderStyle = BorderStyle.None;
            gridBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridBooks.AllowUserToAddRows = false;
            gridBooks.RowHeadersVisible = false;
            gridBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBooks.MultiSelect = false;
            gridBooks.EnableHeadersVisualStyles = false;
            gridBooks.DefaultCellStyle.SelectionBackColor = Color.White;
            gridBooks.DefaultCellStyle.SelectionForeColor = Color.Black;
            gridBooks.GridColor = Color.LightGray;
            gridBooks.DefaultCellStyle.SelectionBackColor =
    ColorTranslator.FromHtml("#DCEAF5");

            gridBooks.DefaultCellStyle.SelectionForeColor = Color.Black;

            this.Controls.Add(gridBooks);

            // ===== TOP PANEL =====
            topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 130;
            topPanel.Padding = new Padding(20);
            topPanel.BackColor = ColorTranslator.FromHtml("#F7F8F0");
            this.Controls.Add(topPanel);

            // Title
            lblTitle = new Label();
            lblTitle.Text = "Books";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = ColorTranslator.FromHtml("#355872");
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 10);
            topPanel.Controls.Add(lblTitle);

            // Stats
            lblAllBooks = new Label();
            lblAllBooks.Text = "All Books: 3";
            lblAllBooks.Location = new Point(25, 65);
            lblAllBooks.AutoSize = true;
            topPanel.Controls.Add(lblAllBooks);

            lblRemaining = new Label();
            lblRemaining.Text = "Remaining: 3";
            lblRemaining.Location = new Point(150, 65);
            lblRemaining.AutoSize = true;
            topPanel.Controls.Add(lblRemaining);

            // ===== RIGHT PANEL (Search + Buttons) =====
            Panel rightPanel = new Panel();
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Width = 420;
            rightPanel.Padding = new Padding(0, 40, 20, 0);
            topPanel.Controls.Add(rightPanel);

            // Search
            txtSearch = new TextBox();
            txtSearch.PlaceholderText = "Search book...";
            txtSearch.Size = new Size(160, 30);
            txtSearch.Location = new Point(0, 0);
            rightPanel.Controls.Add(txtSearch);

            // Borrow
            btnBorrow = new Button();
            btnBorrow.Text = "Borrow";
            btnBorrow.Size = new Size(90, 30);
            btnBorrow.Location = new Point(170, 0);
            btnBorrow.BackColor = ColorTranslator.FromHtml("#7AAACE");
            btnBorrow.ForeColor = Color.White;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.Click += BtnBorrow_Click;
            rightPanel.Controls.Add(btnBorrow);

            // Add
            btnAdd = new Button();
            btnAdd.Text = "Add Book";
            btnAdd.Size = new Size(100, 30);
            btnAdd.Location = new Point(270, 0);
            btnAdd.BackColor = ColorTranslator.FromHtml("#355872");
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            rightPanel.Controls.Add(btnAdd);
        }

        private void LoadDummyData()
        {
            gridBooks.Columns.Clear();

            gridBooks.Columns.Add("ISBN", "ISBN");
            gridBooks.Columns.Add("Title", "Title");
            gridBooks.Columns.Add("Author", "Author");
            gridBooks.Columns.Add("Publisher", "Publisher");
            gridBooks.Columns.Add("Quantity", "Qty");
            gridBooks.Columns.Add("Remaining", "Remaining");
            gridBooks.Columns.Add("Section", "Section");
            gridBooks.Columns.Add("Status", "Status");

            gridBooks.Rows.Add(
                "9780131103627",
                "C Programming",
                "Dennis Ritchie",
                "Pearson",
                5,
                5,
                "Long Loan",
                "Available"
            );

            gridBooks.Rows.Add(
                "9780201633610",
                "Design Patterns",
                "GoF",
                "Addison-Wesley",
                3,
                2,
                "Short Loan",
                "Available"
            );

            gridBooks.Rows.Add(
                "9780132350884",
                "Clean Code",
                "Robert C. Martin",
                "Prentice Hall",
                4,
                1,
                "Long Loan",
                "Limited"
            );
        }
        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book first.");
                return;
            }

            var row = gridBooks.SelectedRows[0];

            int remaining = Convert.ToInt32(row.Cells["Remaining"].Value);

            if (remaining <= 0)
            {
                MessageBox.Show("This book is not available.");
                return;
            }

            remaining--;
            row.Cells["Remaining"].Value = remaining;

            if (remaining == 0)
                row.Cells["Status"].Value = "Not Available";

            // 🔹 ADD TO BORROW LIST
            BorrowRepository.BorrowedBooks.Add(new BorrowRecord
            {
                MemberName = "superadmin", // replace later with logged user
                BookId = row.Cells["ISBN"].Value.ToString(),
                Title = row.Cells["Title"].Value.ToString(),
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                Returned = false
            });

            MessageBox.Show("Book borrowed successfully!");
        }

    }

}