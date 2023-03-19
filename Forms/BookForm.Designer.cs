namespace BibliotecaPilar.Forms
{
    partial class BookForm
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
            lblName = new Label();
            lblAuthor = new Label();
            lblSynopsis = new Label();
            lblReleaseDate = new Label();
            lblStatus = new Label();
            txtName = new TextBox();
            txtAuthor = new TextBox();
            txtSynopsis = new TextBox();
            txtReleaseDate = new MaskedTextBox();
            cmbStatus = new ComboBox();
            btnClearFields = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Nome:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(24, 87);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(43, 17);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Autor:";
            // 
            // lblSynopsis
            // 
            lblSynopsis.AutoSize = true;
            lblSynopsis.Location = new Point(24, 154);
            lblSynopsis.Name = "lblSynopsis";
            lblSynopsis.Size = new Size(57, 17);
            lblSynopsis.TabIndex = 2;
            lblSynopsis.Text = "Sinopse:";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new Point(387, 27);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(131, 17);
            lblReleaseDate.TabIndex = 3;
            lblReleaseDate.Text = "Data de Lançamento:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(387, 87);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(51, 17);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Estado:";
            // 
            // txtName
            // 
            txtName.Location = new Point(24, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 25);
            txtName.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(24, 107);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(339, 25);
            txtAuthor.TabIndex = 6;
            // 
            // txtSynopsis
            // 
            txtSynopsis.Location = new Point(24, 174);
            txtSynopsis.Multiline = true;
            txtSynopsis.Name = "txtSynopsis";
            txtSynopsis.ScrollBars = ScrollBars.Vertical;
            txtSynopsis.Size = new Size(516, 109);
            txtSynopsis.TabIndex = 7;
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(387, 47);
            txtReleaseDate.Mask = "00/00/0000";
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.PromptChar = ' ';
            txtReleaseDate.Size = new Size(153, 25);
            txtReleaseDate.TabIndex = 8;
            txtReleaseDate.ValidatingType = typeof(DateTime);
            txtReleaseDate.Validated += TxtReleaseDate_Validated;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Enabled = false;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Disponível", "Reservado", "Retirado" });
            cmbStatus.Location = new Point(387, 107);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 25);
            cmbStatus.TabIndex = 9;
            // 
            // btnClearFields
            // 
            btnClearFields.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearFields.Image = Properties.Resources.erase;
            btnClearFields.Location = new Point(24, 289);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(148, 35);
            btnClearFields.TabIndex = 11;
            btnClearFields.Text = " Limpar Campos";
            btnClearFields.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += BtnClearFields_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(430, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 10;
            btnSave.Text = " Salvar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 342);
            Controls.Add(btnClearFields);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(txtReleaseDate);
            Controls.Add(txtSynopsis);
            Controls.Add(txtAuthor);
            Controls.Add(txtName);
            Controls.Add(lblStatus);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblSynopsis);
            Controls.Add(lblAuthor);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrando Livro";
            FormClosing += BookForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAuthor;
        private Label lblSynopsis;
        private Label lblReleaseDate;
        private Label lblStatus;
        private TextBox txtName;
        private TextBox txtAuthor;
        private TextBox txtSynopsis;
        private MaskedTextBox txtReleaseDate;
        private ComboBox cmbStatus;
        private Button btnClearFields;
        private Button btnSave;
    }
}