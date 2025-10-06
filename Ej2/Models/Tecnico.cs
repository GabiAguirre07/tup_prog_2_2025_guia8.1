using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    class Tecnico : IExportable
    {
        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public Tecnico() { }
        public Tecnico(string cuit, string nombre, string cargo)
        {
            CUIT = cuit;
            Nombre = nombre;
            Cargo = cargo;
        }

        public void Leer(string[] linea)
        {
            CUIT = linea[1];
            Nombre = linea[2];
            Cargo = linea[3];
        }

        public string Escribir()
        {
            return $"{CUIT};{Nombre};{Cargo}";
        }
    }
}
