using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un caracter
            Console.WriteLine("Ingresa un cáracter:");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (char.IsLower(c))
                {
                    Console.WriteLine("El caracter es letra minuscula");
                }
                else
                {
                    Console.WriteLine("El caracter es letra mayuscula");
                }
            }
            else
            {
                Console.WriteLine("El cara ter es un numero");
            }
        
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
