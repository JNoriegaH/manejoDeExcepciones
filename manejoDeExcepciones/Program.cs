using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejoDeExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            try
            {
                Console.Write("Ingrese un numero entero: ");
                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("El cuadrado es {0}", Math.Pow(numero, 2));
            }
            catch (FormatException s)
            {
                Console.WriteLine(s.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
