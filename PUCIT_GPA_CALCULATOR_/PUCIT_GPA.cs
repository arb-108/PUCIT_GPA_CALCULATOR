using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control_Form_Practice
{
    public partial class PUCIT_GPA : Form
    {
        public PUCIT_GPA()
        {
            InitializeComponent();
        }

        private void gpa_calc_Click(object sender, EventArgs e)
        {
           
            userControl11.Show();
        }

        private void cgpa_calc_Click(object sender, EventArgs e)
        {
            userControl21.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
