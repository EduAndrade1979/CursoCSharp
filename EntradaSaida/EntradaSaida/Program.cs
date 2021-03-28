using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodos de entrada e saida (Console): Write, WriteLine, Read, ReadLine e ReadKey



            Console.Write("Mike "); // Sem quebra de linha
            Console.WriteLine("Mangini"); //Com a quebra de linha

            //int letra = Console.Read(); // Variavel captará o primeiro caracter digitado no console (Prompt)

            //Console.WriteLine(letra);

            string texto = Console.ReadLine(); // Variavel captará a linha inteira de caracteres.

            Console.WriteLine(texto);

            //Console.ReadKey(true);
            Console.ReadKey();


        }
    }
}
