using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao__Array_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            int[] numeros = new int[5]; // Primeira forma de inicialização

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;



            numeros[2] = 35;


            string[] familia = //Segunda forma de inicialização
            { 
                "Edu",
                "Marta",
                "Clara",
                "Julia"

            };
            #endregion

            #region Matrizes
            int[,] nums = new int[2, 3];

            nums[0, 0] = 10;
            nums[0, 1] = 20;
            nums[0, 2] = 30;            
            nums[1, 0] = 40;
            nums[1, 1] = 50;
            nums[1, 2] = 60;     

            Console.Write("["+nums[0, 0]+"]");
            Console.Write("["+nums[0, 1]+"]");
            Console.Write("["+nums[0, 2]+"]");
            Console.WriteLine();
            Console.Write("["+nums[1, 0]+"]");
            Console.Write("["+nums[1, 1]+"]");
            Console.Write("["+nums[1, 2]+"]");
            Console.WriteLine();
            Console.WriteLine();

            string[,] bands =
            {
                {"Led", "Black Sabbath", "Deep Purple"},
                {"Iron Maiden", "Beatles", "Black Crowes"}
            };
            #endregion

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
