using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição Encadeada
            //int valor = 31;

            //if (valor < 10)
            //{
            //    Console.WriteLine("Menor que 10");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Entre 10 e 19");
            //}
            //else if (valor >= 20 && valor <= 30)
            //{
            //    Console.WriteLine("Entre 20 e 30");
            //}
            //else
            //{
            //    Console.WriteLine("Valor excede 30");

            //}

            //Console.Write("Digite um valor válido: ");
            //valor = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nNovo valor encontrado..." + valor);
            #endregion

            #region Condição Aninhada
            //int number = 7;

            //if (number < 10)
            //{
            //    Console.Write(number + " é menor que 10");


            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(" e é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" e é impar.");

            //    }
            //}

            //if (number >= 10)
            //{
            //    Console.WriteLine("Número inválido");

            //}
            //Console.ReadKey();
            #endregion

            #region Operador Ternário

            int num = 13;

            string message = " ";

            // OPERADOR TERNÁRIO: 

            // condição ? true : false

            message = num >= 10 ? "Maior ou igual á 10" : "Menor que 10";


            // Forma tradicional:

            //if (num >= 10)
            //{
            //    message = "Maior ou igual á 10";

            //}
            //else
            //{
            //    message = "Menor que 10";
            //}
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


