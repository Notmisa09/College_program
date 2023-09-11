using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_program
{
    public class Secciones
    {

        public string Horario { get; set; }
        public string Aula { get; set; }

        public Secciones()
        {

        }
        public Secciones(string Horario, string Aula) 
        {
            this.Horario = Horario;
            this.Aula = Aula;
        }


        public Secciones Sec_selector()
        {

            Console.WriteLine(
         $@"------------LISTA DE SECCIONES------------

1--SECCIÓN: 2-B | HORARIO: 9-11:AM
2--SECCIÓN: 1-A | HORARIO: 8-10:AM
3--SECCIÓN: 5-C | HORARIO: 2-6:PM
            
");
            Console.WriteLine("Ingrese el el codigo de la materia a seleccionar: ");
            int read3 = int.Parse(Console.ReadLine());

            Secciones sec = null;

                switch (read3)
                {
                    case 1:
                        sec = new Secciones("9-11:AM", "2-B");
                        break;

                    case 2:
                        sec = new Secciones("8-10:AM", "1-A");
                        break;

                    case 3:
                        sec = new Secciones("2-6:PM", "5-C");
                        break;
                    default:
                        Console.WriteLine("La seccion introducida no existe.");
                        break;
                }
                if (sec != null)
                {
                    Console.WriteLine($"\nSu horario escgido es {sec.Horario} y su aula es {sec.Aula}");
                }

            return sec;
        }
    }
}