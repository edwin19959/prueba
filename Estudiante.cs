using System;

namespace RegistrosEstudiantes
{
    public class Estudiante : Persona
    {
        public string NombreCurso { get; set; }

        public Estudiante(string nombre, string apellido, int edad, string nombreCurso)
            : base(nombre, apellido, edad)
        {
            NombreCurso = nombreCurso;
        }

        public override string ObtenerInformacion()
        {
            return $"Estudiante: {Nombre} {Apellido}, Edad: {Edad}, Curso: {NombreCurso}";
        }
    }
}