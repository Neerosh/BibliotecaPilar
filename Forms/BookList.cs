using BibliotecaPilar.Data;
using BibliotecaPilar.Models;
using System.Data;
using System.Globalization;

namespace BibliotecaPilar.Forms
{
    public partial class BookList : Form
    {
        readonly DataContext dataContext = new DataContext();
        private readonly DataTable dataTableBooks = new DataTable();
        private User currentUser;

        public BookList(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            if (!currentUser.UserType.Equals("Administrador"))
            {
                btnRegisterBook.Visible = false;
                btnUpdateBook.Visible = false;
                btnDeleteBook.Visible = false;
                btnReturnBook.Visible = false;
                btnWithdrawnBook.Visible = false;
            }

            dataTableBooks.Columns.Add("ID", typeof(int));
            dataTableBooks.Columns.Add("Nome", typeof(string));
            dataTableBooks.Columns.Add("Autor", typeof(string));
            dataTableBooks.Columns.Add("Data de Lançamento", typeof(DateTime));
            dataTableBooks.Columns.Add("Estado", typeof(string));
            RefreshBooksList();
        }

        private void RefreshBooksList()
        {
            dataTableBooks.Clear();
            var queryBook = from book in dataContext.Set<Book>()
                            select book;

            if (queryBook.Any())
            {
                foreach (var item in queryBook)
                {
                    dataTableBooks.Rows.Add(item.Id, item.Name, item.Author, item.ReleaseDate, item.Status);
                }
            }

            dgvBooks.DataSource = dataTableBooks;
            dgvBooks.Columns[0].Visible = false;
            dgvBooks.Columns[3].ValueType = typeof(DateTime);
            dgvBooks.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            foreach (DataGridViewColumn item in dgvBooks.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvBooks.Refresh();
        }

        private void BookList_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.Dispose();
        }

        private void BtnRegisterBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(null);
            bookForm.ShowDialog();
            RefreshBooksList();
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione um livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
            var book = dataContext.Books.Local.FirstOrDefault(b => b.Id == selectedBookId);

            if (book == null)
            {
                MessageBox.Show("Erro ao carregar o livro selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookForm bookForm = new BookForm(book);
            bookForm.ShowDialog();
            RefreshBooksList();
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {

            if (dgvBooks.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione um livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
            var book = dataContext.Books.Local.FirstOrDefault(u => u.Id == selectedBookId);

            if (book == null)
            {
                MessageBox.Show("Erro ao carregar o livro selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dataContext.Books.Remove(book);
                dataContext.SaveChanges();
                MessageBox.Show("Livro excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o livro:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshBooksList();
        }

        private void btnWithdrawnBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione um livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
            var book = dataContext.Books.Local.FirstOrDefault(u => u.Id == selectedBookId);

            if (book == null)
            {
                MessageBox.Show("Erro ao carregar o livro selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (book.Status.Equals("Retirado"))
            {
                MessageBox.Show("Selecione um livro com o estado Reservado ou Disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Caso seja retirado o livro 

            ReserveSelectList reserveSelectList = new ReserveSelectList(book);
            reserveSelectList.ShowDialog();
            if (reserveSelectList.reserveSelected == null)
            {
                return;
            }

            var reserve = dataContext.Reserves
                .Where(reserve => reserve.Id == reserveSelectList.reserveSelected.Id && reserve.BookId == selectedBookId).FirstOrDefault();

            if (reserve == null)
            {
                MessageBox.Show("Erro ao atualizar a reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                book.Status = "Retirado";
                reserve.Status = "Livro Retirado";
                reserve.BookWithdrawnDate = DateTime.Now;
                dataContext.Reserves.Update(reserve);
                dataContext.Books.Update(book);
                dataContext.SaveChanges();
                MessageBox.Show("Livro retirado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retirar o livro:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshBooksList();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione um livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
            var book = dataContext.Books.Local.FirstOrDefault(u => u.Id == selectedBookId);

            if (book == null)
            {
                MessageBox.Show("Erro ao carregar o livro selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!book.Status.Equals("Retirado"))
            {
                MessageBox.Show("Selecione um livro com o estado Retirado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Caso seja devolvido o livro
            var reserve = dataContext.Reserves.Where(reserve => reserve.Status == "Livro Retirado" && reserve.BookId == selectedBookId).FirstOrDefault();
            if (reserve == null)
            {
                MessageBox.Show("Erro ao atualizar a reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                book.Status = "Disponível";
                reserve.Status = "Livro Devolvido";
                reserve.BookReturnedDate = DateTime.Now;
                int diferenceDays = (reserve.BookReturnedDate - reserve.BookWithdrawnDate).Days;
                reserve.ReserveTotal = 30;
                if (diferenceDays > 30)
                {
                    for (int i = 0; i < diferenceDays; i++)
                    {
                        reserve.ReserveTotal += (reserve.ReserveTotal * 0.01);
                    }
                }
                dataContext.Reserves.Update(reserve);
                dataContext.Books.Update(book);
                dataContext.SaveChanges();

                var brazilianCulture = new CultureInfo("pt-BR");
                double taxValue = reserve.ReserveTotal - 30;
                double totalValue = reserve.ReserveTotal;

                MessageBox.Show("Livro retirado com sucesso.\n" +
                    "Preço Fixo: R$ 30,00 \n" +
                    "Taxa de Atraso: R$ "+ taxValue.ToString(brazilianCulture) + "\n" +
                    "Total a Pagar: R$ "+ totalValue.ToString(brazilianCulture), "Devolução do Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retirar o livro:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshBooksList();
        }
    }
}
