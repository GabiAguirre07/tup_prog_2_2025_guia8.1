using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    abstract class Empleado:IComparable
    {
        public int DNI { get;  set; }
        public string Nombre { get;  set; }
        public Empleado(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
        public abstract double CalcularImporteAPagar();
        public abstract string [] GenerarRecibo();
        public int CompareTo(object? other)
        {
            if(other != null)
            {
                Empleado otro = (Empleado)other;
                return DNI.CompareTo(otro?.DNI);
            }
            return -1;
        }
    }
}
