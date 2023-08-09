namespace Project
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            lbTotalMoney = new Label();
            label2 = new Label();
            btnPay = new Button();
            btnExit = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txbTime = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.Font = new Font("Arial", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTotalMoney.Location = new Point(274, 578);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(0, 42);
            lbTotalMoney.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 578);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 16;
            label2.Text = "Total Money:";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(734, 681);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(150, 46);
            btnPay.TabIndex = 15;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(72, 681);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 444);
            label3.Name = "label3";
            label3.Size = new Size(171, 32);
            label3.TabIndex = 13;
            label3.Text = "Payment Time:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(812, 201);
            dataGridView1.TabIndex = 12;
            // 
            // txbTime
            // 
            txbTime.Location = new Point(274, 444);
            txbTime.Name = "txbTime";
            txbTime.ReadOnly = true;
            txbTime.Size = new Size(380, 39);
            txbTime.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(437, 26);
            label1.Name = "label1";
            label1.Size = new Size(69, 37);
            label1.TabIndex = 10;
            label1.Text = "Bill";
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(992, 784);
            Controls.Add(lbTotalMoney);
            Controls.Add(label2);
            Controls.Add(btnPay);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txbTime);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pay";
            Text = "Pay";
            Load += Pay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTotalMoney;
        private Label label2;
        private Button btnPay;
        private Button btnExit;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txbTime;
        private Label label1;
    }
}