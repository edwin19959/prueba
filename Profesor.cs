using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace RegistrosEstudiantes
{
    public class Profesor : Persona
    {
        public string Especialidad { get; set; }

        public Profesor(string nombre, string apellido, int edad, string especialidad)
            : base(nombre, apellido, edad)
        {
            Especialidad = especialidad;
        }

        public override string ObtenerInformacion()
        {
            return $"Profesor: {Nombre} {Apellido}, Edad: {Edad}, Especialidad: {Especialidad}";
        }
    }
}