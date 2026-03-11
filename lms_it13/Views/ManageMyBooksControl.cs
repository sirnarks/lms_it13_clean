using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using lms_it13.Repositories;
using lms_it13.Models;

namespace lms_it13.Views
{
    public partial class ManageMyBooksControl : UserControl
    {
        private DataGridView gridMyBooks;
        private Button btnReturn;

        public ManageMyBooksControl()
        {
            BuildUI();
            LoadBorrowedBooks();
        }

        private void BuildUI()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = ColorTranslator.FromHtml("#F7F8F0");

            // ===== GRID =====
            gridMyBooks = new DataGridView();
            gridMyBooks.Dock = DockStyle.Fill;
            gridMyBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMyBooks.AllowUserToAddRows = false;
            gridMyBooks.RowHeadersVisible = false;
            gridMyBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMyBooks.MultiSelect = false;

            this.Controls.Add(gridMyBooks);

            // ===== RETURN BUTTON =====
            btnReturn = new Button();
            btnReturn.Text = "Return Book";
            btnReturn.Height = 45;
            btnReturn.Dock = DockStyle.Bottom;
            btnReturn.BackColor = ColorTranslator.FromHtml("#355872");
            btnReturn.ForeColor = Color.White;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.Click += BtnReturn_Click;

            this.Controls.Add(btnReturn);
        }

        private void LoadBorrowedBooks()
        {
            gridMyBooks.Columns.Clear();

            gridMyBooks.Columns.Add("BookId", "ISBN");
            gridMyBooks.Columns.Add("Title", "Title");
            gridMyBooks.Columns.Add("BorrowDate", "Borrow Date");
            gridMyBooks.Columns.Add("DueDate", "Due Date");

            gridMyBooks.Rows.Clear();

            // Load only NOT returned books
            foreach (var record in BorrowRepository.BorrowedBooks
                         .Where(r => !r.Returned))
            {
                gridMyBooks.Rows.Add(
                    record.BookId,
                    record.Title,
                    record.BorrowDate.ToShortDateString(),
                    record.DueDate.ToShortDateString()
                );
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (gridMyBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a book to return.");
                return;
            }

            string isbn = gridMyBooks.SelectedRows[0].Cells["BookId"].Value.ToString();

            var record = BorrowRepository.BorrowedBooks
                .FirstOrDefault(r => r.BookId == isbn && !r.Returned);

            if (record != null)
            {
                record.Returned = true;
                record.ReturnDate = DateTime.Now;

                MessageBox.Show("Book returned successfully!");
            }

            LoadBorrowedBooks();
        }
    }
}