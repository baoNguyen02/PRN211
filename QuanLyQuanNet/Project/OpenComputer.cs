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
    public partial class OpenComputer : Form
    {
        public OpenComputer(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        private string id;
        QuanLyQuanNetContext context = new QuanLyQuanNetContext();

        private void btnStatrt_Click(object sender, EventArgs e)
        {
            string status = comboBox1.Text;
            int computerId = (int)Convert.ToInt32(id);
            var computerStatus = context.Computers.Find(computerId);

            if (computerStatus != null && computerStatus.Status != "active")
            {
                if (status != "active")
                {
                    computerStatus.Status = status;
                    context.SaveChanges();
                    DialogResult res;
                    res = MessageBox.Show("Start Successful", "Exit", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    computerStatus.Status = status;
                    context.Orders.Add(new Order() { ComputerId = computerId, ServiceId = 1, OrderDate = dateTime, Quantity = 1 });
                    context.SaveChanges();
                    DialogResult res;
                    res = MessageBox.Show("Start Successful", "Exit", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }
            else
            {
                DialogResult res;
                res = MessageBox.Show("Error!", "Exit", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    this.Close();
                }
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

    }
}
