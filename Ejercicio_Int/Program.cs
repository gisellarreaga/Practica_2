using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Declarar tres variables de tipo INT
            int numero_1 = 5;
            int numero_2 = 20;
            int numero_3 = 10;

            //2.- Crear una variable de tipo INT la cual guardará la suma de las tres variables
            int suma = numero_1 + numero_2 + numero_3;

            //3.- Mostrar en pantalla el valor de SUMA "El valor de suma es:"
            Console.WriteLine("El valor de la suma es: " + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
