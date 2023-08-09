using Microsoft.VisualBasic.Devices;
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
    public partial class Ordering : Form
    {
        public Ordering()
        {
            InitializeComponent();
        }
        private QuanLyQuanNetContext context = new QuanLyQuanNetContext();
        private void Order_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {
            var result = (
                  from o in context.Orders
                  join c in context.Computers
                  on o.ComputerId equals c.Id
                  join f in context.FoodServices
                  on o.ServiceId equals f.Id
                  select new
                  {
                      o.Id,
                      ComputerName = c.ComputerName,
                      Service = f.ServiceName,
                      o.OrderDate,
                      o.Quantity

                  }).ToList();
            dataGridView1.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txbOrderId.Text);
            string computerName = txbComputer.Text;
            if (txbOrderId.Text != null)
            {
                if (cbxService.Text == "Open Computer")
                {
                    var computerToUpdate = context.Computers.FirstOrDefault(p => p.ComputerName == computerName);
                    computerToUpdate.Status = "inactive";
                    context.SaveChanges();
                }
                context.Orders.Remove(context.Orders.FirstOrDefault(p => p.Id == orderId));
                context.SaveChanges();
                txbOrderId.Text = null;
                txbComputer.Text = null;
                txbQuantity.Text = null;
                cbxService.Text = null;
                DialogResult res;
                res = MessageBox.Show("Delete Successful", "Exit", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    Load_Data();
                }
            }
            else
            {
                MessageBox.Show("Please choose 1 order!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txbOrderId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txbComputer.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbxService.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
    }
}
