using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            const double preciohamburguesa = 45;
            const double preciobebida = 15;
            const double preciopapas = 20;
            int hamburguesas, papas, bebidas;
            string linea;
            double total;

            Console.WriteLine("¿Cuántas hamburguesas fueron?");
            linea = Console.ReadLine();
            hamburguesas = int.Parse(linea);
            Console.WriteLine("¿Cuántas papas?");
            linea = Console.ReadLine();
            papas = int.Parse(linea);
            Console.WriteLine("¿Cuántas bebidas?");
            linea = Console.ReadLine();
            bebidas = int.Parse(linea);

            //Operaciones
            total = (hamburguesas * preciohamburguesa) + (papas * preciopapas) + (bebidas * preciobebida);
          
            //Imprimir
            Console.WriteLine("El total a pagar es de: $" + total);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();


        }
    }
}
