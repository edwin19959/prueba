using System;
using System.Collections.Generic;

namespace RegistrosEstudiantes
{
    public class Curso
    {
        public string Nombre { get; set; }
        private List<Estudiante> estudiantes;
        public Profesor Profesor { get; set; }

        public Curso(string nombre)
        {
            Nombre = nombre;
            estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            if (estudiante != null)
            {
                estudiantes.Add(estudiante);
            }
        }

        public void AsignarProfesor(Profesor profesor)
        {
            Profesor = profesor;
        }

        public void MostrarInformacionCurso()
        {
            Console.WriteLine($"Curso: {Nombre}");
            if (Profesor != null)
            {
                Console.WriteLine(Profesor.ObtenerInformacion());
            }
            else
            {
                Console.WriteLine("No hay profesor asignado a este curso.");
            }

            if (estudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes en este curso.");
            }
            else
            {
                foreach (var estudiante in estudiantes)
                {
                    Console.WriteLine(estudiante.ObtenerInformacion());
                }
            }
        }

        public bool TieneNombre(string nombreCurso)
        {
            return !string.IsNullOrWhiteSpace(nombreCurso) && nombreCurso.Equals(Nombre, StringComparison.OrdinalIgnoreCase);
        }
    }
}