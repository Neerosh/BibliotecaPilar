using BibliotecaPilar.Data;
using BibliotecaPilar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPilar.Forms
{
    public partial class ReserveForm : Form
    {
        private readonly DataContext dataContext = new DataContext();
        private readonly DataTable dataTableReserves = new DataTable();
        private Reserve reserve = new Reserve();
        private User currentUser;

        public ReserveForm(User currentUser)
        {
            InitializeComponent();
            dataContext.Books.Load();
            bookBindingSource.DataSource = dataContext.Books.Local.ToBindingList();

            dataTableReserves.Columns.Add("ID", typeof(int));
            dataTableReserves.Columns.Add("Usuário", typeof(string));
            dataTableReserves.Columns.Add("Data Inicial", typeof(DateTime));
            dataTableReserves.Columns.Add("Data Final", typeof(DateTime));
            cmbBookStatus.SelectedIndex = 0;
            this.currentUser = currentUser;
            FilterReserves();
        }


        private void FilterReserves()
        {
            dataTableReserves.Clear();

            if (dgvBooks.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                dgvReserves.DataSource = dataTableReserves;
                return;
            }

            int selectedookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());

            var query = from reserve in dataContext.Set<Reserve>()
                        join user in dataContext.Set<User>()
                            on reserve.UserId equals user.Id
                        where reserve.BookId == selectedookId
                        select new { reserve.Id, reserve.ReserveStartDate, reserve.ReserveEndDate, user.Name };


            if (query.Any())
            {
                foreach (var item in query)
                {
                    dataTableReserves.Rows.Add(item.Id, item.Name, item.ReserveStartDate, item.ReserveEndDate);
                }
                dgvReserves.DataSource = dataTableReserves;

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


        private void ReserveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtReserveStartDate.Text.Length < 10)
            {
                txtReserveStartDate.Focus();
            }

            if (txtReserveEndDate.Text.Length < 10)
            {
                txtReserveEndDate.Focus();
            }

            if (dgvBooks.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione um livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());

            try
            {
                DateTime startDate = DateTime.ParseExact(txtReserveStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime endDate = DateTime.ParseExact(txtReserveEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                var validationDates = dataContext.Reserves
                    .Where(reserves => reserves.BookId == selectedBookId &&
                    (startDate >= reserves.ReserveStartDate && startDate <= reserves.ReserveEndDate) ||
                    (endDate >= reserves.ReserveStartDate && endDate <= reserves.ReserveEndDate));

                if (validationDates.Any())
                {
                    MessageBox.Show("O livro não está disponível para o período digitado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Atualiza estado do Livro (Caso disponível)
                var selectedBook = dataContext.Books.Where(book => book.Id == selectedBookId && book.Status == "Disponível").FirstOrDefault();

                if (selectedBook != null)
                {
                    selectedBook.Status = "Reservado";
                    dataContext.Books.Update(selectedBook);
                }

                //Cria Reserva
                reserve.UserId = currentUser.Id;
                reserve.BookId = selectedBookId;
                reserve.Status = "Criada";
                reserve.ReserveStartDate = DateTime.ParseExact(txtReserveStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                reserve.ReserveEndDate = DateTime.ParseExact(txtReserveEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dataContext.Reserves.Add(reserve);
                dataContext.SaveChanges();
                MessageBox.Show("Reserva criada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a reserva:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtReserveStartDate_Validated(object sender, EventArgs e)
        {
            if (txtReserveStartDate.Text == string.Empty) { return; }
            try
            {
                DateTime dataInicial = DateTime.ParseExact(txtReserveStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dataFinal = dataInicial.AddDays(30);
                txtReserveEndDate.Text = dataFinal.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                txtReserveStartDate.Text = "";
                txtReserveEndDate.Text = "";
            }
        }

        private void TxtReserveEndDate_Validated(object sender, EventArgs e)
        {
            if (txtReserveEndDate.Text == string.Empty) { return; }
            try
            {
                DateTime.ParseExact(txtReserveEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                txtReserveEndDate.Text = "";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string bookStatusFilter = cmbBookStatus.SelectedItem.ToString();

            if (txtBookAuthor.Text.IsNullOrEmpty() && bookStatusFilter == "Todos")
            {
                bookBindingSource.DataSource = dataContext.Books.Local.ToBindingList();
            }
            else
            {

                var filteredBooks = dataContext.Books.Local.ToBindingList()
                    .Where(b => b.Author.Contains(txtBookAuthor.Text) && (bookStatusFilter == "Todos" || b.Status == bookStatusFilter));

                bookBindingSource.DataSource = null;

                if (filteredBooks.Any())
                {
                    bookBindingSource.DataSource = filteredBooks;
                }

            }
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            FilterReserves();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            txtBookAuthor.Text = string.Empty;
            cmbBookStatus.SelectedItem = "Todos";
            BtnSearch_Click(sender, e);
        }
    }
}
