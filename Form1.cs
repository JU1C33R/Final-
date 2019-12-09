using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;

#region MISC.


namespace Final_12_8_19
{
    public partial class Form1 : Form
    {
        double results = 0;
        string operation = "";
        bool enter_value = false;
        float iCelsius, iFarenheit, iKelvin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
        }
        #endregion

#region APP SETTINGS
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length >0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = txtDisplay.Text = "0";
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            LblShowOp.Text = "";
        }
        private void C_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            LblShowOp.Text = "";
        }
        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 230;
            txtDisplay.Width = 199;
        }
        private void ScientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 434;
            txtDisplay.Width = 403;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Width = 230;
            txtDisplay.Width = 199;
        }
        private void TemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 726;
            txtDisplay.Width = 403;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

#region OPERANDS
        private void Arithmic_Operands(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            LblShowOp.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            LblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (results + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        private void Log_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void Sqroot_Click(object sender, EventArgs e)
        {
            double sqroot = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("sqroot" + "(" + (txtDisplay.Text) + ")");
            sqroot = Math.Sqrt(sqroot);
            txtDisplay.Text = System.Convert.ToString(sqroot);
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            double qSinh = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("qSinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double qSin = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("qSin" + "(" + (txtDisplay.Text) + ")");
            qSin = Math.Sin(qSin);
            txtDisplay.Text = System.Convert.ToString(qSin);
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            double qCosh = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("qCosh" + "(" + (txtDisplay.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txtDisplay.Text = System.Convert.ToString(qCosh);
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double qCos = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("qCos" + "(" + (txtDisplay.Text) + ")");
            qCos = Math.Cos(qCos);
            txtDisplay.Text = System.Convert.ToString(qCos);
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            double qTanh = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("qTanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtDisplay.Text = System.Convert.ToString(qTanh);
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double qTan = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("qTan" + "(" + (txtDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txtDisplay.Text = System.Convert.ToString(qTan);
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void Hex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void Oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void Squared_Click(object sender, EventArgs e)
        {
            double a;

            a = System.Convert.ToDouble(txtDisplay.Text) * System.Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void Cubed_Click(object sender, EventArgs e)
        {
            double a;

            a = System.Convert.ToDouble(txtDisplay.Text) * System.Convert.ToDouble(txtDisplay.Text) * System.Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void OneOverX_Click(object sender, EventArgs e)
        {
            double a;

            a = System.Convert.ToDouble(1.0 / System.Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void LnX_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(txtDisplay.Text);
            LblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void CtoF_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C'; ;
        }

        private void FtoC_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void K_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            FtoC.Checked = false;
            CtoF.Checked = false;
            K.Checked = false;
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            double a;

            a = System.Convert.ToDouble(txtDisplay.Text) / System.Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    iCelsius = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFarenheit = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((iFarenheit - 32) * 5) / 9).ToString());
                    break;
                case 'K':
                    iKelvin = float.Parse(txtConvert.Text);
                    lblConvert.Text = (((((9 * iKelvin) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }
    }
}
#endregion