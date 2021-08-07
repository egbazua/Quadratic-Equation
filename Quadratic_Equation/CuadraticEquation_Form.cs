using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_Equation
{
    public partial class Equation_Form : Form
    {
        double result1_r;
        double result2_r;
        public Equation_Form()
        {
            InitializeComponent();
            result1_r=0;
            result2_r=0;
        }

        private void Calculate_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(a_Tbx.Text) || string.IsNullOrEmpty(b_Tbx.Text) || string.IsNullOrEmpty(c_Tbx.Text))
                MessageBox.Show("Favor de llenar todos los campos.");
            else
            {
                result1_r = result1(Convert.ToDouble(a_Tbx.Text), Convert.ToDouble(b_Tbx.Text), Convert.ToDouble(c_Tbx.Text));
                result2_r = result2(Convert.ToDouble(a_Tbx.Text), Convert.ToDouble(b_Tbx.Text), Convert.ToDouble(c_Tbx.Text));

                result1a_Lbl.Text = Convert.ToString(result1_r);
                result2b_Lbl.Text = Convert.ToString(result2_r);
            }
        }//Calculate Button.

        private double result1(Double xa, Double xb, Double xc)
        {
            double result_r;

            result_r = (-(xb) + Math.Sqrt((xb * xb) - 4 * xa * xc)) / (2 * xa);

            return result_r;
        }//result 1 method.
        private double result2(Double xa, Double xb, Double xc)
        {
            double result_r;

            result_r = (-(xb) - Math.Sqrt((xb * xb) - 4 * xa * xc)) / (2 * xa);

            return result_r;
        }//result 2 method.
    }//End of class.
}
