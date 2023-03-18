using Azure.Identity;
using BibliotecaPilar.Forms;
using BibliotecaPilar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPilar
{
    public partial class MainScreen : Form
    {
        private readonly User currentUser;

        public MainScreen(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            CheckUserType();

        }

        private void CheckUserType()
        {
            lblUser.Text = "Logado como: " + currentUser.Name;
            if (!currentUser.UserType.Equals("Administrador"))
            {
                mniBookForm.Visible = false;
                mniUsers.Visible = false;
            }
        }


        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmation = MessageBox.Show("Deseja mesmo fechar ? ",
                             "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void MniUserForm_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(null, currentUser);
            userForm.ShowDialog();
        }

        private void MniUserList_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList(currentUser);
            userList.ShowDialog();
        }

        private void MniBookForm_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(null);
            bookForm.ShowDialog();
        }

        private void MniBookList_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList(currentUser);
            bookList.ShowDialog();
        }

        private void MniReserveForm_Click(object sender, EventArgs e)
        {
            ReserveForm reserveForm = new ReserveForm(currentUser);
            reserveForm.ShowDialog();
        }

        private void MniReserveList_Click(object sender, EventArgs e)
        {
            ReserveList reserveList = new ReserveList(currentUser);
            reserveList.ShowDialog();
        }
    }
}
