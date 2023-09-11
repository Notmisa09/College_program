using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace College_program
{
    public class students
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string Apellido { get; set; }
        public List<Asignaturas> Asig_seleccionadas { get; set; }

        public students()
        {
            Asig_seleccionadas = new List<Asignaturas>();
        }

        public students(int Matricula, string Nombre, string Apellido, string Carrera)
        {
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Carrera = Carrera;
        }


        public void  Crear_Estudiante()
        {

            Console.WriteLine("Ingrese el nombre del estudiante:");
             Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del estudiante:");
             Apellido  = Console.ReadLine();

            Console.WriteLine("Ingrese la matricula del estudiante:");
             Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la carreara del estudiante:");
             Carrera = Console.ReadLine();

            Console.WriteLine("\n Cargando siguiente pagina espere...");
            Thread.Sleep(2000);
            Console.Clear();

            Asig_seleccionadas = Asignaturas.Asig_selector();

        }

        public void Imprimir_Estudiante()
        {
            Console.WriteLine("Seleccion de estudiantes:\n");
            Console.WriteLine("Nombre\t\tApellido\tMatricula\tCodigo\t\tAsignatura\tHorario\t\tAula");

            foreach (Asignaturas asignatura in Asig_seleccionadas)
            {
                Console.WriteLine($"{Nombre,-20}{Apellido,-12}{Matricula,-15}{asignatura.Codigo,-9}{asignatura.Nombre,-15}{asignatura.Secciones.Horario,-15}{asignatura.Secciones.Aula}");
            }
        }

    }

}

