using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores serão apresentados? ");
            int valores = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Sequencia de Fibonacci com " + valores + " valores.");
            Console.WriteLine();


            int a = 0, b = 1, c = 0;

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a + ". ");
                }                
                
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();

        }
    }
}
