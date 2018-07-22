using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTrial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string income = txtIncome.Text;

            lblResult.Text = "Your Income after: " + CalculateTax.ValidateInput(income);

            //string result = CalculateTax.ValidateInput(income);
            //lblResult.Text = "Your Income after $" + income + " Tax is $" + result;
        }
    }
}
