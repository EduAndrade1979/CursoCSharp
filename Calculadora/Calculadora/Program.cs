using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  >>> CALCULADORA <<<");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            double priNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("escolha a operação desejada ([+], [-], [x], [/]): ");
            string oper = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o segundo número: ");
            double segNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double resultado = 0;

            switch (oper)
            {
                default:
                    Console.WriteLine("Opção Inválida. Utilize apenas ([+], [-], [x], [/]): ");
                    Console.Write("Escolha a operação desejada ([+], [-], [x], [/]): ");
                    oper = Console.ReadLine();
                    goto inicio;                    ;
                case "+":
                    resultado = priNum + segNum;
                    break;
                case "-":
                    resultado = priNum - segNum;
                    break;
                case "x":
                    resultado = priNum * segNum;
                    break;
                case "/":
                    if (segNum == 0)
                    {
                        Console.WriteLine("Opção invalida, não é possivel dividir por 0.");
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para retornar ao início...");
                        Console.ReadKey();
                        goto inicio;
                    }
                    resultado = priNum / segNum;
                    break;

            }
            Console.WriteLine("Resposta => " +  " " + priNum + " " + oper + " " + segNum + " = " + resultado);
            Console.WriteLine();
            Console.WriteLine();
        inicio2:
            Console.Write("Deseja continuar? [S] ou [N]: ");
            string continua = Console.ReadLine();

            if (continua == "s")
            {
                continua = "S";
            }
            else if (continua == "n")
            {
                continua = "N";
            }


            Console.WriteLine();
            Console.WriteLine();


            switch (continua)
            {
                default:
                    Console.WriteLine("Opção invalida, utilize [S] ou [N] ");
                    Console.WriteLine();
                    goto inicio2;                   
                
                case "S":
                    Console.Clear();
                    goto inicio;                        
                    
                case "N":
                    Console.Write("FIM DA EXECUÇÃO");
                    break;
            }

            Console.ReadLine();          


        }
    }
}
