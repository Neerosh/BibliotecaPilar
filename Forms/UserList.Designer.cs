namespace BibliotecaPilar.Forms
{
    partial class UserList
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
            dgvUsers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            btnUpdateUser = new Button();
            btnIncluir = new Button();
            btnExcluir = new Button();
            dgvReserves = new DataGridView();
            reserveBindingSource = new BindingSource(components);
            grpReserves = new GroupBox();
            grpUsers = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReserves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reserveBindingSource).BeginInit();
            grpReserves.SuspendLayout();
            grpUsers.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { ID, nameDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, userTypeDataGridViewTextBoxColumn });
            dgvUsers.DataSource = userBindingSource;
            dgvUsers.Location = new Point(12, 24);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(636, 188);
            dgvUsers.TabIndex = 0;
            dgvUsers.SelectionChanged += DgvUsers_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Usuário";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            userTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            userTypeDataGridViewTextBoxColumn.HeaderText = "Tipo Usuário";
            userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUser.Location = new Point(438, 218);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(102, 27);
            btnUpdateUser.TabIndex = 1;
            btnUpdateUser.Text = "Alterar";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += BtnUpdateUser_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIncluir.Location = new Point(330, 218);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(102, 27);
            btnIncluir.TabIndex = 2;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += BtnIncluir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(546, 218);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(102, 27);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // dgvReserves
            // 
            dgvReserves.AllowUserToAddRows = false;
            dgvReserves.AllowUserToDeleteRows = false;
            dgvReserves.BorderStyle = BorderStyle.None;
            dgvReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserves.Location = new Point(12, 24);
            dgvReserves.MultiSelect = false;
            dgvReserves.Name = "dgvReserves";
            dgvReserves.RowHeadersVisible = false;
            dgvReserves.RowTemplate.Height = 25;
            dgvReserves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReserves.Size = new Size(636, 150);
            dgvReserves.TabIndex = 4;
            // 
            // reserveBindingSource
            // 
            reserveBindingSource.DataSource = typeof(Models.Reserve);
            // 
            // grpReserves
            // 
            grpReserves.Controls.Add(dgvReserves);
            grpReserves.Location = new Point(12, 269);
            grpReserves.Name = "grpReserves";
            grpReserves.Size = new Size(660, 180);
            grpReserves.TabIndex = 5;
            grpReserves.TabStop = false;
            grpReserves.Text = "Reservas (Usuário Selecionado)";
            // 
            // grpUsers
            // 
            grpUsers.Controls.Add(dgvUsers);
            grpUsers.Controls.Add(btnExcluir);
            grpUsers.Controls.Add(btnUpdateUser);
            grpUsers.Controls.Add(btnIncluir);
            grpUsers.Location = new Point(12, 12);
            grpUsers.Name = "grpUsers";
            grpUsers.Size = new Size(660, 251);
            grpUsers.TabIndex = 6;
            grpUsers.TabStop = false;
            grpUsers.Text = "Usuários";
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(grpUsers);
            Controls.Add(grpReserves);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de Usuários";
            FormClosing += UserList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReserves).EndInit();
            ((System.ComponentModel.ISupportInitialize)reserveBindingSource).EndInit();
            grpReserves.ResumeLayout(false);
            grpUsers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private BindingSource userBindingSource;
        private Button btnUpdateUser;
        private Button btnIncluir;
        private Button btnExcluir;
        private DataGridView dgvReserves;
        private BindingSource reserveBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private GroupBox grpReserves;
        private GroupBox grpUsers;
    }
}