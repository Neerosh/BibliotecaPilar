namespace BibliotecaPilar.Forms
{
    partial class UserForm
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
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbUserType = new ComboBox();
            btnSave = new Button();
            btnClearFields = new Button();
            lblUserType = new Label();
            lblUsuario = new Label();
            lblNome = new Label();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(22, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 25);
            txtName.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(22, 93);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(204, 25);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(244, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(186, 25);
            txtPassword.TabIndex = 2;
            // 
            // cmbUserType
            // 
            cmbUserType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Administrador", "Usuário" });
            cmbUserType.Location = new Point(244, 33);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(186, 25);
            cmbUserType.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(308, 143);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = " Salvar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearFields.Image = Properties.Resources.trash;
            btnClearFields.Location = new Point(22, 143);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(148, 35);
            btnClearFields.TabIndex = 5;
            btnClearFields.Text = "Limpar Campos";
            btnClearFields.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += BtnClearFields_Click;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserType.Location = new Point(244, 10);
            lblUserType.Margin = new Padding(0, 0, 3, 0);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(105, 17);
            lblUserType.TabIndex = 6;
            lblUserType.Text = "Tipo de Usuário:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(22, 70);
            lblUsuario.Margin = new Padding(0, 0, 3, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 17);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuário:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(22, 10);
            lblNome.Margin = new Padding(0, 0, 3, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 17);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.Location = new Point(244, 70);
            lblSenha.Margin = new Padding(0, 0, 3, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 17);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha:";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 198);
            Controls.Add(lblSenha);
            Controls.Add(lblNome);
            Controls.Add(lblUsuario);
            Controls.Add(lblUserType);
            Controls.Add(btnClearFields);
            Controls.Add(btnSave);
            Controls.Add(cmbUserType);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrando Usuário";
            FormClosing += UserForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbUserType;
        private Button btnSave;
        private Button btnClearFields;
        private Label lblUserType;
        private Label lblUsuario;
        private Label lblNome;
        private Label lblSenha;
    }
}