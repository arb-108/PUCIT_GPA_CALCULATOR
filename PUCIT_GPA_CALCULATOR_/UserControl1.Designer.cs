namespace User_Control_Form_Practice
{
    partial class UserControl1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reset = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpa_text = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_subject_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Credit Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Obtained Marks";
            // 
            // fPanel1
            // 
            this.fPanel1.AutoScroll = true;
            this.fPanel1.Location = new System.Drawing.Point(68, 113);
            this.fPanel1.Name = "fPanel1";
            this.fPanel1.Size = new System.Drawing.Size(625, 448);
            this.fPanel1.TabIndex = 7;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Red;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(160, 605);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(182, 52);
            this.reset.TabIndex = 10;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Lime;
            this.calculate.FlatAppearance.BorderSize = 0;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(355, 605);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(182, 52);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(789, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 696);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gpa_text);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(824, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 285);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "Your GPA is :";
            // 
            // gpa_text
            // 
            this.gpa_text.AutoSize = true;
            this.gpa_text.Font = new System.Drawing.Font("Poppins", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa_text.ForeColor = System.Drawing.Color.LimeGreen;
            this.gpa_text.Location = new System.Drawing.Point(76, 116);
            this.gpa_text.Name = "gpa_text";
            this.gpa_text.Size = new System.Drawing.Size(178, 141);
            this.gpa_text.TabIndex = 0;
            this.gpa_text.Text = "3.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "( Out of 100 )";
            // 
            // add_subject_btn
            // 
            this.add_subject_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_subject_btn.FlatAppearance.BorderSize = 0;
            this.add_subject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_subject_btn.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_subject_btn.Image = global::User_Control_Form_Practice.Properties.Resources.plus__1_;
            this.add_subject_btn.Location = new System.Drawing.Point(623, 63);
            this.add_subject_btn.Name = "add_subject_btn";
            this.add_subject_btn.Size = new System.Drawing.Size(55, 44);
            this.add_subject_btn.TabIndex = 11;
            this.add_subject_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_subject_btn.UseVisualStyleBackColor = false;
            this.add_subject_btn.Click += new System.EventHandler(this.add_subject_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::User_Control_Form_Practice.Properties.Resources.left;
            this.button1.Location = new System.Drawing.Point(19, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_subject_btn);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1157, 696);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel fPanel1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button add_subject_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gpa_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
