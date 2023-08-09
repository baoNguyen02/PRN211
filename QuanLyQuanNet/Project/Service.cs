using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Service : Form
    {
        public Service(string AId)
        {
            this.AId = AId;
            InitializeComponent();
        }
        private string AId;
        private QuanLyQuanNetContext context = new QuanLyQuanNetContext();

        private void Service_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {
            var result = (
                  from f in context.FoodServices
                  select new
                  {
                      f.Id,
                      f.ServiceName,
                      f.Price,
                      f.Image
                  }).ToList();
            dataGridView1.DataSource = result;
        }

        public void Load_Picture(string text)
        {
            string imageUrl = text;

            // Tạo một đối tượng WebClient để tải ảnh từ URL
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    // Tải ảnh từ URL và chuyển thành dữ liệu byte[]
                    byte[] data = webClient.DownloadData(imageUrl);

                    // Chuyển dữ liệu byte[] thành hình ảnh
                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        Image originalImage = Image.FromStream(stream);

                        // Cố định kích thước của ảnh thành 302x258
                        Image fixedSizeImage = new Bitmap(originalImage, new Size(302, 258));

                        // Hiển thị ảnh đã được cố định kích thước trong PictureBox
                        pbxImage.Image = fixedSizeImage;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi trong quá trình tải ảnh
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txbId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txbName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txbPrice.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            if (dataGridView1.Rows[i].Cells[3].Value != null)
            {
                txbImage.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                Load_Picture(txbImage.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int accountId = (int)Convert.ToInt32(AId);
            if (accountId == 1)
            {
                if (!string.IsNullOrEmpty(txbName.Text))
                {
                    context.FoodServices.Add(new FoodService()
                    { ServiceName = txbName.Text, Price = (int)Convert.ToInt32(txbPrice.Value), Image = txbImage.Text });
                    context.SaveChanges();
                    MessageBox.Show("Add successfully");
                    Load_Data();
                }
                else
                {
                    MessageBox.Show("Please enter name!");
                }

            }
            else
            {
                DialogResult res;
                res = MessageBox.Show("You do not have permission to use this function.", "Exit", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int accountId = (int)Convert.ToInt32(AId);
            if (accountId == 1)
            {
                if (txbId.Text != "1" && !string.IsNullOrEmpty(txbId.Text))
                {
                    var ServiceToUpdate = context.FoodServices.FirstOrDefault(p => p.Id == (int)Convert.ToInt32(txbId.Text));
                    ServiceToUpdate.ServiceName = txbName.Text;
                    ServiceToUpdate.Price = (int)Convert.ToInt32(txbPrice.Value);
                    ServiceToUpdate.Image = txbImage.Text;
                    context.SaveChanges();
                    DialogResult res;
                    res = MessageBox.Show("Update Successful", "Exit", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        Load_Data();
                    }
                }
                else if (txbId.Text == "1" && !string.IsNullOrEmpty(txbId.Text))
                {
                    var ServiceToUpdate = context.FoodServices.FirstOrDefault(p => p.Id == (int)Convert.ToInt32(txbId.Text));
                    ServiceToUpdate.Price = (int)Convert.ToInt32(txbPrice.Value);
                    ServiceToUpdate.Image = txbImage.Text;
                    context.SaveChanges();
                    DialogResult res;
                    res = MessageBox.Show("Update Successful", "Exit", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        Load_Data();
                    }
                }
            }
            else
            {
                DialogResult res;
                res = MessageBox.Show("You do not have permission to use this function.", "Exit", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int accountId = (int)Convert.ToInt32(AId);
            int ServiceId = (int)Convert.ToInt32(txbId.Text);
            if (accountId == 1)
            {
                if (txbId.Text != "1")
                {
                    context.FoodServices.Remove(context.FoodServices.FirstOrDefault(p => p.Id == ServiceId));
                    context.SaveChanges();
                    txbName.Text = string.Empty;
                    txbId.Text = string.Empty;
                    txbPrice.Text = string.Empty;
                    txbImage.Text = string.Empty;
                    DialogResult res;
                    res = MessageBox.Show("Delete Successful", "Exit", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        Load_Data();
                    }
                }
                else
                {
                    MessageBox.Show("You don't delete this service!");
                }
            }
            else
            {
                DialogResult res;
                res = MessageBox.Show("You do not have permission to use this function.", "Exit", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Text = string.Empty;
            txbId.Text = string.Empty;
            txbPrice.Text = string.Empty;
            txbImage.Text = string.Empty;
            Load_Data();
        }

    }
}
