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
    public partial class AddComputer : Form
    {
        public AddComputer(string AId)
        {
            this.AId = AId;
            InitializeComponent();
        }
        private string AId;
        QuanLyQuanNetContext context = new QuanLyQuanNetContext();


        private int MaxComputerId()
        {
            int maxId = 0;
            if (context.Computers.Any())
            {
                maxId = context.Computers.Max(r => r.Id);
            }
            return maxId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int accountId = (int)Convert.ToInt32(AId);
            if (accountId == 1)
            {
                int num = (int)Convert.ToInt32(numberComputer.Value);
                for (int i = MaxComputerId() + 1; i <= num + MaxComputerId(); i++)
                {
                    context.Computers.Add(new Computer() { ComputerName = "May" + i });
                }
                context.SaveChanges();
                MessageBox.Show("Add successfully");
                this.Close();
            }
            else
            {
                DialogResult res;
                res = MessageBox.Show("You do not have permission to use this function.", "Exit", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
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
