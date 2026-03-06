namespace lms_it13
{
    partial class ManageBooksControl
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            panelInputs = new Panel();
            btnAddBook = new Button();
            txtQuantity = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtBookId = new TextBox();
            dgvBooks = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(547, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 0);
            panel1.TabIndex = 4;
            // 
            // panelInputs
            // 
            panelInputs.Controls.Add(btnAddBook);
            panelInputs.Controls.Add(txtQuantity);
            panelInputs.Controls.Add(txtAuthor);
            panelInputs.Controls.Add(txtTitle);
            panelInputs.Controls.Add(txtBookId);
            panelInputs.Dock = DockStyle.Top;
            panelInputs.Location = new Point(0, 37);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(547, 60);
            panelInputs.TabIndex = 5;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(369, 6);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 9;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(263, 6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 3;
            txtQuantity.Text = "Quantity";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(157, 6);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 2;
            txtAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(86, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(65, 23);
            txtTitle.TabIndex = 1;
            txtTitle.Text = "Title";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(13, 6);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(67, 23);
            txtBookId.TabIndex = 0;
            txtBookId.Text = "ID";
            // 
            // dgvBooks
            // 
            dgvBooks.CausesValidation = false;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(0, 97);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(547, 255);
            dgvBooks.TabIndex = 7;
            dgvBooks.CellClick += dgvBooks_CellClick;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ManageBooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBooks);
            Controls.Add(panelInputs);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ManageBooksControl";
            Size = new Size(547, 352);
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panelInputs;
        private DataGridView dgvBooks;
        private TextBox txtTitle;
        private TextBox txtBookId;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtQuantity;
        private TextBox txtAuthor;
        private Button btnAddBook;
    }
}
