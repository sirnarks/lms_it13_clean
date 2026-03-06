using lms_it13.Models;
using lms_it13.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lms_it13
{
    public partial class PaymentsControl : UserControl
    {
        public PaymentsControl()
        {
            InitializeComponent();
            LoadFine();
            LoadPayments();
        }
        private decimal CalculateFine()
        {
            decimal totalFine = 0;

            foreach (var record in BorrowRepository.BorrowedBooks)
            {
                if (!record.Returned && DateTime.Now > record.DueDate)
                {
                    int overdueDays = (DateTime.Now - record.DueDate).Days;
                    totalFine += overdueDays * LibraryPolicy.FinePerDay;
                }
            }

            return totalFine;
        }
        private void LoadFine()
        {
            decimal fine = CalculateFine();
            lblFineDue.Text = "Fine Due: " + fine;
        }
        private void LoadPayments()
        {
            dgvPayments.Columns.Clear();
            dgvPayments.Rows.Clear();

            dgvPayments.ColumnCount = 3;

            dgvPayments.Columns[0].Name = "Description";
            dgvPayments.Columns[1].Name = "Amount";
            dgvPayments.Columns[2].Name = "Date";

            dgvPayments.AllowUserToAddRows = false;

            foreach (var payment in PaymentRepository.Payments)
            {
                dgvPayments.Rows.Add(
                    payment.Description,
                    payment.Amount,
                    payment.PaymentDate.ToShortDateString()
                );
            }
        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            decimal fine = CalculateFine();

            if (fine <= 0)
            {
                MessageBox.Show("No fine to pay.");
                return;
            }

            PaymentRepository.Payments.Add(new PaymentRecord
            {
                MemberName = "Member1",
                Description = "Overdue Fine",
                Amount = fine,
                PaymentDate = DateTime.Now
            });

            MessageBox.Show("Fine paid successfully.");

            LoadFine();
            LoadPayments();
        }
    }
}
