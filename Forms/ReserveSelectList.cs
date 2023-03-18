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
    public partial class ReserveSelectList : Form
    {
        private readonly Book book;
        private readonly DataContext dataContext = new DataContext();
        private readonly DataTable dataTableReserves = new DataTable();

        public Reserve? reserveSelected;

        public ReserveSelectList(Book book)
        {
            InitializeComponent();
            this.book = book;
            dataTableReserves.Columns.Add("ID", typeof(int));
            dataTableReserves.Columns.Add("Usuário", typeof(string));
            dataTableReserves.Columns.Add("Data Inicial", typeof(DateTime));
            dataTableReserves.Columns.Add("Data Final", typeof(DateTime));
            FilterReserves();
        }

        private void FilterReserves()
        {
            dataTableReserves.Clear();

            var query = from reserve in dataContext.Set<Reserve>()
                        join user in dataContext.Set<User>()
                            on reserve.UserId equals user.Id
                        where reserve.BookId == book.Id && reserve.Status == "Criada"
                        select new { reserve.Id, user.Name, reserve.ReserveStartDate, reserve.ReserveEndDate };


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

        private void ReserveSelectList_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.Dispose();
        }

        private void BtnSelectReserve_Click(object sender, EventArgs e)
        {
            if (dgvReserves.GetCellCount(DataGridViewElementStates.Selected) <= 0)
            {
                MessageBox.Show("Selecione uma Reserva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedReserveId = Convert.ToInt32(dgvReserves.SelectedRows[0].Cells[0].Value.ToString());
            var reserve = dataContext.Reserves.Where(reserve => reserve.Id == selectedReserveId).FirstOrDefault();

            if (reserve != null)
            {
                reserveSelected = reserve;
            }
            this.Close();
        }
    }
}
