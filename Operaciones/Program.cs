using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            string linea;
            //Pedir numeros
            Console.WriteLine("Ingresa el primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingreso el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            //Operaciones Suma
            resultado = num1 + num2;
            Console.WriteLine("La Suma es {0}: ", resultado);

            //Operaciones Resta
            resultado = num1 - num2;
            Console.WriteLine("La Resta es {0}: ", resultado);

            //Operaciones Multiplicacion
            resultado = num1 * num2;
            Console.WriteLine("La Multiplicacion es {0}: ", resultado);

            //Operaciones Division
            resultado = num1 / num2;
            Console.WriteLine("La Division es {0}: ", resultado);

            //Operaciones Division
            resultado = num1 % num2;
            Console.WriteLine("El residuo es {0}: ", resultado);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}