using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, auxiliar;

            Console.WriteLine("Digite o nome #1:");
            nome1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o nome #2:");
            nome2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o nome #3:");
            nome3 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o nome #4:");
            nome4 = Console.ReadLine(); 
            Console.WriteLine();

            // Mecanismo para inverter nomes

            auxiliar = nome1;
            nome1 = nome4;
            nome4 = auxiliar;
            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;

           
            Console.WriteLine("Nomes inseridos na sequencia invertida: ");

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4); 

            Console.ReadKey();
        }
    }
}
