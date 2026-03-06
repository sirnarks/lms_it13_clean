using System;
using System.Windows.Forms;
using lms_it13.Models;
using lms_it13.Repositories;

namespace lms_it13
{
    public partial class BrowseBooksControl : UserControl
    {
        public BrowseBooksControl()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dgvBrowseBooks.Columns.Clear();
            dgvBrowseBooks.Rows.Clear();

            dgvBrowseBooks.ColumnCount = 4;

            dgvBrowseBooks.Columns[0].Name = "Book ID";
            dgvBrowseBooks.Columns[1].Name = "Title";
            dgvBrowseBooks.Columns[2].Name = "Author";
            dgvBrowseBooks.Columns[3].Name = "Quantity";

            dgvBrowseBooks.AllowUserToAddRows = false;

            // Sample data (temporary)
            dgvBrowseBooks.Rows.Add("1", "C# Basics", "John Doe", 5);
            dgvBrowseBooks.Rows.Add("2", "OOP Concepts", "Jane Smith", 3);

            // Borrow button
            DataGridViewButtonColumn borrowButton = new DataGridViewButtonColumn();
            borrowButton.Name = "Borrow";
            borrowButton.Text = "Borrow";
            borrowButton.UseColumnTextForButtonValue = true;
            dgvBrowseBooks.Columns.Add(borrowButton);

            dgvBrowseBooks.CellClick += dgvBrowseBooks_CellClick;
        }

        private void dgvBrowseBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvBrowseBooks.Columns[e.ColumnIndex].Name == "Borrow")
            {
                int quantity = Convert.ToInt32(
                    dgvBrowseBooks.Rows[e.RowIndex].Cells["Quantity"].Value
                );

                if (quantity > 0)
                {
                    string bookId = dgvBrowseBooks.Rows[e.RowIndex]
                        .Cells["Book ID"].Value.ToString();

                    string title = dgvBrowseBooks.Rows[e.RowIndex]
                        .Cells["Title"].Value.ToString();

                    // Reduce quantity
                    dgvBrowseBooks.Rows[e.RowIndex]
                        .Cells["Quantity"].Value = quantity - 1;

                    BorrowRepository.BorrowedBooks.Add(new BorrowRecord
                    {
                        MemberName = "Member1",
                        BookId = bookId,
                        Title = title,
                        BorrowDate = DateTime.Now,
                        DueDate = DateTime.Now.AddDays(-2),
                        Returned = false
                    });
                    MessageBox.Show("Book borrowed successfully.");
                }
                else
                {
                    MessageBox.Show("Book not available.");
                }
            }
        }
    }
}