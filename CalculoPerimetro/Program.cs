using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.- Declarar las variables
            int a = 10;
            int b = 10;
            int c = 7;

            //2.- Crear una variable de tipo INT la cual guardará la suma de las tres variables
            int perimetro = a + b + c;


            //3.- Mostrar en pantalla el valor del perimetro "El perimetro del triangulo es: "
            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
    }
