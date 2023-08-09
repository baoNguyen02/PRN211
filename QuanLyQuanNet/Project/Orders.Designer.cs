namespace Project
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            dataGridView1 = new DataGridView();
            txbImage = new TextBox();
            label4 = new Label();
            txbName = new TextBox();
            txbId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txbPrice = new TextBox();
            label5 = new Label();
            number = new NumericUpDown();
            btnAdd = new Button();
            pbxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1060, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txbImage
            // 
            txbImage.Location = new Point(244, 678);
            txbImage.Name = "txbImage";
            txbImage.ReadOnly = true;
            txbImage.Size = new Size(259, 39);
            txbImage.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 681);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 19;
            label4.Text = "Image:";
            // 
            // txbName
            // 
            txbName.Location = new Point(244, 536);
            txbName.Name = "txbName";
            txbName.ReadOnly = true;
            txbName.Size = new Size(202, 39);
            txbName.TabIndex = 18;
            // 
            // txbId
            // 
            txbId.Location = new Point(244, 462);
            txbId.Name = "txbId";
            txbId.ReadOnly = true;
            txbId.Size = new Size(200, 39);
            txbId.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 611);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 16;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 539);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 15;
            label2.Text = "Service Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 472);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 14;
            label1.Text = "ID:";
            // 
            // txbPrice
            // 
            txbPrice.Location = new Point(244, 608);
            txbPrice.Name = "txbPrice";
            txbPrice.ReadOnly = true;
            txbPrice.Size = new Size(202, 39);
            txbPrice.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(886, 408);
            label5.Name = "label5";
            label5.Size = new Size(169, 32);
            label5.TabIndex = 22;
            label5.Text = "EnterNumber: ";
            // 
            // number
            // 
            number.Location = new Point(886, 462);
            number.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            number.Name = "number";
            number.Size = new Size(232, 39);
            number.TabIndex = 23;
            number.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(968, 667);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pbxImage
            // 
            pbxImage.Location = new Point(558, 462);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(249, 251);
            pbxImage.TabIndex = 25;
            pbxImage.TabStop = false;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1188, 770);
            Controls.Add(pbxImage);
            Controls.Add(btnAdd);
            Controls.Add(number);
            Controls.Add(label5);
            Controls.Add(txbPrice);
            Controls.Add(txbImage);
            Controls.Add(label4);
            Controls.Add(txbName);
            Controls.Add(txbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)number).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txbImage;
        private Label label4;
        private TextBox txbName;
        private TextBox txbId;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txbPrice;
        private Label label5;
        private NumericUpDown number;
        private Button btnAdd;
        private PictureBox pbxImage;
    }
}