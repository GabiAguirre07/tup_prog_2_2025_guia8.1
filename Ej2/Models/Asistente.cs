using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    class Asistente:Persona
    {
        public double ValorSeguro { get; set; }
        public Asistente(int dni,string nombre,double valorSeguro):base(dni,nombre)
        {
            ValorSeguro = valorSeguro;
        }
    }
}
