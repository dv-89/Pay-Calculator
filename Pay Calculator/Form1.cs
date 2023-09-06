using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.FirstName = fntb.Text; 
            e1.LastName = lntb.Text;
            e1.HoursWorked = double.Parse(hwtb.Text);
            e1.PayRate = double.Parse(prtb.Text);
            e1.EmpId = idtb.Text;

            double pay = e1.computePay();
            mplabel.Text = pay.ToString();

        }
    }
}
