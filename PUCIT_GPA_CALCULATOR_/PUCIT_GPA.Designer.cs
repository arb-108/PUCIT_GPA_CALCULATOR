namespace User_Control_Form_Practice
{
    partial class PUCIT_GPA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUCIT_GPA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cgpa_calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpa_calc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl21 = new User_Control_Form_Practice.UserControl2();
            this.userControl11 = new User_Control_Form_Practice.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 32);
            this.panel1.TabIndex = 12;
            // 
            // cgpa_calc
            // 
            this.cgpa_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cgpa_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa_calc.Location = new System.Drawing.Point(600, 580);
            this.cgpa_calc.Name = "cgpa_calc";
            this.cgpa_calc.Size = new System.Drawing.Size(176, 51);
            this.cgpa_calc.TabIndex = 15;
            this.cgpa_calc.Text = "CGPA Calculator";
            this.cgpa_calc.UseVisualStyleBackColor = true;
            this.cgpa_calc.Click += new System.EventHandler(this.cgpa_calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Punjab University College Of Information Technology";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "( PUCIT )";
            // 
            // gpa_calc
            // 
            this.gpa_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpa_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa_calc.Location = new System.Drawing.Point(381, 580);
            this.gpa_calc.Name = "gpa_calc";
            this.gpa_calc.Size = new System.Drawing.Size(176, 51);
            this.gpa_calc.TabIndex = 15;
            this.gpa_calc.Text = "GPA Calculator";
            this.gpa_calc.UseVisualStyleBackColor = true;
            this.gpa_calc.Click += new System.EventHandler(this.gpa_calc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::User_Control_Form_Practice.Properties.Resources.Image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userControl21
            // 
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1157, 696);
            this.userControl21.TabIndex = 17;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1157, 696);
            this.userControl11.TabIndex = 16;
            // 
            // PUCIT_GPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1157, 696);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpa_calc);
            this.Controls.Add(this.cgpa_calc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PUCIT_GPA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUCIT CALC";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cgpa_calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gpa_calc;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
    }
}