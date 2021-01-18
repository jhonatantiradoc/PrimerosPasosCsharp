using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerosPasosCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNum1.Text != "" && TxtNum2.Text != "")
            {
                double num1, num2, suma, resta, multiplicacion, division;
                num1 = Convert.ToDouble(TxtNum1.Text);
                num2 = Convert.ToDouble(TxtNum2.Text);
                suma = num1 + num2;
                resta = num1 - num2;
                multiplicacion = num1 * num2;
                division = num1 / num2;
                txtSuma.Text = suma.ToString();
                txtResta.Text = "" + resta;
                txtMulti.Text = Convert.ToString(multiplicacion);
                txtDivision.Text = division.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese los valores", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNum1.Focus();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNum1.Clear();
            TxtNum2.Text = "";
            txtSuma.Text = "";
            txtResta.Text = "";
            txtMulti.Text = "";
            txtDivision.Text = "";
            TxtNum1.Focus();
        }

        private void TxtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
