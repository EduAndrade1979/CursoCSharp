using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = 0, altura = 0, resultado = 0;
            
            Console.WriteLine(">>> CALCULE SEU IMC <<<");
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite seu peso em (Kg): ");
            peso =  double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite sua altura em (M): ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            resultado = peso / (altura * altura);
            
            if (resultado < 18.5)
            {
                Console.WriteLine("O resultado do seu IMC é " + resultado + " => Você está magro(a).");
            }
            else if ((resultado >= 18.5) && (resultado <= 24.9))
            {
                Console.WriteLine("O resultado do seu IMC é " + resultado + " => Você está no peso ideal.");
            }
            else if ((resultado > 24.9) && (resultado <= 29.9))
            {
                Console.WriteLine("O resultado do seu IMC é " + resultado + " => Você está com sobrepeso.");
            }
            else if (resultado > 29.9) 
            {
                Console.WriteLine("O resultado do seu IMC é " + resultado + " => Você está obeso(a).");
            }            
            Console.ReadKey();
        }
    }
}
