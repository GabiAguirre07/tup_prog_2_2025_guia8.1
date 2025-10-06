using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
   public abstract class Persona
    {
        protected int dni;
        protected string nombre;
        public int DNI { get { return dni; } }
        public string Nombre { get { return nombre; } }
        public Persona(int dni,string nombre) 
        {
            this.dni = dni;
            this.nombre = nombre;
        }
    }
}

