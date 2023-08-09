using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class HomeForm : Form
    {
        public HomeForm(string AId)
        {
            this.AId = AId;
            InitializeComponent();
        }
        private string AId;
        private QuanLyQuanNetContext conn = new QuanLyQuanNetContext();


        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            var result = conn.Computers.Select(p => new { p.Id, p.ComputerName, p.Status, p.Orders }).ToList();
            dataGridView1.DataSource = result;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra cột bạn muốn thay đổi màu chữ, ở đây là cột "status"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                // Lấy giá trị trong ô hiện tại
                var cellValue = e.Value?.ToString();

                // Kiểm tra điều kiện, nếu giá trị trong ô là "inactive" thì đặt màu chữ thành đỏ
                if (cellValue != null && cellValue == "inactive")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (cellValue != null && cellValue == "maintenance")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                }
                else
                {
                    // Nếu không thỏa điều kiện, đặt màu chữ thành mặc định (đen)
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }
        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            new AddComputer(AId).ShowDialog();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var status = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            var Cid = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && status != "active")
                {
                    new OpenComputer(Cid).ShowDialog();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Status"
                    && status == "active")
                {
                    new Pay(Cid, AId).ShowDialog();
                }else if (dataGridView1.Columns[e.ColumnIndex].Name == "ComputerName"
                    && status == "active")
                {
                    new Orders(Cid).ShowDialog();
                }
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Ordering order = new Ordering();
            order.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            new Service(AId).ShowDialog();
        }
    }
}
