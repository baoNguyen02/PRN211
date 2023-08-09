namespace Project
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            btnHistory = new Button();
            Exit = new Button();
            Refresh = new Button();
            btnAddComputer = new Button();
            dataGridView1 = new DataGridView();
            btnOrder = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnService = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(1028, 70);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(160, 52);
            btnHistory.TabIndex = 9;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(0, 71);
            Exit.Name = "Exit";
            Exit.Size = new Size(150, 46);
            Exit.TabIndex = 8;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(1225, 71);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(150, 46);
            Refresh.TabIndex = 7;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // btnAddComputer
            // 
            btnAddComputer.Location = new Point(1249, 70);
            btnAddComputer.Name = "btnAddComputer";
            btnAddComputer.Size = new Size(222, 52);
            btnAddComputer.TabIndex = 6;
            btnAddComputer.Text = "Add Computer";
            btnAddComputer.UseVisualStyleBackColor = true;
            btnAddComputer.Click += btnAddComputer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(98, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1375, 669);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(285, 76);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(150, 46);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(btnService);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnAddComputer);
            panel1.Location = new Point(2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1571, 152);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Location = new Point(1471, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(102, 828);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Location = new Point(2, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(96, 828);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(Refresh);
            panel4.Controls.Add(Exit);
            panel4.Location = new Point(98, 817);
            panel4.Name = "panel4";
            panel4.Size = new Size(1375, 158);
            panel4.TabIndex = 14;
            // 
            // btnService
            // 
            btnService.Location = new Point(96, 76);
            btnService.Name = "btnService";
            btnService.Size = new Size(150, 46);
            btnService.TabIndex = 11;
            btnService.Text = "Service";
            btnService.UseVisualStyleBackColor = true;
            btnService.Click += btnService_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 974);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHistory;
        private Button Exit;
        private Button Refresh;
        private Button btnAddComputer;
        private DataGridView dataGridView1;
        private Button btnOrder;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnService;
    }
}