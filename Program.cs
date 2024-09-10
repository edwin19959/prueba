using System;
using System.Collections.Generic;

namespace RegistrosEstudiantes
{
    public class Program
    {
        private static List<Curso> cursos = new List<Curso>();

        public static void Main()
        {
            // Inicializar algunos cursos
            cursos.Add(new Curso("Programación 2"));
            cursos.Add(new Curso("Programación Web"));
            cursos.Add(new Curso("Bases de Datos"));

            while (true)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEstudiante();
                        break;
                    case "2":
                        AsignarProfesor();
                        break;
                    case "3":
                        MostrarInformacionCurso();
                        break;
                    case "4":
                        Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Gestión de Cursos ===");
            Console.WriteLine("\n");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Asignar profesor");
            Console.WriteLine("3. Mostrar información del curso");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
        }

        private static void AgregarEstudiante()
        {
            Console.Clear();
            Console.WriteLine("=== Agregar Estudiante ===");
            Console.WriteLine("\n");
            Console.WriteLine("Cursos disponibles:");
            for (int i = 0; i < cursos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cursos[i].Nombre}");
            }

            Console.Write($"{Environment.NewLine}Seleccione el número del curso: ");
            if (int.TryParse(Console.ReadLine(), out int cursoIndex) && cursoIndex > 0 && cursoIndex <= cursos.Count)
            {
                Curso cursoSeleccionado = cursos[cursoIndex - 1];

                Console.Write($"{Environment.NewLine}Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el apellido del estudiante: ");
                string apellido = Console.ReadLine();

                Console.Write("Ingrese la edad del estudiante: ");
                if (int.TryParse(Console.ReadLine(), out int edad))
                {
                    Estudiante estudiante = new Estudiante(nombre, apellido, edad, cursoSeleccionado.Nombre);
                    cursoSeleccionado.AgregarEstudiante(estudiante);
                    Console.WriteLine($"{Environment.NewLine}Estudiante agregado exitosamente al curso {cursoSeleccionado.Nombre}.");
                }
                else
                {
                    Console.WriteLine($"{Environment.NewLine}Error: Edad no válida.");
                }
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Error: Selección de curso no válida.");
            }

            Console.WriteLine($"{Environment.NewLine}Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }

        private static void AsignarProfesor()
        {
            Console.Clear();
            Console.WriteLine("=== Asignar Profesor ===");
            Console.WriteLine("\n");
            Console.WriteLine("Cursos disponibles:");
            for (int i = 0; i < cursos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cursos[i].Nombre}");
            }

            Console.Write($"{Environment.NewLine}Seleccione el número del curso: ");
            if (int.TryParse(Console.ReadLine(), out int cursoIndex) && cursoIndex > 0 && cursoIndex <= cursos.Count)
            {
                Curso cursoSeleccionado = cursos[cursoIndex - 1];

                Console.Write($"{Environment.NewLine}Ingrese el nombre del profesor: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el apellido del profesor: ");
                string apellido = Console.ReadLine();

                Console.Write("Ingrese la edad del profesor: ");
                if (int.TryParse(Console.ReadLine(), out int edad))
                {
                    Console.Write("Ingrese la especialidad del profesor: ");
                    string especialidad = Console.ReadLine();

                    Profesor profesor = new Profesor(nombre, apellido, edad, especialidad);
                    cursoSeleccionado.AsignarProfesor(profesor);
                    Console.WriteLine($"{Environment.NewLine}Profesor asignado exitosamente al curso {cursoSeleccionado.Nombre}.");
                }
                else
                {
                    Console.WriteLine($"{Environment.NewLine}Error: Edad no válida.");
                }
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Error: Selección de curso no válida.");
            }

            Console.WriteLine($"{Environment.NewLine}Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }

        private static void MostrarInformacionCurso()
        {
            Console.Clear();
            Console.WriteLine("=== Mostrar Información del Curso ===");
            Console.WriteLine("Cursos disponibles:");
            for (int i = 0; i < cursos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cursos[i].Nombre}");
            }

            Console.Write($"{Environment.NewLine}Seleccione el número del curso: ");
            if (int.TryParse(Console.ReadLine(), out int cursoIndex) && cursoIndex > 0 && cursoIndex <= cursos.Count)
            {
                Curso cursoSeleccionado = cursos[cursoIndex - 1];
                Console.Clear();
                cursoSeleccionado.MostrarInformacionCurso();
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Error: Selección de curso no válida.");
            }

            Console.WriteLine($"{Environment.NewLine}Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
    }
}
