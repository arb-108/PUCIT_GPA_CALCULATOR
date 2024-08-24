namespace User_Control_Form_Practice
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.no_of_sem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.crlabel3 = new System.Windows.Forms.Label();
            this.gpalabel4 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpa_text = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userControl31 = new User_Control_Form_Practice.UserControl3();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Number of Semesters";
            // 
            // no_of_sem
            // 
            this.no_of_sem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no_of_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_sem.Location = new System.Drawing.Point(236, 95);
            this.no_of_sem.Name = "no_of_sem";
            this.no_of_sem.Size = new System.Drawing.Size(260, 27);
            this.no_of_sem.TabIndex = 0;
            this.no_of_sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(236, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fPanel1
            // 
            this.fPanel1.AutoScroll = true;
            this.fPanel1.Location = new System.Drawing.Point(76, 224);
            this.fPanel1.Name = "fPanel1";
            this.fPanel1.Size = new System.Drawing.Size(640, 349);
            this.fPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "CGPA Calculator";
            // 
            // crlabel3
            // 
            this.crlabel3.AutoSize = true;
            this.crlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crlabel3.Location = new System.Drawing.Point(521, 191);
            this.crlabel3.Name = "crlabel3";
            this.crlabel3.Size = new System.Drawing.Size(117, 20);
            this.crlabel3.TabIndex = 12;
            this.crlabel3.Text = "Credit Hours";
            // 
            // gpalabel4
            // 
            this.gpalabel4.AutoSize = true;
            this.gpalabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpalabel4.Location = new System.Drawing.Point(308, 191);
            this.gpalabel4.Name = "gpalabel4";
            this.gpalabel4.Size = new System.Drawing.Size(47, 20);
            this.gpalabel4.TabIndex = 11;
            this.gpalabel4.Text = "GPA";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.LimeGreen;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.ForeColor = System.Drawing.Color.White;
            this.calculate.Location = new System.Drawing.Point(506, 615);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(173, 54);
            this.calculate.TabIndex = 13;
            this.calculate.Text = "Calculate CGPA";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Red;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Location = new System.Drawing.Point(319, 615);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(173, 54);
            this.reset_btn.TabIndex = 13;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gpa_text);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(785, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 285);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Your CGPA is :";
            // 
            // gpa_text
            // 
            this.gpa_text.AutoSize = true;
            this.gpa_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa_text.ForeColor = System.Drawing.Color.LimeGreen;
            this.gpa_text.Location = new System.Drawing.Point(76, 116);
            this.gpa_text.Name = "gpa_text";
            this.gpa_text.Size = new System.Drawing.Size(152, 91);
            this.gpa_text.TabIndex = 0;
            this.gpa_text.Text = "3.5";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::User_Control_Form_Practice.Properties.Resources.left;
            this.button2.Location = new System.Drawing.Point(13, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 36);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(58, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 486);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(71, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "If you don\'t know the GPA\'s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(302, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Click Here.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // userControl31
            // 
            this.userControl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl31.Location = new System.Drawing.Point(0, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1157, 696);
            this.userControl31.TabIndex = 19;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.crlabel3);
            this.Controls.Add(this.gpalabel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.no_of_sem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1157, 696);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox no_of_sem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel fPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label crlabel3;
        private System.Windows.Forms.Label gpalabel4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gpa_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private UserControl3 userControl31;
    }
}
