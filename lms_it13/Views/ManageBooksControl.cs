using System;
using System.Windows.Forms;

namespace lms_it13
{
    public partial class ManageBooksControl : UserControl
    {
        public ManageBooksControl()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            // Prevent duplicate columns if control reloads
            dgvBooks.Columns.Clear();

            dgvBooks.ColumnCount = 4;

            dgvBooks.Columns[0].Name = "Book ID";
            dgvBooks.Columns[1].Name = "Title";
            dgvBooks.Columns[2].Name = "Author";
            dgvBooks.Columns[3].Name = "Quantity";

            dgvBooks.AllowUserToAddRows = false;

            // Sample data
            dgvBooks.Rows.Add("1", "C# Basics", "John Doe", "5");
            dgvBooks.Rows.Add("2", "OOP Concepts", "Jane Smith", "3");

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            dgvBooks.Columns.Add(deleteButton);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            dgvBooks.Rows.Add(
                txtBookId.Text,
                txtTitle.Text,
                txtAuthor.Text,
                txtQuantity.Text
            );

            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtQuantity.Clear();
        }
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBooks.Columns[e.ColumnIndex].Name == "Delete")
            {
                dgvBooks.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}