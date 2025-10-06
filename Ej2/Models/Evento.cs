using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
     class Evento
    {
        public DateTime Fecha {  get; set; }
        public string NombreEvento { get; set; }
        List<Tecnico> tecnicos = new List<Tecnico>();

        List<Persona> personas = new List<Persona>();
        public Evento(DateTime fecha, string nombreEvento)
        {
            Fecha = fecha;
            NombreEvento = nombreEvento;
        }
        public void RegistrarExportable(IExportable exp)
        {
            if (exp is Tecnico)
            {
                tecnicos.Add(exp as Tecnico);
            }
            else if (exp is Persona)
            {
                personas.Add(exp as Persona);
            }
        }
        public List<IExportable> VerExportables()
        {
            List<IExportable> exportables = new List<IExportable>();
            foreach(Tecnico t in tecnicos)
            {
                exportables.Add(t);
            }
            foreach(Persona p in personas)
            {
                if(p is IExportable)
                {
                    exportables.Add(p as IExportable);
                }
            }
            return exportables;
        }
        public override string ToString()
        {
            return $"{NombreEvento} {Fecha.ToString("dd/MM/yyyy")}";
        }
    }
}
