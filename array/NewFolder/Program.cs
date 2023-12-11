using salflet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array.NewFolder
{
    internal class Program
    {
        public static void Main()
        {

            ElementoDto ed = new ElementoDto();

            ElementoDto[] hola = new ElementoDto[5];


            for(int i = 0; i < hola.Length; i++) {

                Console.WriteLine("ID");
                long idElemento = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("codigo");
                string codigoElemento = Console.ReadLine();

                Console.WriteLine("nombre");
                string nombreElemento = Console.ReadLine();

                Console.WriteLine("descripcion");
                string descripcionElemento = Console.ReadLine();

                Console.WriteLine("cantidad");
                int cantidadElemento = Convert.ToInt32(Console.ReadLine());
                hola[i] = new ElementoDto(idElemento, codigoElemento, nombreElemento, descripcionElemento, cantidadElemento);

                Console.WriteLine("---------------");


            }

            for (int i = 0; i < hola.Length; i++)
            {

                Console.WriteLine(hola[i]);

            }

            Console.ReadKey();
        }
        
    }

}
