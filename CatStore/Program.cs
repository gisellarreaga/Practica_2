using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatStore
{
    class Program
    {
        static void Main(string[] args)
        {


            double cantidadlatas, total, total2, totaltres;
            string linea;

            // Mensaje de bienvenida
            Console.WriteLine("   ¡Bienvenido a la tienda de comida para gatos!");
            //Pedir la cantidad de latas
            Console.WriteLine("Por favor, ingrese la cantidad de latas solicitadas:");
            linea = Console.ReadLine();
            cantidadlatas = double.Parse(linea);


            //Condicional de descuento
            if (cantidadlatas >=50 && cantidadlatas <=99)
            {
                total2 = (cantidadlatas * 1.75);
                Console.WriteLine("El usuario pidió " + cantidadlatas + " latas y el total es de $" + total2 + " dolares.");

            }
            else if (cantidadlatas >=100)
            {
                totaltres = (cantidadlatas * 1.50);
                Console.WriteLine("El usuario pidió " + cantidadlatas + " latas y el total es de $" + totaltres + " dolares.");
            }
            else
            {
                //Hacer una operacion que multiplique la cantidad * precio de cada lata
                total = (cantidadlatas * 2);
                //Imprimir
                Console.WriteLine("El total a pagar por " + cantidadlatas + " latas es de $" + total + " dolares.");
            }
            Console.WriteLine(" Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}


