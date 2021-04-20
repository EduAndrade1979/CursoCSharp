using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matematica m = new Matematica();  => // NÃO É POSSIVEL CRIAR UM OBJETO 
                                                    // A PARTIR DE UMA CLASSE ESTÁTICA.

            Matematica.taxa = 10;  // Para acesar os membros, apenas referencia-se o nome da classe.
                                   // Como a classe está sendo referenciada, uma vez que TAXA recebesse
                                   // outro valor, qualquer lugar da aplicação que referenciasse a classe
                                   // teria seu valor alterado imediatamente.
                                   // STATIC => Costuma ser utilizado para configurações que sejam globais

            int valor1 = Matematica.adicionar(200);
            int valor2 = Matematica.diminuir(200);

            Console.WriteLine("Valor 1 = " + valor1);
            Console.WriteLine("Valor 2 = " + valor2);
            
            Console.ReadKey();
        }
    }
}
