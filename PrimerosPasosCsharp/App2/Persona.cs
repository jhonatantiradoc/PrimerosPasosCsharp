using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerosPasosCsharp.App2
{
    public partial class Persona : Form
    {
        PersonaClass per = new PersonaClass();
        public Persona()
        {
            InitializeComponent();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if(TxtNombre.Text != "" && TxtEdad.Text != "" && TxtTalla.Text != "" && TxtPeso.Text != "" && TxtColor.Text != "" && TxtGenero.Text != "")
            {
                per.Nombre = TxtNombre.Text;
                per.Edad = int.Parse(TxtEdad.Text);
                per.Talla = float.Parse(TxtTalla.Text);
                per.Peso = float.Parse(TxtPeso.Text);
                per.Color = TxtColor.Text;
                per.Genero = TxtGenero.Text;
                MessageBox.Show("Los datos se guardaron", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            LblNombre.Text = "El nombre es: " + per.Nombre;
            LblEdad.Text = "La edad es: " + per.Edad;
            LblTalla.Text = "La talla es: " + per.Talla;
            LblPeso.Text = "El peso es: " + per.Peso;
            LblColor.Text = "El color es: " + per.Color;
            LblGenero.Text = "El género es: " + per.Genero;
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // sólo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // sólo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtEdad.Text = "";
            TxtTalla.Text = "";
            TxtPeso.Text = "";
            TxtColor.Text = "";
            TxtGenero.Text = "";
            LblNombre.Text = "";
            LblEdad.Text = "";
            LblTalla.Text = "";
            LblPeso.Text = "";
            LblColor.Text = "";
            LblGenero.Text = "";
            TxtNombre.Focus();
        }
    }
}
