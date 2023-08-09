namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Exit = new Button();
            Login = new Button();
            Clear = new Button();
            txbPassword = new TextBox();
            txbUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.BackColor = Color.LightSkyBlue;
            Exit.Location = new Point(61, 545);
            Exit.Name = "Exit";
            Exit.Size = new Size(150, 46);
            Exit.TabIndex = 15;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.LightSkyBlue;
            Login.Location = new Point(776, 436);
            Login.Name = "Login";
            Login.Size = new Size(150, 46);
            Login.TabIndex = 14;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.LightSkyBlue;
            Clear.Location = new Point(306, 436);
            Clear.Name = "Clear";
            Clear.Size = new Size(150, 46);
            Clear.TabIndex = 13;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(159, 133);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(360, 39);
            txbPassword.TabIndex = 12;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(159, 38);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(360, 39);
            txbUserName.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Location = new Point(20, 133);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Location = new Point(20, 32);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 9;
            label2.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(546, 95);
            label1.Name = "label1";
            label1.Size = new Size(138, 51);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSkyBlue;
            groupBox1.Controls.Add(txbUserName);
            groupBox1.Controls.Add(txbPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(342, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 205);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(342, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 32);
            panel1.TabIndex = 17;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.OutlineButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1198, 668);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(Exit);
            Controls.Add(Clear);
            Controls.Add(Login);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button Login;
        private Button Clear;
        private TextBox txbPassword;
        private TextBox txbUserName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panel1;
    }
}