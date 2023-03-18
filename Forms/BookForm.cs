using BibliotecaPilar.Data;
using BibliotecaPilar.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class BookForm : Form
    {
        private Book book;
        private readonly string statusBeforeChange;
        private readonly DataContext dataContext = new DataContext();

        public BookForm(Book? book)
        {
            InitializeComponent();

            if (book != null)
            {
                this.book = book;
                txtName.Text = book.Name;
                txtAuthor.Text = book.Author;
                txtReleaseDate.Text = book.ReleaseDate.ToString("dd/MM/yyyy");
                txtSynopsis.Text = book.Synopsis;
                cmbStatus.SelectedItem = book.Status;
                statusBeforeChange = book.Status;
            }
            else
            {
                cmbStatus.SelectedItem = "Disponível";
                this.book = new Book();
            }

        }

        private void RegisterBook()
        {
            try
            {
                dataContext.Books.Add(book);
                dataContext.SaveChanges();
                MessageBox.Show("Livro cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o livro:\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBook()
        {
            try
            {

                dataContext.Books.Update(book);
                dataContext.SaveChanges();
                MessageBox.Show("Livro alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o livro:\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.Dispose();
        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtReleaseDate.Text = string.Empty;
            txtSynopsis.Text = string.Empty;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                return;
            }

            if (txtAuthor.Text == string.Empty)
            {
                txtAuthor.Focus();
                return;
            }

            if (txtReleaseDate.Text == string.Empty || txtReleaseDate.Text.Length < 10)
            {
                txtReleaseDate.Focus();
                return;
            }

            if (txtSynopsis.Text == string.Empty)
            {
                txtSynopsis.Focus();
                return;
            }

            book.Name = txtName.Text;
            book.Author = txtAuthor.Text;
            book.Synopsis = txtSynopsis.Text;
            book.ReleaseDate = DateTime.ParseExact(txtReleaseDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            book.Status = (String)cmbStatus.SelectedItem;

            if (book.Id == 0)
            {
                RegisterBook();
            }
            else
            {
                UpdateBook();
            }

            this.Close();
        }

        private void TxtReleaseDate_Validated(object sender, EventArgs e)
        {
            if (txtReleaseDate.Text == string.Empty) { return; }

            try
            {
                DateTime dateTime = DateTime.ParseExact(txtReleaseDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                txtReleaseDate.Text = "";
            }

        }
    }
}
