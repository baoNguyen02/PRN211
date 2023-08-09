namespace Project
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbId = new TextBox();
            txbName = new TextBox();
            btnClear = new Button();
            label4 = new Label();
            txbImage = new TextBox();
            txbPrice = new NumericUpDown();
            label5 = new Label();
            pbxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txbPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1064, 328);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(979, 486);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(979, 560);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(979, 632);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 503);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 570);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 5;
            label2.Text = "Service Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 642);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 6;
            label3.Text = "Price:";
            // 
            // txbId
            // 
            txbId.Location = new Point(255, 493);
            txbId.Name = "txbId";
            txbId.ReadOnly = true;
            txbId.Size = new Size(200, 39);
            txbId.TabIndex = 7;
            // 
            // txbName
            // 
            txbName.Location = new Point(255, 567);
            txbName.Name = "txbName";
            txbName.Size = new Size(202, 39);
            txbName.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(979, 705);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 712);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 11;
            label4.Text = "Image:";
            // 
            // txbImage
            // 
            txbImage.Location = new Point(255, 709);
            txbImage.Name = "txbImage";
            txbImage.Size = new Size(292, 39);
            txbImage.TabIndex = 12;
            // 
            // txbPrice
            // 
            txbPrice.Location = new Point(255, 637);
            txbPrice.Name = "txbPrice";
            txbPrice.Size = new Size(292, 39);
            txbPrice.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 34);
            label5.Name = "label5";
            label5.Size = new Size(175, 51);
            label5.TabIndex = 14;
            label5.Text = "Service";
            // 
            // pbxImage
            // 
            pbxImage.Location = new Point(623, 493);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(302, 258);
            pbxImage.TabIndex = 15;
            pbxImage.TabStop = false;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1205, 791);
            Controls.Add(pbxImage);
            Controls.Add(label5);
            Controls.Add(txbPrice);
            Controls.Add(txbImage);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(txbName);
            Controls.Add(txbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Service";
            Text = "Service";
            Load += Service_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txbPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbId;
        private TextBox txbName;
        private Button btnClear;
        private Label label4;
        private TextBox txbImage;
        private NumericUpDown txbPrice;
        private Label label5;
        private PictureBox pbxImage;
    }
}