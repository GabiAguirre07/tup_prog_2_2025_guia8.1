using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ej1.Models
{
     class Jornalero:Empleado,IExportable
    {
        public int HorasTrabajadas {  get;set; }
        public double ImportePorHora { get;set; }
        public double RetencionesImpositivas { get;set; }
        public Jornalero(int dni, string nombre,int horastr,double importe,double retenciones):base(dni,nombre) 
        {
            HorasTrabajadas = horastr;
            ImportePorHora = importe;
            RetencionesImpositivas = retenciones;
        }
        public override double CalcularImporteAPagar()
        {
            return HorasTrabajadas * ImportePorHora - RetencionesImpositivas;
        }
        public override string[] GenerarRecibo()
        {
            List<string> recibos = new List<string>();
            recibos.Add($"Empleado: {Nombre}({DNI})");
            recibos.Add($"Horas trabajadas: {HorasTrabajadas}");
            recibos.Add($"Importe por hora: {ImportePorHora}");
            recibos.Add($"Retenciones impositivas: {RetencionesImpositivas}");
            recibos.Add($"Total: {CalcularImporteAPagar():f2}");
            return recibos.ToArray();
        }
        public string Exportar()
        {
            return $"Jornalero;{DNI};{Nombre};{HorasTrabajadas};{ImportePorHora.ToString(CultureInfo.InvariantCulture)};{RetencionesImpositivas.ToString(CultureInfo.InvariantCulture)}";
        }
        public override string ToString()
        {
            return $"Jornalero:{Nombre}({DNI});{HorasTrabajadas};{ImportePorHora};{RetencionesImpositivas}";
        }
    }
}
