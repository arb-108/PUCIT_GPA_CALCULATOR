namespace User_Control_Form_Practice
{
    partial class UserControl3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SemestercomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.crlabel3 = new System.Windows.Forms.Label();
            this.oblabel4 = new System.Windows.Forms.Label();
            this.no_of_subjects = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpa_text = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SemestercomboBox
            // 
            this.SemestercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemestercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemestercomboBox.FormattingEnabled = true;
            this.SemestercomboBox.Items.AddRange(new object[] {
            "--Select Semester--",
            "Semester No. 1",
            "Semester No. 2",
            "Semester No. 3",
            "Semester No. 4",
            "Semester No. 5",
            "Semester No. 6",
            "Semester No. 7",
            "Semester No. 8"});
            this.SemestercomboBox.Location = new System.Drawing.Point(50, 100);
            this.SemestercomboBox.Name = "SemestercomboBox";
            this.SemestercomboBox.Size = new System.Drawing.Size(201, 26);
            this.SemestercomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semester No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. of Subjects";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.Green;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(452, 101);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(109, 33);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Location = new System.Drawing.Point(251, 582);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(173, 54);
            this.reset_btn.TabIndex = 17;
            this.reset_btn.Text = "Clear";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.LimeGreen;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.ForeColor = System.Drawing.Color.White;
            this.calculate.Location = new System.Drawing.Point(438, 582);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(173, 54);
            this.calculate.TabIndex = 18;
            this.calculate.Text = "Next";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // crlabel3
            // 
            this.crlabel3.AutoSize = true;
            this.crlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crlabel3.Location = new System.Drawing.Point(366, 158);
            this.crlabel3.Name = "crlabel3";
            this.crlabel3.Size = new System.Drawing.Size(117, 20);
            this.crlabel3.TabIndex = 16;
            this.crlabel3.Text = "Credit Hours";
            // 
            // oblabel4
            // 
            this.oblabel4.AutoSize = true;
            this.oblabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oblabel4.Location = new System.Drawing.Point(137, 158);
            this.oblabel4.Name = "oblabel4";
            this.oblabel4.Size = new System.Drawing.Size(147, 20);
            this.oblabel4.TabIndex = 15;
            this.oblabel4.Text = "Marks Obtained ";
            // 
            // no_of_subjects
            // 
            this.no_of_subjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no_of_subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_subjects.Location = new System.Drawing.Point(279, 102);
            this.no_of_subjects.Name = "no_of_subjects";
            this.no_of_subjects.Size = new System.Drawing.Size(149, 27);
            this.no_of_subjects.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(705, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(412, 220);
            this.dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(917, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculate CGPA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gpa_text);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(773, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 285);
            this.groupBox1.TabIndex = 22;
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
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(705, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 54);
            this.button2.TabIndex = 23;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::User_Control_Form_Practice.Properties.Resources.left;
            this.button3.Location = new System.Drawing.Point(17, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 36);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fPanel1
            // 
            this.fPanel1.AutoScroll = true;
            this.fPanel1.Location = new System.Drawing.Point(56, 191);
            this.fPanel1.Name = "fPanel1";
            this.fPanel1.Size = new System.Drawing.Size(563, 349);
            this.fPanel1.TabIndex = 14;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.no_of_subjects);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.crlabel3);
            this.Controls.Add(this.oblabel4);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SemestercomboBox);
            this.Controls.Add(this.fPanel1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1157, 696);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SemestercomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label crlabel3;
        private System.Windows.Forms.Label oblabel4;
        private System.Windows.Forms.TextBox no_of_subjects;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gpa_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel fPanel1;
    }
}
