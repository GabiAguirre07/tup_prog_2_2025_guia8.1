using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ej1.Models
{
     class Asalariado:Empleado,IExportable
    {
        public double Basico { get; set; }
        public double AportesPrevisionales { get;set; }
        public Asalariado(int dni,string nombre,double basico,double aportes):base(dni,nombre)
        {
            Basico = basico;
            AportesPrevisionales = aportes;
        }
        public override double CalcularImporteAPagar()
        {
            return Basico - AportesPrevisionales;
        }
        public override string[] GenerarRecibo()
        {
            List<string>recibos = new List<string>();
            recibos.Add ($"Empleado: {Nombre}({DNI})");
            recibos.Add($"Básico: ${Basico:f2}");
            recibos.Add($"Aportes: ${AportesPrevisionales:f2}");
            recibos.Add($"Total: ${CalcularImporteAPagar():f2}");
            return recibos.ToArray();
        }
        public string Exportar()
        {
            return $"Asalariado;{DNI};{Nombre};{Basico.ToString(CultureInfo.InvariantCulture)};{AportesPrevisionales.ToString(CultureInfo.InvariantCulture)}";
        }
        public override string ToString()
        {
            return $"Asalariado:{Nombre}({DNI});${Basico:f2};${AportesPrevisionales:f2}";
        }
    }
}
