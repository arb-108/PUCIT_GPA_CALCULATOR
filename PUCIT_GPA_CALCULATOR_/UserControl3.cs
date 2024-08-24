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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace User_Control_Form_Practice
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        int i = 1;
        double sumofMarks = 0;
        double sumofcrdits = 0;
        bool check_calc = false;
        bool checking=true;
        bool next_op=false;
        List<gpa_store> gpa_cart=new List<gpa_store>();
        private void UserControl3_Load(object sender, EventArgs e)
        {
            oblabel4.Hide();
            crlabel3.Hide();
            SemestercomboBox.SelectedIndex = 0;
            groupBox1.Hide();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            fPanel1.Controls.Clear();
            if (isvalid())
            {
                oblabel4.Show();
                crlabel3.Show();
                i = 1;
                for(int j= 0; j < int.Parse(no_of_subjects.Text); j++)
                {
                    generate_boxes();
                }
                next_op = true;
            }
        }
        private void generate_boxes()
        {
            TextBox count = new TextBox
            {
                Name = $"label{i}",
                Text =  i.ToString() + ".",
                BackColor = SystemColors.Control,
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                Size = new System.Drawing.Size(50, 30),
                Location = new System.Drawing.Point(1, 5 + (i * 39)),
                Margin = new Padding(0, 5, 0, 5),
                Font = new Font("poppins", 10, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                Tag = i
            };
            TextBox marks = new TextBox
            {
                Name = $"marks{i}",
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
            //Button removeButton = new Button
            //{
            //    Name = $"btn{i}",
            //    Text = "",
            //    Size = new System.Drawing.Size(40, 33),
            //    Image = Resources.full_bin_32,

            //    FlatStyle = FlatStyle.Flat,
            //    // BackColor = System.Drawing.Color.Red,
            //    Margin = new Padding(11, 6, 1, 6),
            //    Location = new System.Drawing.Point(530, 3 + (i * 39)),
            //    Tag = i // Store index to identify which TextBox to remove
            //};
           // removeButton.FlatAppearance.BorderSize = 0;
            //removeButton.Click += RemoveButton_Click;
            //credit.Text = credit.Name;

            i++;

            fPanel1.Controls.Add(count);
            fPanel1.Controls.Add(marks);
            fPanel1.Controls.Add(credit);
            //fPanel1.Controls.Add(removeButton);
        }

        private bool isvalid()
        {
            if(SemestercomboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Select Semester No.", "Error", MessageBoxButtons.OK);
                SemestercomboBox.Focus();
                return false;
            }
            if (!(int.TryParse(no_of_subjects.Text, out int value)))
            {
                MessageBox.Show("Enter No. of Subjects Correctly ", "Error", MessageBoxButtons.OK);
                no_of_subjects.Clear();
                no_of_subjects.Focus();
                return false;
            }else if((int.TryParse(no_of_subjects.Text, out int valuei)) && int.Parse(no_of_subjects.Text) <= 0)
            {
                MessageBox.Show("Enter No. of Subjects Correctly ", "Error", MessageBoxButtons.OK);
                no_of_subjects.Clear();
                no_of_subjects.Focus();
                return false;
            }
            else if ((int.TryParse(no_of_subjects.Text, out int valueii)) && int.Parse(no_of_subjects.Text) >= 20)
            {
                MessageBox.Show("Enter No. of Subjects Correctly ", "Error", MessageBoxButtons.OK);
                no_of_subjects.Clear();
                no_of_subjects.Focus();
                return false;
            }
            return true;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            oblabel4.Hide();
            crlabel3.Hide();
            SemestercomboBox.SelectedIndex = 0;
            SemestercomboBox.Focus();
            fPanel1.Controls.Clear();
            no_of_subjects.Clear();
        }
        private double getgp(double marks)
        {
            if (marks >= 85 && marks <= 100)
            {
                return 4.0;
            }
            else if (marks >= 80 && marks < 85)
            {
                return 3.7;
            }
            else if (marks >= 75 && marks < 80)
            {
                return 3.3;
            }
            else if (marks >= 70 && marks < 75)
            {
                return 3.0;
            }
            else if (marks >= 65 && marks < 70)
            {
                return 2.7;
            }
            else if (marks >= 61 && marks < 65)
            {
                return 2.3;
            }
            else if (marks >= 58 && marks < 61)
            {
                return 2.0;
            }
            else if (marks >= 55 && marks < 58)
            {
                return 1.7;
            }
            else if (marks >= 50 && marks < 55)
            {
                return 1.0;
            }
            else if (marks < 50)
            {
                return 0.0;
            }
            return 0.0;
        }
        private void calculate_gpa()
        {
            checking=true;
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

                    if (textBox.Name.StartsWith("marks"))
                    {
                        int index = (int)textBox.Tag;
                        // Try to parse the text as a number for marks
                        if (double.TryParse(textBox.Text, out double value) && double.Parse(textBox.Text) <= 100 && double.Parse(textBox.Text) >= 0)
                        {
                            marksSum += value;
                            foreach (Control controler in fPanel1.Controls)
                            {

                                if (controler is TextBox creditbox)
                                {
                                    if ((int)creditbox.Tag == index && creditbox.Name.StartsWith("credit"))
                                    {
                                        if (double.TryParse(creditbox.Text, out double score) && double.Parse(creditbox.Text) <= 4 && double.Parse(creditbox.Text) >= 0.5)
                                        {
                                            creditSum += score;
                                            markscreditSum += (getgp(value) * score);
                                            // MessageBox.Show($"The sum of all 'marks' boxes is: {marksSum}\n" +
                                            //$"The sum of all 'credit' boxes is: {creditSum}\n" +
                                            // $"The sum of all 'total sum' boxes is: {markscreditSum}\n");
                                        }
                                        else
                                        {
                                            // Handle cases where the TextBox does not contain a valid number
                                            MessageBox.Show($"The value in '{creditbox.Name}' is not a valid number.\n" +
                                                $"Credit hours greater then equal to 0.5 and less then equal to 4.");
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
                                $"Marks should be in between 0-100.");
                            textBox.Clear();
                            textBox.Focus();
                            return;
                        }
                    }

                }
            }

            decimal gpa = decimal.Round(Convert.ToDecimal(markscreditSum / creditSum), 2);
            //gpa_text.Text = gpa.ToString("0.00");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Semester_No"].Value.ToString() == SemestercomboBox.Text)
                {
                    row.Cells["GPA"].Value = gpa;
                    row.Cells["Credit_Hours"].Value = creditSum;

                    checking = false;
                }
            }
            if(checking)
            {
                gpa_store gpas = new gpa_store()
                {
                    Semester_No = SemestercomboBox.Text,
                    GPA = gpa,
                    Credit_Hours = creditSum
                };


                gpa_cart.Add(gpas);
                gpa_cart = gpa_cart.OrderBy(x => x.Semester_No).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = gpa_cart;
            }
            
            check_calc = true;

            // Show the result in a MessageBox or update a Label, TextBox, etc.
            MessageBox.Show($"The sum of all 'marks' boxes is: {marksSum}\n" +
                    $"The sum of all 'credit' boxes is: {creditSum}\n" +
                     $"The sum of all 'total sum' boxes is: {markscreditSum}\n" +
                      $"The sum of all 'gpa' boxes is: {gpa}");
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (next_op && SemestercomboBox.SelectedIndex != 0)
            {
            calculate_gpa();
            }
            else
            {
                MessageBox.Show("Add Semesters Detail", "Error", MessageBoxButtons.OK);
                //832
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gpa_cart.Count > 0)
            {

            decimal multigpa = 0;
            decimal credit_sum = 0;
            decimal final_cgpa = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                   multigpa += (decimal.Parse(row.Cells["GPA"].Value.ToString()) * decimal.Parse(row.Cells["Credit_Hours"].Value.ToString())) ;
                   credit_sum+= decimal.Parse(row.Cells["Credit_Hours"].Value.ToString());

                 
            }
            final_cgpa = multigpa / credit_sum;
            gpa_text.Text= final_cgpa.ToString("0.00");
                groupBox1.Show();
            }
            else
            {
                MessageBox.Show("Fill Semester Details", "Error", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gpa_cart.Count > 0)
            {

            SemestercomboBox.SelectedIndex = 0;
            SemestercomboBox.Focus();
            fPanel1.Controls.Clear();
            no_of_subjects.Clear();
            gpa_cart.Clear();
            dataGridView1.DataSource=null;
            groupBox1.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oblabel4.Hide();
            crlabel3.Hide();
            next_op=false;
            SemestercomboBox.SelectedIndex = 0;
            SemestercomboBox.Focus();
            fPanel1.Controls.Clear();
            no_of_subjects.Clear();
            gpa_cart.Clear();
            dataGridView1.DataSource = null;
            groupBox1.Hide();
            this.Hide();
        }
    }
}
