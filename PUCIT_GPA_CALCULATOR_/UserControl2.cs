using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Control_Form_Practice.Properties;

namespace User_Control_Form_Practice
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        int i = 1;
        double sumofMarks = 0;
        double sumofcrdits = 0;
        bool check_calc = false;

        private void generate_boxes()
        {
            TextBox count = new TextBox
            {
                Name = $"label{i}",
                Text = "Semester no "+i.ToString() + ".",
                BackColor = SystemColors.Control,
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                Size = new System.Drawing.Size(127, 30),
                Location = new System.Drawing.Point(1, 5 + (i * 39)),
                Margin = new Padding(0, 5, 0, 5),
                Font = new Font("poppins", 10, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                Tag = i
            };
            TextBox marks = new TextBox
            {
                Name = $"GPA_{i}",
                Size = new System.Drawing.Size(230, 33),
                Font = new Font("poppins", 10, FontStyle.Regular),
                Location = new System.Drawing.Point(37, 3 + (i * 39)),
                Margin = new Padding(10, 5, 4, 5),
                BorderStyle = BorderStyle.FixedSingle// Adjust positioning
                ,
                Tag = i

            };
            //marks.Text=marks.Name;
            TextBox credit = new TextBox
            {
                Name = $"credit{i}",
                Size = new System.Drawing.Size(230, 33),
                Font = new Font("poppins", 10, FontStyle.Regular),
                Margin = new Padding(15, 5, 3, 5),
                Location = new System.Drawing.Point(287, 3 + (i * 39)),
                BorderStyle = BorderStyle.FixedSingle// Adjust positioning
                ,
                Tag = i

            };
            Button removeButton = new Button
            {
                Name = $"btn{i}",
                Text = "",
                Size = new System.Drawing.Size(40, 33),
                Image = Resources.full_bin_32,

                FlatStyle = FlatStyle.Flat,
                // BackColor = System.Drawing.Color.Red,
                Margin = new Padding(11, 6, 1, 6),
                Location = new System.Drawing.Point(530, 3 + (i * 39)),
                Tag = i // Store index to identify which TextBox to remove
            };
            //removeButton.FlatAppearance.BorderSize = 0;
            //removeButton.Click += RemoveButton_Click;
            //credit.Text = credit.Name;

            i++;

            fPanel1.Controls.Add(count);
            fPanel1.Controls.Add(marks);
            fPanel1.Controls.Add(credit);
            //fPanel1.Controls.Add(removeButton);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            fPanel1.Controls.Clear();
            i = 1;
            if (isvalid())
            {
                crlabel3.Show();
                gpalabel4.Show();
                panel1.Hide();
                for(int j = 0; j < int.Parse(no_of_sem.Text); j++)
                { 
                generate_boxes();
                }
            }
        }

        private bool isvalid()
        {
            if (no_of_sem.Text == string.Empty)
            {
                MessageBox.Show("Number of Semester in Between 1-8 ", "Error", MessageBoxButtons.OK);
                no_of_sem.Clear();
                no_of_sem.Focus();

                return false;
            }
            else if (!(int.TryParse(no_of_sem.Text, out int scor)))
            {
                MessageBox.Show("Number of Semester in Between 1-8 ", "Error", MessageBoxButtons.OK);
                no_of_sem.Clear();
                no_of_sem.Focus();

                return false;
            }
            else if(int.Parse(no_of_sem.Text)>8 || int.Parse(no_of_sem.Text) < 1)
            {
                MessageBox.Show("Number of Semester in Between 1-8 ", "Error", MessageBoxButtons.OK);
                no_of_sem.Clear();
                no_of_sem.Focus();

                return false;
            }
            
            return true;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            gpalabel4.Hide();
            crlabel3.Hide();
            userControl31.Hide();
            no_of_sem.Focus();
            panel1.Show();
            groupBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            reset_fuctionality();
        }

        private void reset_fuctionality()
        {
            no_of_sem.Clear();
            check_calc=false;
            fPanel1.Controls.Clear();
            panel1.Show();
            groupBox1.Hide();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            crlabel3.Hide();
            gpalabel4.Hide();

            reset_fuctionality();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            calculate_cgpa();
            if (check_calc)
            {
                groupBox1.Show();
            }
            
        }
        private void calculate_cgpa()
        {

            //sum_marks_box();
            //sum_credit_box();
            //MessageBox.Show("marks :" + sumofMarks + " Credits" + sumofcrdits, "message", MessageBoxButtons.OK);
            double marksSum = 0;
            double creditSum = 0;
            double markscreditSum = 0;

            // Iterate through all controls in fPanel1
            foreach (Control control in fPanel1.Controls)
            {
                // Check if the control is a TextBox and its name starts with "marks"
                if (control is TextBox textBox)
                {

                    if (textBox.Name.StartsWith("GPA_"))
                    {
                        int index = (int)textBox.Tag;
                        // Try to parse the text as a number for marks
                        if (double.TryParse(textBox.Text, out double value) && double.Parse(textBox.Text) <= 4 && double.Parse(textBox.Text) >= 0)
                        {
                            marksSum += value;
                            foreach (Control controler in fPanel1.Controls)
                            {

                                if (controler is TextBox creditbox)
                                {
                                    if ((int)creditbox.Tag == index && creditbox.Name.StartsWith("credit"))
                                    {
                                        if (double.TryParse(creditbox.Text, out double score) && double.Parse(creditbox.Text) >= 0)
                                        {
                                            creditSum += score;
                                            markscreditSum += ((value) * score);
                                            // MessageBox.Show($"The sum of all 'marks' boxes is: {marksSum}\n" +
                                            //$"The sum of all 'credit' boxes is: {creditSum}\n" +
                                            // $"The sum of all 'total sum' boxes is: {markscreditSum}\n");
                                        }
                                        else
                                        {
                                            // Handle cases where the TextBox does not contain a valid number
                                            MessageBox.Show($"The value in '{creditbox.Name}' is not a valid number.\n" +
                                                $"Credit hours greater 0");
                                            creditbox.Clear();
                                            creditbox.Focus();
                                            return;

                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Handle cases where the TextBox does not contain a valid number
                            MessageBox.Show($"The value in '{textBox.Name}' is not a valid number.\n" +
                                $"GPA should be in between 0.5-4.");
                            textBox.Clear();
                            textBox.Focus();
                            return;
                        }
                    }

                }
            }

            decimal gpa = decimal.Round(Convert.ToDecimal(markscreditSum / creditSum), 2);
            gpa_text.Text = gpa.ToString("0.00");
            check_calc = true;
            // Show the result in a MessageBox or update a Label, TextBox, etc.
            MessageBox.Show($"The sum of all 'marks' boxes is: {marksSum}\n" +
                    $"The sum of all 'credit' boxes is: {creditSum}\n" +
                     $"The sum of all 'total sum' boxes is: {markscreditSum}\n" +
                      $"The sum of all 'gpa' boxes is: {gpa}");
        }

        

        

        private void label6_Click(object sender, EventArgs e)
        {
            userControl31.Show();
        }

        
    }
}
