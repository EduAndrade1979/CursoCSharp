using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matemáticos
            double num1 = 15;
            double num2 = 2;
            // int result = num1 + num2;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);
            #endregion

            #region Precedencia Operadores
            
            double num3 = 100;
            double num4 = 10;
            double num5 = 5;
            double res = num3 + num4 * num5; // Prioridade é da mult.
            res = (num3 + num4) * num5; // Prioridade é das chaves
            res = (num3 + num4) * num5 / 2; // Prioridade das chaves, depois segue a sequencia
                                            //  da esq. para a dir.
            res = (num3 + num4) * (num5 / 3); // Prioridade das chaves, depois a mult. 

            // Console.WriteLine(res);
            #endregion

            #region Operadores de Incremento e Decremento
            // Operadores de incremento "++" acrescenta 1
            // Operadores de decremento "--" decrescenta 1

            double num6 = 12;
            num6++;
            num6--;
            ++num6;
            --num6;

            // Os operadores podem vir antes ou depois da variavel, porem, 
            // se utilizados depois, dentro do console.writeline, a variavel sera 
            //exibida antes de o incremento ou decremento ocorrer.

            //Console.WriteLine(num6);
            #endregion

            #region Operador de Concatenação 
            string primeiroNome = "Hommer ";
            string sobreNome = "Simpson";
            string nomeCompleto = primeiroNome + sobreNome;

            //Console.WriteLine("Nome do cliente: " + nomeCompleto + " - 1985");
            #endregion

            #region Operador de Atribução

            double num7 = 10;

            // num7 = num7 + 20; Utilizando o operador de atribuição teremos o produto
            // num7 += 20;       do valor da variavel e o novo valor declarado.   
            // num7 -= 20;
            // num7 *= 20;
            // num7 /= 20;
            // num7 %= 20;

            string adicNome = "Jeff"; // Neste caso funciona como um operador de concatenação.
            adicNome += " Beck";
            #endregion

            #region Operadores de Igualdade
            bool resul = 100 == (80 + 4); // Neste caso o == e o != funcionam como uma  
                                        // verificação e a resposta será True ou False. 
            bool resul1 = (120 + 30) != (140 + 10);

            string meuNome = "Jonh";
            bool compNome = meuNome == "Petrucci";
            #endregion

            #region Operadores Relacionais
            //bool res1 = 100 < 80;
            //bool res1 = 100 > 80;
            //bool res1 = 100 <= 80;
            //bool res1 = 100 >= 80;
            #endregion

            #region Operadores Logicos
            bool res2 = 1250 > 210;
            bool res3 = 310 < 50;

            
            bool tot = res2 && res3; // Operador 'AND'. Para tot receber TRUE as duas 
                                     // variaveis precisam ser TRUE. 
            
            bool tot1 = res2 || res3; // Operador 'OU'. Somente uma das duas 
                                      // variaveis precisa ser TRUE.

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
