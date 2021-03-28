using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo While
            //int valor = 0;

            //while (valor <= 10) // Primeiro faz a verificação "While" e depois executa o código.
            //{
            //    Console.Write(valor + " ");                
            //    valor++;
            //}
            #endregion

            #region Ciclo Do - While
            int value = 0;

            //do // Executa o código e depois faz a validação "WHILE"
            //{
            //    Console.WriteLine("Number: " + value);
            //    value++;
            //} while (value < 5);
            #endregion

            #region Ciclo For
            //for (int i = 10, j = 0; i >= 0; i--, j++)
            //{
            //    Console.WriteLine("I = " + i + " |" + "J = " + j);
            //}
            #endregion

            #region Ciclo Foreach
            //string[] members =
            //{
            //    "Page",
            //    "Plant",
            //    "Jones",
            //    "Bonham"
            //};

            //foreach (string member in members)
            //{
            //    if (member == "Bonham")
            //    {
            //        Console.WriteLine("Moby Dick");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Others");
            //    }
            //}

            //int quant = 0;
            //foreach (string member in members)
            //{
            //    quant++;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Members tem " + quant + " membros.");
            #endregion

            Console.ReadKey();
        }
    }
}
