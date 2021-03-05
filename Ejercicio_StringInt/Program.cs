using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;

            //Pedir por consola el nombre de una persona y la edad
            Console.WriteLine("Por favor, escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años.");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

            //Version de la profesora
            //String Nombre;
            //String LineaEdad;
            //int edad;

            //Console.WriteLine("Escribe tu nombre: ");
            //Nombre = Console.ReadLine();
            //Console.WriteLine("Escribe la edad: ");
            //LineaEdad = Console.ReadLine();
            //edad = Convert.ToInt32(LineaEdad);
            //Console.WriteLine("Tu nombre es: " + Nombre + " y tienes " + | ed¡	^+"años");
            //Console.WriteLine("Presiona cualquier tecla para continuar");
            //Console.ReadKey(); 

        }
    }
}

