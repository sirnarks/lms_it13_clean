using lms_it13.Repositories;
using System;
using System.Windows.Forms;

namespace lms_it13
{
    public partial class ManageMyBooksControl : UserControl
    {
        public ManageMyBooksControl()
        {
            InitializeComponent();
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            dgvMyBorrowed.Columns.Clear();
            dgvMyBorrowed.Rows.Clear();

            dgvMyBorrowed.ColumnCount = 4;

            dgvMyBorrowed.Columns[0].Name = "Book ID";
            dgvMyBorrowed.Columns[1].Name = "Title";
            dgvMyBorrowed.Columns[2].Name = "Borrow Date";
            dgvMyBorrowed.Columns[3].Name = "Due Date";

            dgvMyBorrowed.AllowUserToAddRows = false;

            foreach (var record in BorrowRepository.BorrowedBooks)
            {
                if (!record.Returned)
                {
                    dgvMyBorrowed.Rows.Add(
                        record.BookId,
                        record.Title,
                        record.BorrowDate.ToShortDateString(),
                        record.DueDate.ToShortDateString()
                    );
                }
            }
        }
    }
}