using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;
            
            Console.WriteLine(">>> CONVERSOR DE TEMPERATURAS <<<");
            Console.WriteLine();
            Console.Write("Digite a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("==========================================================");

            Console.WriteLine();

            f = (c * 9 / 5) + 32;
            k = (c + 273.15);

            Console.WriteLine(c + " graus Celsius equivalem á " + f + " graus Fahrenheit.");
            Console.WriteLine();          
            Console.WriteLine(c + " graus Celsius equivalem á " + k + " graus Kelvin.");
            Console.WriteLine();
            Console.WriteLine("==========================================================");


            Console.ReadKey();

        }
    }
}
