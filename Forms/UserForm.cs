using BibliotecaPilar.Data;
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

namespace BibliotecaPilar.Forms
{
    public partial class UserForm : Form
    {
        private User user;
        readonly DataContext dataContext = new DataContext();

        public UserForm(User? user,User currentUser)
        {
            InitializeComponent();

            if (user != null)
            {
                this.Text = "Alterando Usuário";
                this.user = user;
                txtName.Text = this.user.Name;
                txtPassword.Text = this.user.Password;
                txtUsername.Text = this.user.Username;

                if (this.user.UserType == "Administrador")
                {
                    cmbUserType.SelectedIndex = 0;
                }
                else 
                {
                    cmbUserType.SelectedIndex = 1;
                }

                //Não permite ao usuário ativo alterar o próprio tipo
                if (currentUser.Id == user.Id)
                {
                    cmbUserType.Enabled = false;
                }
            }
            else
            {
                cmbUserType.SelectedIndex = 1;

                //Caso seja feito o cadastro sem realizar o login no sistema
                if (currentUser.Id == 0) 
                {
                    cmbUserType.Enabled = false;
                }
                this.user = new User();
            }
        }

        private void RegisterUser()
        {
            try
            {
                dataContext.Users.Add(user);
                dataContext.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuário:\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            try
            {
                dataContext.Users.Update(user);
                dataContext.SaveChanges();
                MessageBox.Show("Usuário alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o usuário:\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            user.ClearFields();
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            cmbUserType.SelectedIndex = 1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DataContext dataContext = new DataContext();


            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                return;
            }

            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Focus();
                return;
            }

            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Focus();
                return;
            }

            if (cmbUserType.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validação Alteração 
            if (user.Id > 0)
            {
                var usernameValidation = dataContext.Users.Where(u => u.Username == txtUsername.Text && u.Id != user.Id).FirstOrDefault();
                if (usernameValidation != null)
                {
                    MessageBox.Show("O usuário digitado já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                var usernameValidation = dataContext.Users.Where(u => u.Username == txtUsername.Text).FirstOrDefault();
                if (usernameValidation != null)
                {
                    MessageBox.Show("O usuário digitado já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Name = txtName.Text;
            user.UserType = (String) cmbUserType.SelectedItem;

            if (user.Id == 0)
            {
                RegisterUser();
            }
            else
            {
                UpdateUser();
            }
            this.Close();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.Dispose();
        }
    }
}
