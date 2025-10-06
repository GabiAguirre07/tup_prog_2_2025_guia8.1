using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
   class Expositor:Persona,IExportable
    {
        public string PapelProtagonico { get; set; }
        public Expositor():base(0,"") { }
        public Expositor(int dni, string nombre,string papel):base(dni,nombre)
        {
            PapelProtagonico = papel;
        }

        public void Leer(string[] linea)
        {
            dni = Convert.ToInt32(linea[1]);
            nombre = linea[2];
            PapelProtagonico = linea[3];
        }

        public string Escribir()
        {
            return $"{dni};{Nombre};{PapelProtagonico}";
        }
    }
}
