namespace Project
{
    partial class AddComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComputer));
            Exit = new Button();
            btnAdd = new Button();
            label1 = new Label();
            numberComputer = new NumericUpDown();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numberComputer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(402, 296);
            Exit.Name = "Exit";
            Exit.Size = new Size(150, 46);
            Exit.TabIndex = 7;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(56, 296);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 64);
            label1.Name = "label1";
            label1.Size = new Size(432, 32);
            label1.TabIndex = 5;
            label1.Text = "Enter the number of computers to add:";
            // 
            // numberComputer
            // 
            numberComputer.Location = new Point(70, 152);
            numberComputer.Name = "numberComputer";
            numberComputer.Size = new Size(294, 39);
            numberComputer.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(numberComputer);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 425);
            panel1.TabIndex = 8;
            // 
            // AddComputer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 426);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddComputer";
            Text = "AddComputer";
            ((System.ComponentModel.ISupportInitialize)numberComputer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Exit;
        private Button btnAdd;
        private Label label1;
        private NumericUpDown numberComputer;
        private Panel panel1;
    }
}