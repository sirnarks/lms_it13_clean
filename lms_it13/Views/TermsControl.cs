using lms_it13.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lms_it13
{
    public partial class TermsControl : UserControl
    {
        public TermsControl()
        {
            InitializeComponent();
            LoadTerms();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void LoadTerms()
        {
            txtTerms.Text =
                "Library Terms & Conditions\n\n" +
                "Borrow period: " + LibraryPolicy.BorrowDays + " days\n" +
                "Fine per overdue day: " + LibraryPolicy.FinePerDay + "\n" +
                "Membership Fee: " + LibraryPolicy.MembershipFee + "\n" +
                "Maximum books allowed: " + LibraryPolicy.MaxBooksAllowed + "\n\n" +
                "Members must return books before due date to avoid fines.";
        }

    }
}
