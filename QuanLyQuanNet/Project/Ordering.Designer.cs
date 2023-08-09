namespace Project
{
    partial class Ordering
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordering));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            foodServiceBindingSource = new BindingSource(components);
            txbComputer = new TextBox();
            txbQuantity = new TextBox();
            foodServiceBindingSource1 = new BindingSource(components);
            foodServiceBindingSource2 = new BindingSource(components);
            cbxService = new ComboBox();
            foodServiceBindingSource3 = new BindingSource(components);
            label4 = new Label();
            txbOrderId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(960, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 37);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 1;
            label1.Text = "Wait For Pay";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(865, 486);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(865, 576);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(865, 674);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 556);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 5;
            label2.Text = "Computer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 623);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 6;
            label3.Text = "Service:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 688);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 8;
            label5.Text = "Quantity:";
            // 
            // foodServiceBindingSource
            // 
            foodServiceBindingSource.DataSource = typeof(Models.FoodService);
            // 
            // txbComputer
            // 
            txbComputer.Location = new Point(247, 553);
            txbComputer.Name = "txbComputer";
            txbComputer.ReadOnly = true;
            txbComputer.Size = new Size(200, 39);
            txbComputer.TabIndex = 10;
            // 
            // txbQuantity
            // 
            txbQuantity.Location = new Point(247, 688);
            txbQuantity.Name = "txbQuantity";
            txbQuantity.Size = new Size(200, 39);
            txbQuantity.TabIndex = 11;
            // 
            // foodServiceBindingSource1
            // 
            foodServiceBindingSource1.DataSource = typeof(Models.FoodService);
            // 
            // foodServiceBindingSource2
            // 
            foodServiceBindingSource2.DataSource = typeof(Models.FoodService);
            // 
            // cbxService
            // 
            cbxService.FormattingEnabled = true;
            cbxService.Location = new Point(247, 620);
            cbxService.Name = "cbxService";
            cbxService.Size = new Size(242, 40);
            cbxService.TabIndex = 12;
            // 
            // foodServiceBindingSource3
            // 
            foodServiceBindingSource3.DataSource = typeof(Models.FoodService);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 486);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 13;
            label4.Text = "OrderId:";
            // 
            // txbOrderId
            // 
            txbOrderId.Location = new Point(247, 483);
            txbOrderId.Name = "txbOrderId";
            txbOrderId.ReadOnly = true;
            txbOrderId.Size = new Size(200, 39);
            txbOrderId.TabIndex = 14;
            // 
            // Ordering
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1082, 763);
            Controls.Add(txbOrderId);
            Controls.Add(label4);
            Controls.Add(cbxService);
            Controls.Add(txbQuantity);
            Controls.Add(txbComputer);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ordering";
            Text = "Order";
            Load += Order_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodServiceBindingSource3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txbComputer;
        private TextBox txbQuantity;
        private BindingSource foodServiceBindingSource;
        private BindingSource foodServiceBindingSource1;
        private BindingSource foodServiceBindingSource2;
        private ComboBox cbxService;
        private BindingSource foodServiceBindingSource3;
        private Label label4;
        private TextBox txbOrderId;
    }
}