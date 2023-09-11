using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace College_program
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool toca_bucle = true;
            students estudiantes = new students();

            Console.WriteLine("Bienvenido al modulo de inscripcion! \n");

            while (toca_bucle == true)
            {
                Console.WriteLine("Desea usted Inscribir un estudiante? (SI/Cualquier tecla para no)");
                string read = Console.ReadLine();
                read = read.ToUpper();

                if (read == "SI")
                {
                    estudiantes.Crear_Estudiante();
                    Console.Clear();
                    estudiantes.Imprimir_Estudiante();

                }
                else
                {
                    Console.WriteLine("Gracias por usar la aplicacion");
                    toca_bucle = false;
                    Console.ReadKey();
                }
            }

        }

    }
}
