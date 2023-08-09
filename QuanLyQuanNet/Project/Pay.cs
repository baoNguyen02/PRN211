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
    public partial class Pay : Form
    {
        public Pay(string id, string AId)
        {
            this.id = id;
            this.AId = AId;
            InitializeComponent();
        }
        private string id;
        private string AId;
        private QuanLyQuanNetContext context = new QuanLyQuanNetContext();

        private void Pay_Load(object sender, EventArgs e)
        {
            int Cid = (int)Convert.ToInt32(id);

            var result = (
                  from o in context.Orders
                  join f in context.FoodServices
                  on o.ServiceId equals f.Id
                  join c in context.Computers
                  on o.ComputerId equals c.Id
                  where c.Id == Cid
                  select new
                  {
                      ComputerName = c.ComputerName,
                      Service = f.ServiceName,
                      o.OrderDate,
                      o.Quantity,
                      f.Price
                  }).ToList();

            dataGridView1.DataSource = result;
            DateTime date = DateTime.Now;
            decimal totalPrice = 0;
            foreach (var o in result)
            {
                if (o.Service == "Open Computer")
                {
                    DateTime timeOrder = o.OrderDate;
                    totalPrice += countHours(timeOrder) * o.Price;
                }
                else
                {
                    totalPrice += o.Quantity * o.Price;
                }
            }

            txbTime.Text = date.ToString();
            lbTotalMoney.Text = totalPrice.ToString("0.00") + " $";


        }

        public decimal countHours(DateTime timeOrder)
        {
            TimeSpan timeSpan = DateTime.Now - timeOrder;
            decimal countTime = (decimal)Math.Abs(timeSpan.TotalHours);
            return countTime;
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            int Cid = (int)Convert.ToInt32(id);
            int accountId = (int)Convert.ToInt32(AId);
            var result = (
                  from o in context.Orders
                  join f in context.FoodServices
                  on o.ServiceId equals f.Id
                  join c in context.Computers
                  on o.ComputerId equals c.Id
                  where c.Id == Cid
                  select new
                  {
                      ComputerId = c.Id,
                      OrderId = o.Id,
                      ServiceId = f.Id,
                      o.OrderDate,
                      o.Quantity,
                      f.Price
                  }).ToList();

            DateTime date = DateTime.Now;
            decimal totalPrice = 0;
            int OrderId = 0;
            int ComputerId = 0;
            foreach (var o in result)
            {
                OrderId = o.OrderId;
                ComputerId = o.ComputerId;
                if (o.ServiceId == 1)
                {
                    DateTime timeOrder = o.OrderDate;
                    totalPrice = (decimal)countHours(timeOrder) * o.Price;
                    context.PaymentHistories.Add(new PaymentHistory()
                    { PaymentDate = date, AccountId = accountId, ComputerId = o.ComputerId, ServiceId = o.ServiceId, Quantity = o.Quantity, TotalAmount = totalPrice });
                }
                else
                {
                    totalPrice = o.Quantity * o.Price;
                    context.PaymentHistories.Add(new PaymentHistory()
                    { PaymentDate = date, AccountId = accountId, ComputerId = o.ComputerId, ServiceId = o.ServiceId, Quantity = o.Quantity, TotalAmount = totalPrice });
                }
            }
            context.SaveChanges();

            context.Orders.Remove(context.Orders.FirstOrDefault(p => p.Id == OrderId));
            context.SaveChanges();
            context.Computers.Find(ComputerId).Status = "inactive";
            context.SaveChanges();

            DialogResult res;
            res = MessageBox.Show("Pay Successful", "Exit", MessageBoxButtons.OK);
            if (res == DialogResult.OK)
            {
                this.Close();
            }

        }

    }
}
