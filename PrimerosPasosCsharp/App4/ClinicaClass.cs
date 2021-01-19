using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasosCsharp.App4
{
    class ClinicaClass
    {
        private string nombres;
        private string apellidos;
        private string diagnostico;
        private string consultorio;
        private int diasHosp;
        private float precioAtencion;
        private float precioMedicinas;
        //Pagos
        private float pagoHosp;
        private float pagoAtencion;
        private float descuento;
        private float pagoTotal;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Consultorio { get => consultorio; set => consultorio = value; }
        public int DiasHosp { get => diasHosp; set => diasHosp = value; }
        public float PrecioAtencion { get => precioAtencion; set => precioAtencion = value; }
        public float PrecioMedicinas { get => precioMedicinas; set => precioMedicinas = value; }
        //Pagos
        public float PagoHosp { get => pagoHosp; set => pagoHosp = value; }
        public float PagoAtencion { get => pagoAtencion; set => pagoAtencion = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float PagoTotal { get => pagoTotal; set => pagoTotal = value; }

        public float CalcularPagoCamaLimp(int dias)
        {
            return dias * 100 * 0.6f;
        }

        public float CalcularPagoAlimentacion(int dias)
        {
            return dias * 100 * 0.4f;
        }

        public float CalcularPagoAtencionMedica(int dias, float pago)
        {
            return dias * pago;
        }

        public float CalcularDescuento(float pagoHospitalizacion, float pagoAtencion, float pagoMedicina, int dias)
        {
            float subtotal = pagoHospitalizacion + pagoAtencion + pagoMedicina;
            if(dias > 10)
            {
                return subtotal * 0.3f;
            }
            else
            {
                return subtotal * 0.1f;
            }
        }

        public string VerPorcentaje(int dias)
        {
            if(dias > 10)
            {
                return "Descuento (30%)";
            }
            else
            {
                return "Descuento (10%)";
            }
        }

        public float CalcularPagoTotal(float pagoHosp, float pagoAtencion, float pagoMedicina, float descuento)
        {
            return (pagoHosp + pagoAtencion + pagoMedicina) - descuento;
        }

        public string VerPromocion(string consultorio)
        {
            switch (consultorio)
            {
                case "CADIOLOGÍA":
                case "OFTALMOLOGÍA":
                    return "Tendrá un descuento de S/50 en su próxima consulta";
                case "GINECOLOGÍA":
                    return "Tendrá un descuento de S/30 en su próxima consulta";
                case "MEDICINA GENERAL":
                case "PEDIATRÍA":
                    return "Tendrá un descuento de S/20 en su próxima consulta";
                default:
                    return "No tiene ningún descuento";
            }
        }
    }
}
