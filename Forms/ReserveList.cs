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
    public partial class ReserveList : Form
    {
        private readonly DataContext dataContext = new DataContext();
        private readonly DataTable dataTableReserves = new DataTable();
        private User currentUser;

        public ReserveList(User currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;
            dataTableReserves.Columns.Add("ID", typeof(int));
            dataTableReserves.Columns.Add("Livro", typeof(string));
            dataTableReserves.Columns.Add("Estado", typeof(string));
            dataTableReserves.Columns.Add("Data Inicial", typeof(DateTime));
            dataTableReserves.Columns.Add("Data Final", typeof(DateTime));
            FilterReserves();
        }

        private void FilterReserves()
        {

            var query = from reserve in dataContext.Set<Reserve>()
                        join book in dataContext.Set<Book>()
                            on reserve.BookId equals book.Id
                        where reserve.UserId == currentUser.Id
                        select new { reserve.Id, reserve.ReserveStartDate, reserve.ReserveEndDate, reserve.Status, book.Name };

            if (query.Any())
            {
                foreach (var item in query)
                {
                    dataTableReserves.Rows.Add(item.Id, item.Name, item.Status, item.ReserveStartDate, item.ReserveEndDate);
                }
                dgvReserves.DataSource = dataTableReserves;

            }

            dgvReserves.DataSource = dataTableReserves;
            dgvReserves.Columns[0].Visible = false;
            dgvReserves.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReserves.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataGridViewColumn item in dgvReserves.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

    }
}
