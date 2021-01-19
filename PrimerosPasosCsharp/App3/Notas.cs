using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerosPasosCsharp.App3
{
    public partial class Notas : Form
    {
        NotasClass nota = new NotasClass();
        public Notas()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtPaterno.Text != "" && TxtMaterno.Text != "" && TxtNombres.Text != "" && TxtEdad.Text != "" && TxtCarrera.Text != "" && TxtModulo.Text != "" 
                && TxtUnidad.Text != "" && TxtNota1.Text != "" && TxtNota2.Text != "" && TxtNota3.Text != "")
            {                
                if (float.Parse(TxtNota1.Text) > 20)
                {
                    MessageBox.Show("La nota 1 no es válida", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else if (float.Parse(TxtNota2.Text) > 20)
                {
                    MessageBox.Show("La nota 2 no es válida", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else if (float.Parse(TxtNota3.Text) > 20)
                {
                    MessageBox.Show("La nota 3 no es válida", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nota.Paterno = TxtPaterno.Text;
                    nota.Materno = TxtMaterno.Text;
                    nota.Nombres = TxtNombres.Text;
                    nota.Edad = int.Parse(TxtEdad.Text);
                    nota.Carrera = TxtCarrera.Text;
                    nota.Modulo = Convert.ToByte(TxtModulo.Text);
                    nota.Unidad = TxtUnidad.Text;
                    nota.Nota1 = float.Parse(TxtNota1.Text);
                    nota.Nota2 = float.Parse(TxtNota2.Text);
                    nota.Nota3 = float.Parse(TxtNota3.Text);
                    MessageBox.Show("Los datos se guardaron", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCalcularYear_Click(object sender, EventArgs e)
        {
            TxtYear.Text = Convert.ToString(nota.CalcularYear(nota.Edad));
        }

        private void BtnCalcularPromedio_Click(object sender, EventArgs e)
        {
            TxtPromedio.Text = Convert.ToString(nota.CalcularPromedio(nota.Nota1, nota.Nota2, nota.Nota3));
        }

        private void BtnMensaje_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = nota.VerMensaje(nota.Nota1, nota.Nota2, nota.Nota3);
        }

        private void BtnResumen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El estudiante " + nota.Paterno + " " + nota.Materno + " " + nota.Nombres + " en la Unidad Didáctica: " + nota.Unidad + " obtuvo un promedio de: " + nota.CalcularPromedio(nota.Nota1, nota.Nota2, nota.Nota3) , "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtPaterno.Text = "";
            TxtMaterno.Text = "";
            TxtNombres.Text = "";
            TxtEdad.Text = "";
            TxtCarrera.Text = "";
            TxtModulo.Text = "";
            TxtUnidad.Text = "";
            TxtNota1.Text = "";
            TxtNota2.Text = "";
            TxtNota3.Text = "";
            TxtYear.Text = "";
            TxtPromedio.Text = "";
            LblMensaje.Text = "";
            TxtPaterno.Focus();
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNota1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNota2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNota3_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
