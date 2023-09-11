using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace College_program
{
    public class Asignaturas
    {   
        public int Codigo {get; set;}
        public string Nombre { get; set; }
        public Secciones Secciones { get; set; }

        public Asignaturas()
        {
            Secciones = new Secciones();
        }

        public Asignaturas(int codigo, string nombre, Secciones secciones)
        {
            Codigo = codigo;
            Nombre = nombre;
            Secciones = secciones;
        }

        public static List<Asignaturas> Asig_selector()
        {
            List<Asignaturas> Asig_elegidas = new List<Asignaturas>();
            string bucle = "SI";

            while (bucle != "NO")
            {
                Console.WriteLine(
         $@"------------LISTA DE ASIGNATURAS------------

1--ASIGNATURA: SOFTWARE | CODIGO: 1 | 
2--ASIGNATURA: MECATRONICA | CODIGO: 2 | 
3--ASIGNTURA : DATA-BASE | CODIGO 3 |
            
");
            Console.WriteLine("Ingrese el el codigo de la materia a seleccionar: ");
            int read2 = int.Parse(Console.ReadLine());

            Asignaturas ms = null;
            Secciones secciones = new Secciones();

                switch (read2)
                {
                    case 1:
                       ms = new Asignaturas(1, "Software", secciones);
                       ms.Secciones = secciones.Sec_selector();

                        break;

                    case 2:
                        ms = new Asignaturas(2, "Mecatronica",secciones);
                        ms.Secciones = secciones.Sec_selector();
                        break;

                    case 3:
                        ms = new Asignaturas(3, "DATA-BASE", secciones);
                        ms.Secciones = secciones.Sec_selector();
                        break;
                    default:
                        Console.WriteLine("La materia introducida no existe.");
                        break;
                }
                if (ms != null)
                {
                    Asig_elegidas.Add(ms);
                    Console.WriteLine($"\nSu materia escgida es {ms.Nombre} y su codigo es {ms.Codigo}\n");
                    Console.WriteLine("Cargando siguiente pagina espere...");
                    Thread.Sleep(2000);
                }
                Console.Clear();
                Console.WriteLine("Desea continuar agragando materias? (NO) presiona cualquier otra tecla para continuar");
                bucle = (Console.ReadLine());

                bucle = bucle.ToUpper();

            }
            return Asig_elegidas;
        }

    }

}
