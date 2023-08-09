using Microsoft.VisualBasic.Devices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Orders : Form
    {
        public Orders(string Cid)
        {
            this.Cid = Cid;
            InitializeComponent();
        }
        private string Cid;
        private QuanLyQuanNetContext context = new QuanLyQuanNetContext();

        private void Orders_Load(object sender, EventArgs e)
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
            DateTime dateTime = DateTime.Now;

            context.Orders.Add(new Order()
            { ComputerId = (int)Convert.ToInt32(Cid), ServiceId = (int)Convert.ToInt32(txbId.Text), OrderDate = dateTime, Quantity = (int)Convert.ToInt32(number.Value) });
            context.SaveChanges();
            DialogResult res;
            res = MessageBox.Show("Add Order MAY" + Cid + " Successful");
        }
    }
}
