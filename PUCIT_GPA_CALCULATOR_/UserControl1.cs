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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        int i = 1;
        double sumofMarks = 0;
        double sumofcrdits = 0;
        bool check_calc=false;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Control form 1", "Alert", MessageBoxButtons.OK);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            for(int j = 0; j < 8; j++)
            {
                generate_boxes();
                count++;
            }
        }

        private void add_subject_btn_Click(object sender, EventArgs e)
        {
            generate_boxes();
            count++;
        }

        private void generate_boxes()
        {
            TextBox count = new TextBox
            {
                Name = $"label{i}",
                Text = i.ToString() + ".",
                BackColor = SystemColors.Control,
                ReadOnly=true,
                TextAlign = HorizontalAlignment.Right,
                Size = new System.Drawing.Size(60, 30),
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
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.Click += RemoveButton_Click;
            //credit.Text = credit.Name;

            i++;

            fPanel1.Controls.Add(count);
            fPanel1.Controls.Add(marks);
            fPanel1.Controls.Add(credit);
            fPanel1.Controls.Add(removeButton);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {

            delete_button(sender);
            count--;
            }
            else
            {
                MessageBox.Show("Atleast One Subject Require To Calculate Gpa");
            }
        }
        private void delete_button(object sender)
        {
            // Cast sender to Button
            Button btn = sender as Button;
            if (btn != null)
            {
                // Get index from the Tag property
                int index = (int)btn.Tag;

                // Track the controls to remove
                List<Control> controlsToRemove = new List<Control>();

                // Collect controls to remove
                foreach (Control control in fPanel1.Controls)
                {
                    if (control is TextBox && (control.Name == $"marks{index}" || control.Name == $"credit{index}"))
                    {
                        controlsToRemove.Add(control);
                    }

                    if (control is Button && control.Name == $"btn{index}")
                    {
                        controlsToRemove.Add(control);
                    }
                    if (control is TextBox && (control.Name == $"label{index}"))
                    {
                        controlsToRemove.Add(control);
                    }
                }

                // Remove the collected controls
                foreach (Control control in controlsToRemove)
                {
                    fPanel1.Controls.Remove(control);
                    control.Dispose(); // Free up resources
                }
                int ix = 1;
                int iy = 1;
                int iz = 1;
                int ib = 1;
                foreach (Control control in fPanel1.Controls)
                {
                    if (control is TextBox x && (x.Name.StartsWith("label")))
                    {
                        x.Text = ix.ToString();
                        x.Name = $"label{ix}";
                        ix++;
                        //i = il;
                    }
                    if (control is TextBox y && (y.Name.StartsWith("marks")))
                    {
                        y.Name = $"marks{iy}";
                        iy++;
                        //i = il;
                    }
                    if (control is TextBox z && (z.Name.StartsWith("credit")))
                    {
                        z.Name = $"credit{iz}";
                        iz++;

                    }
                    if (control is Button b && (b.Name.StartsWith("btn")))
                    {
                        b.Name = $"btn{ib}";
                        b.Tag = ib;
                        ib++;
                        i = ib;
                    }



                }
            }
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
                        if (double.TryParse(textBox.Text, out double value) && double.Parse(textBox.Text)<=100 && double.Parse(textBox.Text) >= 0)
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
            gpa_text.Text=gpa.ToString("0.00");
            check_calc=true;
            // Show the result in a MessageBox or update a Label, TextBox, etc.
            MessageBox.Show($"The sum of all 'marks' boxes is: {marksSum}\n" +
                    $"The sum of all 'credit' boxes is: {creditSum}\n" +
                     $"The sum of all 'total sum' boxes is: {markscreditSum}\n" +
                      $"The sum of all 'gpa' boxes is: {gpa}");
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {

            calculate_gpa();
            if (check_calc)
            {
            groupBox1.Show();
            }
            }
            else
            {
                MessageBox.Show("Firstly Add Subject", "Error", MessageBoxButtons.OK);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_functionality();

        }

        private void reset_functionality()
        {
            groupBox1.Hide();
            count = 0;
            check_calc = false;
            fPanel1.Controls.Clear();
            i = 1;
            for (int j = 0; j < 8; j++)
            {

                generate_boxes();
                count++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            reset_functionality();
        }

       
    }
}
