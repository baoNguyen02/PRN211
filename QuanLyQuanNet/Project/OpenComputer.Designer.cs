namespace Project
{
    partial class OpenComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenComputer));
            btnExit = new Button();
            btnStatrt = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(388, 321);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStatrt
            // 
            btnStatrt.Location = new Point(112, 321);
            btnStatrt.Name = "btnStatrt";
            btnStatrt.Size = new Size(150, 46);
            btnStatrt.TabIndex = 6;
            btnStatrt.Text = "Start";
            btnStatrt.UseVisualStyleBackColor = true;
            btnStatrt.Click += btnStatrt_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "active", "maintenance" });
            comboBox1.Location = new Point(112, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 40);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "active";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 101);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 4;
            label1.Text = "OpenComputer";
            // 
            // OpenComputer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(606, 472);
            Controls.Add(btnExit);
            Controls.Add(btnStatrt);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OpenComputer";
            Text = "OpenComputer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnStatrt;
        private ComboBox comboBox1;
        private Label label1;
    }
}