using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasosCsharp.App3
{
    class NotasClass
    {
        private string paterno;
        private string materno;
        private string nombres;
        private int edad;
        private string carrera;
        private byte modulo;
        private string unidad;
        private float nota1;
        private float nota2;
        private float nota3;

        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public byte Modulo { get => modulo; set => modulo = value; }
        public string Unidad { get => unidad; set => unidad = value; }
        public float Nota1 { get => nota1; set => nota1 = value; }
        public float Nota2 { get => nota2; set => nota2 = value; }
        public float Nota3 { get => nota3; set => nota3 = value; }

        public int CalcularYear(int edad)
        {
            DateTime fechaActual = DateTime.Today;
            return fechaActual.Year - edad;
        }

        public float CalcularPromedio(float nota1, float nota2, float nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public string VerMensaje(float nota1, float nota2, float nota3)
        {
            float promedio = CalcularPromedio(nota1, nota2, nota3);
            if(promedio < 13)
            {
                return "EL ESTUDIANTE ESTÁ DESAPROBADO";
            }
            else
            {
                return "EL ESTUDIANTE ESTÁ APROBADO";
            }
        }
    }
}
