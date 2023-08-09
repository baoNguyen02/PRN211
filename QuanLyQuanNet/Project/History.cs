using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        private QuanLyQuanNetContext context = new QuanLyQuanNetContext();
        private void History_Load(object sender, EventArgs e)
        {
            var result = (
                  from ph in context.PaymentHistories
                  join c in context.Computers
                  on ph.ComputerId equals c.Id
                  join f in context.FoodServices
                  on ph.ServiceId equals f.Id
                  select new
                  {
                      ph.PaymentDate,
                      c.ComputerName,
                      f.ServiceName,
                      ph.Quantity,
                      ph.TotalAmount

                  }).ToList();
            dataGridView1.DataSource = result;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSearch.Value.Date; // Lấy ngày tháng từ điều khiển dtpSearch (bỏ qua giờ, phút, giây)

            var result = (
                from ph in context.PaymentHistories
                join c in context.Computers on ph.ComputerId equals c.Id
                join f in context.FoodServices on ph.ServiceId equals f.Id
                where ph.PaymentDate.Year == selectedDate.Year
                   && ph.PaymentDate.Month == selectedDate.Month
                   && ph.PaymentDate.Day == selectedDate.Day
                select new
                {
                    PaymentDate = ph.PaymentDate,
                    c.ComputerName,
                    f.ServiceName,
                    ph.Quantity,
                    ph.TotalAmount
                }
            ).ToList();

            dataGridView1.DataSource = result;
        }
    }
}
