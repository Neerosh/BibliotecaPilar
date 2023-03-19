namespace BibliotecaPilar.Forms
{
    partial class ReserveForm
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
            dgvReserves = new DataGridView();
            grpReserves = new GroupBox();
            grpBooks = new GroupBox();
            btnShowAll = new Button();
            btnSearch = new Button();
            txtBookAuthor = new TextBox();
            lblBookAuthor = new Label();
            lblBookStatus = new Label();
            cmbBookStatus = new ComboBox();
            dgvBooks = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            synopsisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            lblReserveStartDate = new Label();
            label1 = new Label();
            txtReserveStartDate = new MaskedTextBox();
            txtReserveEndDate = new MaskedTextBox();
            grpReserve = new GroupBox();
            btnSave = new Button();
            lblValueReserve = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReserves).BeginInit();
            grpReserves.SuspendLayout();
            grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            grpReserve.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReserves
            // 
            dgvReserves.AllowUserToAddRows = false;
            dgvReserves.AllowUserToDeleteRows = false;
            dgvReserves.BorderStyle = BorderStyle.None;
            dgvReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserves.Location = new Point(13, 24);
            dgvReserves.Name = "dgvReserves";
            dgvReserves.ReadOnly = true;
            dgvReserves.RowHeadersVisible = false;
            dgvReserves.RowTemplate.Height = 25;
            dgvReserves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReserves.Size = new Size(484, 131);
            dgvReserves.TabIndex = 0;
            // 
            // grpReserves
            // 
            grpReserves.Controls.Add(dgvReserves);
            grpReserves.Location = new Point(13, 268);
            grpReserves.Name = "grpReserves";
            grpReserves.Padding = new Padding(10, 3, 10, 10);
            grpReserves.Size = new Size(510, 168);
            grpReserves.TabIndex = 1;
            grpReserves.TabStop = false;
            grpReserves.Text = "Reservas";
            // 
            // grpBooks
            // 
            grpBooks.Controls.Add(btnShowAll);
            grpBooks.Controls.Add(btnSearch);
            grpBooks.Controls.Add(txtBookAuthor);
            grpBooks.Controls.Add(lblBookAuthor);
            grpBooks.Controls.Add(lblBookStatus);
            grpBooks.Controls.Add(grpReserves);
            grpBooks.Controls.Add(cmbBookStatus);
            grpBooks.Controls.Add(dgvBooks);
            grpBooks.Location = new Point(12, 5);
            grpBooks.Name = "grpBooks";
            grpBooks.Padding = new Padding(10);
            grpBooks.Size = new Size(538, 449);
            grpBooks.TabIndex = 2;
            grpBooks.TabStop = false;
            grpBooks.Text = "Livros";
            // 
            // btnShowAll
            // 
            btnShowAll.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowAll.Image = Properties.Resources.list;
            btnShowAll.Location = new Point(383, 60);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(140, 35);
            btnShowAll.TabIndex = 12;
            btnShowAll.Text = "Mostrar Todos";
            btnShowAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += BtnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(403, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 35);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Pesquisar";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(70, 25);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(327, 25);
            txtBookAuthor.TabIndex = 4;
            // 
            // lblBookAuthor
            // 
            lblBookAuthor.AutoSize = true;
            lblBookAuthor.Location = new Point(13, 28);
            lblBookAuthor.Name = "lblBookAuthor";
            lblBookAuthor.Size = new Size(43, 17);
            lblBookAuthor.TabIndex = 3;
            lblBookAuthor.Text = "Autor:";
            // 
            // lblBookStatus
            // 
            lblBookStatus.AutoSize = true;
            lblBookStatus.Location = new Point(13, 64);
            lblBookStatus.Name = "lblBookStatus";
            lblBookStatus.Size = new Size(51, 17);
            lblBookStatus.TabIndex = 2;
            lblBookStatus.Text = "Estado:";
            // 
            // cmbBookStatus
            // 
            cmbBookStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookStatus.FormattingEnabled = true;
            cmbBookStatus.Items.AddRange(new object[] { "Todos", "Disponível", "Reservado", "Retirado" });
            cmbBookStatus.Location = new Point(70, 61);
            cmbBookStatus.Name = "cmbBookStatus";
            cmbBookStatus.Size = new Size(127, 25);
            cmbBookStatus.TabIndex = 1;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn1, synopsisDataGridViewTextBoxColumn });
            dgvBooks.DataSource = bookBindingSource;
            dgvBooks.Location = new Point(13, 101);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.ScrollBars = ScrollBars.Horizontal;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(510, 161);
            dgvBooks.TabIndex = 0;
            dgvBooks.SelectionChanged += DgvBooks_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 69;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Autor";
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.ReadOnly = true;
            authorDataGridViewTextBoxColumn.Width = 65;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn1.HeaderText = "Estado";
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            statusDataGridViewTextBoxColumn1.ReadOnly = true;
            statusDataGridViewTextBoxColumn1.Width = 73;
            // 
            // synopsisDataGridViewTextBoxColumn
            // 
            synopsisDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            synopsisDataGridViewTextBoxColumn.DataPropertyName = "Synopsis";
            synopsisDataGridViewTextBoxColumn.HeaderText = "Sinopse";
            synopsisDataGridViewTextBoxColumn.Name = "synopsisDataGridViewTextBoxColumn";
            synopsisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Book);
            // 
            // lblReserveStartDate
            // 
            lblReserveStartDate.AutoSize = true;
            lblReserveStartDate.Location = new Point(13, 28);
            lblReserveStartDate.Name = "lblReserveStartDate";
            lblReserveStartDate.Size = new Size(74, 17);
            lblReserveStartDate.TabIndex = 4;
            lblReserveStartDate.Text = "Data Inicial:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 5;
            label1.Text = "Data Final:";
            // 
            // txtReserveStartDate
            // 
            txtReserveStartDate.Location = new Point(93, 25);
            txtReserveStartDate.Mask = "00/00/0000";
            txtReserveStartDate.Name = "txtReserveStartDate";
            txtReserveStartDate.Size = new Size(78, 25);
            txtReserveStartDate.TabIndex = 6;
            txtReserveStartDate.ValidatingType = typeof(DateTime);
            txtReserveStartDate.Validated += TxtReserveStartDate_Validated;
            // 
            // txtReserveEndDate
            // 
            txtReserveEndDate.Location = new Point(266, 25);
            txtReserveEndDate.Mask = "00/00/0000";
            txtReserveEndDate.Name = "txtReserveEndDate";
            txtReserveEndDate.ReadOnly = true;
            txtReserveEndDate.Size = new Size(78, 25);
            txtReserveEndDate.TabIndex = 7;
            txtReserveEndDate.ValidatingType = typeof(DateTime);
            txtReserveEndDate.Validated += TxtReserveEndDate_Validated;
            // 
            // grpReserve
            // 
            grpReserve.Controls.Add(btnSave);
            grpReserve.Controls.Add(lblReserveStartDate);
            grpReserve.Controls.Add(txtReserveEndDate);
            grpReserve.Controls.Add(label1);
            grpReserve.Controls.Add(txtReserveStartDate);
            grpReserve.Location = new Point(12, 494);
            grpReserve.Name = "grpReserve";
            grpReserve.Padding = new Padding(10);
            grpReserve.Size = new Size(538, 64);
            grpReserve.TabIndex = 8;
            grpReserve.TabStop = false;
            grpReserve.Text = "Reservar Livro Selecionado";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = Properties.Resources.plus;
            btnSave.Location = new Point(413, 19);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 12;
            btnSave.Text = " Salvar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // lblValueReserve
            // 
            lblValueReserve.AutoSize = true;
            lblValueReserve.ForeColor = Color.Red;
            lblValueReserve.Location = new Point(12, 457);
            lblValueReserve.Name = "lblValueReserve";
            lblValueReserve.Size = new Size(387, 34);
            lblValueReserve.TabIndex = 9;
            lblValueReserve.Text = "* O valor inicial da reserva é de R$ 30,00.\r\nÉ incluida uma multa de 0,1% por dia atrasado após a data final.";
            // 
            // ReserveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 571);
            Controls.Add(lblValueReserve);
            Controls.Add(grpReserve);
            Controls.Add(grpBooks);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReserveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Reservas";
            FormClosing += ReserveForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvReserves).EndInit();
            grpReserves.ResumeLayout(false);
            grpBooks.ResumeLayout(false);
            grpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            grpReserve.ResumeLayout(false);
            grpReserve.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReserves;
        private GroupBox grpReserves;
        private GroupBox grpBooks;
        private TextBox txtBookAuthor;
        private Label lblBookAuthor;
        private Label lblBookStatus;
        private ComboBox cmbBookStatus;
        private DataGridView dgvBooks;
        private BindingSource bookBindingSource;
        private Button btnShowAll;
        private Button btnSearch;
        private Label lblReserveStartDate;
        private Label label1;
        private MaskedTextBox txtReserveStartDate;
        private MaskedTextBox txtReserveEndDate;
        private GroupBox grpReserve;
        private Button btnSave;
        private Label lblValueReserve;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn synopsisDataGridViewTextBoxColumn;
    }
}