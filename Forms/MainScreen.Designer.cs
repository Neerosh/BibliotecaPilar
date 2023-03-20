namespace BibliotecaPilar
{
    partial class MainScreen
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
            Menu = new MenuStrip();
            mniUsers = new ToolStripMenuItem();
            mniUserForm = new ToolStripMenuItem();
            mniUserList = new ToolStripMenuItem();
            mniBooks = new ToolStripMenuItem();
            mniBookForm = new ToolStripMenuItem();
            mniBookList = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            mniReserveForm = new ToolStripMenuItem();
            mniReserveList = new ToolStripMenuItem();
            mniExit = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            Menu.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Menu.Items.AddRange(new ToolStripItem[] { mniUsers, mniBooks, reservasToolStripMenuItem, mniExit });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(784, 24);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            // 
            // mniUsers
            // 
            mniUsers.DropDownItems.AddRange(new ToolStripItem[] { mniUserForm, mniUserList });
            mniUsers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mniUsers.Image = Properties.Resources.user;
            mniUsers.Name = "mniUsers";
            mniUsers.Size = new Size(80, 20);
            mniUsers.Text = "Usuários";
            // 
            // mniUserForm
            // 
            mniUserForm.Name = "mniUserForm";
            mniUserForm.Size = new Size(124, 22);
            mniUserForm.Text = "Cadastrar";
            mniUserForm.Click += MniUserForm_Click;
            // 
            // mniUserList
            // 
            mniUserList.Name = "mniUserList";
            mniUserList.Size = new Size(124, 22);
            mniUserList.Text = "Listar";
            mniUserList.Click += MniUserList_Click;
            // 
            // mniBooks
            // 
            mniBooks.DropDownItems.AddRange(new ToolStripItem[] { mniBookForm, mniBookList });
            mniBooks.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mniBooks.Image = Properties.Resources.book;
            mniBooks.Name = "mniBooks";
            mniBooks.Size = new Size(66, 20);
            mniBooks.Text = "Livros";
            // 
            // mniBookForm
            // 
            mniBookForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mniBookForm.Name = "mniBookForm";
            mniBookForm.Size = new Size(124, 22);
            mniBookForm.Text = "Cadastrar";
            mniBookForm.Click += MniBookForm_Click;
            // 
            // mniBookList
            // 
            mniBookList.Name = "mniBookList";
            mniBookList.Size = new Size(124, 22);
            mniBookList.Text = "Listar";
            mniBookList.Click += MniBookList_Click;
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniReserveForm, mniReserveList });
            reservasToolStripMenuItem.Image = Properties.Resources.reserve;
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(80, 20);
            reservasToolStripMenuItem.Text = "Reservas";
            // 
            // mniReserveForm
            // 
            mniReserveForm.Name = "mniReserveForm";
            mniReserveForm.Size = new Size(161, 22);
            mniReserveForm.Text = "Cadastrar";
            mniReserveForm.Click += MniReserveForm_Click;
            // 
            // mniReserveList
            // 
            mniReserveList.Name = "mniReserveList";
            mniReserveList.Size = new Size(161, 22);
            mniReserveList.Text = "Minhas Reservas";
            mniReserveList.Click += MniReserveList_Click;
            // 
            // mniExit
            // 
            mniExit.Alignment = ToolStripItemAlignment.Right;
            mniExit.Image = Properties.Resources.logout;
            mniExit.Name = "mniExit";
            mniExit.Size = new Size(54, 20);
            mniExit.Text = "Sair";
            mniExit.Click += MniExit_Click;
            // 
            // statusStrip
            // 
            statusStrip.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblUser });
            statusStrip.Location = new Point(0, 439);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(784, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 17);
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(statusStrip);
            Controls.Add(Menu);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = Menu;
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            FormClosing += MainScreen_FormClosing;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem mniUsers;
        private ToolStripMenuItem mniBooks;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblUser;
        private ToolStripMenuItem mniUserForm;
        private ToolStripMenuItem mniBookForm;
        private ToolStripMenuItem mniBookList;
        private ToolStripMenuItem mniUserList;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem mniReserveForm;
        private ToolStripMenuItem mniReserveList;
        private ToolStripMenuItem mniExit;
    }
}