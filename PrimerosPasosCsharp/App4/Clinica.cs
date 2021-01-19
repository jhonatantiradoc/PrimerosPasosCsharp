using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerosPasosCsharp.App4
{
    public partial class Clinica : Form
    {
        ClinicaClass cli = new ClinicaClass();
        public Clinica()
        {
            InitializeComponent();

            MostrarFechaHora();

            //Deshabilitar cajas de texto
            TxtFecha.Enabled = false;
            TxtHora.Enabled = false;

            TxtCamaLimp.Enabled = false;
            TxtAlimentacion.Enabled = false;
            TxtAtencionMedica.Enabled = false;
            TxtMedicina.Enabled = false;
            TxtDescuento.Enabled = false;
            TxtTotal.Enabled = false;

            //Ocultar el label
            LblMensaje.Visible = false;

            //Cargar datos al Combobox Consultorio
            //CboConsultorio.Items.Insert(0, "CARDIOLOGÍA");
            CboConsultorio.Items.Add("CARDIOLOGÍA");
            CboConsultorio.SelectedIndex = 0;
            CboConsultorio.Items.Add("GINECOLOGÍA");
            CboConsultorio.Items.Add("MEDICINA GENERAL");
            CboConsultorio.Items.Add("OFTALMOLOGÍA");
            CboConsultorio.Items.Add("PEDIATRÍA");          
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtNombres.Text != "" && TxtApellidos.Text != "" && TxtDiagnostico.Text != "" && TxtDiasHosp.Text != "" && TxtPrecioAtencion.Text != ""
                && TxtPrecioMedicinas.Text != "")
            {
                cli.Nombres = TxtNombres.Text;
                cli.Apellidos = TxtApellidos.Text;
                cli.Diagnostico = TxtDiagnostico.Text;
                cli.Consultorio = CboConsultorio.SelectedItem.ToString();
                cli.DiasHosp = int.Parse(TxtDiasHosp.Text);
                cli.PrecioAtencion = float.Parse(TxtPrecioAtencion.Text);
                cli.PrecioMedicinas = float.Parse(TxtPrecioMedicinas.Text);
                MessageBox.Show("Los datos se guardaron", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnCalcularPagoHosp_Click(object sender, EventArgs e)
        {
            TxtCamaLimp.Text = Convert.ToString(cli.CalcularPagoCamaLimp(cli.DiasHosp));
            TxtAlimentacion.Text = Convert.ToString(cli.CalcularPagoAlimentacion(cli.DiasHosp));
            cli.PagoHosp = float.Parse(TxtCamaLimp.Text) + float.Parse(TxtAlimentacion.Text);
        }

        private void BtnCalcularPagoAtencion_Click(object sender, EventArgs e)
        {
            TxtAtencionMedica.Text = Convert.ToString(cli.CalcularPagoAtencionMedica(cli.DiasHosp, cli.PrecioAtencion));
            cli.PagoAtencion = float.Parse(TxtAtencionMedica.Text);
        }

        private void BtnAplicarDescuento_Click(object sender, EventArgs e)
        {
            TxtMedicina.Text = Convert.ToString(cli.PrecioMedicinas);
            TxtDescuento.Text = Convert.ToString(cli.CalcularDescuento(cli.PagoHosp, cli.PagoAtencion, cli.PrecioMedicinas, cli.DiasHosp));
            cli.Descuento = float.Parse(TxtDescuento.Text);
            LblDescuento.Text = cli.VerPorcentaje(cli.DiasHosp);
        }

        private void BtnCalcularPagoTotal_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = Convert.ToString(cli.CalcularPagoTotal(cli.PagoHosp, cli.PagoAtencion, cli.PrecioMedicinas, cli.Descuento));
            cli.PagoTotal = float.Parse(TxtTotal.Text);
        }

        private void BtnVerPromocion_Click(object sender, EventArgs e)
        {
            LblMensaje.Visible = true;
            LblMensaje.Text = cli.VerPromocion(CboConsultorio.SelectedItem.ToString());
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            TxtDiagnostico.Text = "";
            CboConsultorio.SelectedIndex = 0;
            TxtDiasHosp.Text = "";
            TxtPrecioAtencion.Text = "";
            TxtPrecioMedicinas.Text = "";
            TxtCamaLimp.Text = "";
            TxtAlimentacion.Text = "";
            TxtAtencionMedica.Text = "";
            TxtMedicina.Text = "";
            TxtDescuento.Text = "";
            TxtTotal.Text = "";
            LblMensaje.Visible = false;
            LblDescuento.Text = "Descuento (%)";
            MostrarFechaHora();      
            TxtNombres.Focus();
        }

        private void MostrarFechaHora()
        {
            //Mostrar la fecha
            DateTime fechaActual = DateTime.Now;
            TxtFecha.Text = fechaActual.ToString("dd/MM/yyyy");

            //Mostrar la hora
            TxtHora.Text = fechaActual.ToString("hh:mm:ss");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TxtDiasHosp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecioAtencion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtPrecioMedicinas_KeyPress(object sender, KeyPressEventArgs e)
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
