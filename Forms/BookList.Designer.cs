namespace BibliotecaPilar.Forms
{
    partial class BookList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvBooks = new DataGridView();
            bookBindingSource = new BindingSource(components);
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnRegisterBook = new Button();
            grpBooks = new GroupBox();
            btnReturnBook = new Button();
            btnWithdrawnBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            grpBooks.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(13, 26);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.ScrollBars = ScrollBars.Horizontal;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(634, 406);
            dgvBooks.TabIndex = 0;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Book);
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteBook.Image = Properties.Resources.trash;
            btnDeleteBook.Location = new Point(547, 438);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(100, 35);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "Excluir";
            btnDeleteBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += BtnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateBook.Image = Properties.Resources.edit;
            btnUpdateBook.Location = new Point(441, 438);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(100, 35);
            btnUpdateBook.TabIndex = 4;
            btnUpdateBook.Text = "Alterar";
            btnUpdateBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += BtnUpdateBook_Click;
            // 
            // btnRegisterBook
            // 
            btnRegisterBook.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterBook.Image = Properties.Resources.plus;
            btnRegisterBook.Location = new Point(335, 438);
            btnRegisterBook.Name = "btnRegisterBook";
            btnRegisterBook.Size = new Size(100, 35);
            btnRegisterBook.TabIndex = 5;
            btnRegisterBook.Text = "Incluir";
            btnRegisterBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegisterBook.UseVisualStyleBackColor = true;
            btnRegisterBook.Click += BtnRegisterBook_Click;
            // 
            // grpBooks
            // 
            grpBooks.Controls.Add(btnReturnBook);
            grpBooks.Controls.Add(btnWithdrawnBook);
            grpBooks.Controls.Add(dgvBooks);
            grpBooks.Controls.Add(btnDeleteBook);
            grpBooks.Controls.Add(btnUpdateBook);
            grpBooks.Controls.Add(btnRegisterBook);
            grpBooks.Location = new Point(12, 12);
            grpBooks.Name = "grpBooks";
            grpBooks.Padding = new Padding(10, 5, 10, 10);
            grpBooks.Size = new Size(660, 487);
            grpBooks.TabIndex = 7;
            grpBooks.TabStop = false;
            grpBooks.Text = "Livros";
            // 
            // btnReturnBook
            // 
            btnReturnBook.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnBook.Image = Properties.Resources.returnBook;
            btnReturnBook.Location = new Point(13, 438);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(130, 35);
            btnReturnBook.TabIndex = 8;
            btnReturnBook.Text = "Devolver Livro";
            btnReturnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnWithdrawnBook
            // 
            btnWithdrawnBook.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithdrawnBook.Image = Properties.Resources.borrowBook;
            btnWithdrawnBook.Location = new Point(149, 438);
            btnWithdrawnBook.Name = "btnWithdrawnBook";
            btnWithdrawnBook.Size = new Size(130, 35);
            btnWithdrawnBook.TabIndex = 7;
            btnWithdrawnBook.Text = "Retirar Livro";
            btnWithdrawnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWithdrawnBook.UseVisualStyleBackColor = true;
            btnWithdrawnBook.Click += btnWithdrawnBook_Click;
            // 
            // BookList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 511);
            Controls.Add(grpBooks);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de Livros";
            FormClosing += BookList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            grpBooks.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooks;
        private BindingSource bookBindingSource;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnRegisterBook;
        private GroupBox grpBooks;
        private Button btnWithdrawnBook;
        private Button btnReturnBook;
    }
}