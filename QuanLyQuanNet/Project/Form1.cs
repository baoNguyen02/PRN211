using Project.Models;
using System.Security.Cryptography;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            QuanLyQuanNetContext conn = new QuanLyQuanNetContext();
            string username = txbUserName.Text;
            string password = txbPassword.Text;
            if (conn.Accounts.Where(r => r.Username == username && r.Password == password).Count() > 0)
            {
                var result = (
                from acc in conn.Accounts
                where acc.Username == username && acc.Password == password
                select new
                {
                    AId = acc.Id,
                }).First();
                string AId = result.AId.ToString();
                new HomeForm(AId).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassword.Clear();

                txbUserName.Focus();
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txbUserName.Clear();
            txbPassword.Clear();

            txbUserName.Focus();
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
    }
}