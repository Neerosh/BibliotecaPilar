using BibliotecaPilar.Data;
using BibliotecaPilar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserList : Form
    {
        private readonly DataContext dataContext = new DataContext();
        private readonly DataTable dataTableReserves = new DataTable();
        private Models.User currentUser;


        public UserList(Models.User currentUser)
        {
            InitializeComponent();

            dataTableReserves.Columns.Add("ID", typeof(int));
            dataTableReserves.Columns.Add("Livro", typeof(string));
            dataTableReserves.Columns.Add("Data Inicial", typeof(DateTime));
            dataTableReserves.Columns.Add("Data Final", typeof(DateTime));
            this.currentUser = currentUser;
            RefreshLists();
        }

        private void RefreshLists()
        {
            dataContext.Users.Load();
            userBindingSource.DataSource = dataContext.Users.Local.ToBindingList();
            FilterReserves();
        }

        private void FilterReserves()
        {
            dataTableReserves.Clear();

            if (dgvUsers.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                dgvReserves.DataSource = dataTableReserves;
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());

            var query = from reserve in dataContext.Set<Reserve>()
                        join book in dataContext.Set<Book>()
                            on reserve.BookId equals book.Id
                        where reserve.UserId == selectedUserId
                        select new { reserve.Id, reserve.ReserveStartDate, reserve.ReserveEndDate, book.Name };


            if (query.Any())
            {
                foreach (var item in query)
                {
                    dataTableReserves.Rows.Add(item.Id, item.Name, item.ReserveStartDate, item.ReserveEndDate);
                }

            }

            dgvReserves.DataSource = dataTableReserves;
            dgvReserves.Columns[0].Visible = false;
            dgvReserves.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReserves.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            foreach (DataGridViewColumn item in dgvReserves.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.Dispose();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione um usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
            var user = dataContext.Users.Local.FirstOrDefault(u => u.Id == selectedUserId);

            if (user == null)
            {
                MessageBox.Show("Erro ao carregar o usuário selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserForm userForm = new UserForm(user, currentUser);
            userForm.ShowDialog();
            RefreshLists();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(null, currentUser);
            userForm.ShowDialog();
            RefreshLists();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsers.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione um usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());

            if (selectedUserId == currentUser.Id)
            {
                MessageBox.Show("Usuário em uso, não é possivel excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = dataContext.Users.Local.FirstOrDefault(u => u.Id == selectedUserId);

            if (user == null)
            {
                MessageBox.Show("Erro ao carregar o usuário selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dataContext.Users.Remove(user);
                dataContext.SaveChanges();
                MessageBox.Show("Usuário excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o usuário:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            FilterReserves();

        }
    }
}
