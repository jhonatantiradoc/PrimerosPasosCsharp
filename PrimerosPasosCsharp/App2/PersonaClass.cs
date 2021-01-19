using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasosCsharp.App2
{
    class PersonaClass
    {
        private string nombre;
        private int edad;
        private float talla;
        private float peso;
        private string color;
        private string genero;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public float Talla { get => talla; set => talla = value; }
        public float Peso { get => peso; set => peso = value; }
        public string Color { get => color; set => color = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
