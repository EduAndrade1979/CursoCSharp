using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Metodos
    {
        // Método simples => Não retorna nada (VOID) e não tem parâmetros (PARENTESES VAZIOS).
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo!");
        }

        //_____________________________________________________________________________________
        
        // Métodos com parâmetros
        public void Somar(double num1, double num2)
        {
            double resultado = num1 + num2;

            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
        }

        //_____________________________________________________________________________________        


        // Passagem de parâmetros por valor...Neste caso o valor original da variavel passada
                                              // como parametro não é alterada.

        public void AumentarValor(double valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por valor) é: " + valor);
        }

        // Passagem de parâmetros por referencia.... Neste caso o valor original da variavel passada
                                                  // como parametro é alterada.         

        public void  AumentarValorRef(ref double valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por ref) é: " + valor);

        }

        //_____________________________________________________________________________________


        // Métodos com retorno de valores

        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + " " + sobrenome; => Sintaxe possivel ou ...
            
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            // int codigo = (int)caractere; => Como o retorno é definido como int, a conversão é implicita.
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }
    }
}
