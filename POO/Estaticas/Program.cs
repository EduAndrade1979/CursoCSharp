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
            #region Classe Estática
            //// Matematica m = new Matematica();  => // NÃO É POSSIVEL CRIAR UM OBJETO 
            //// A PARTIR DE UMA CLASSE ESTÁTICA.

            //Matematica.taxa = 10;  // Para acesar os membros, apenas referencia-se o nome da classe.
            //                       // Como a classe está sendo referenciada, uma vez que TAXA recebesse
            //                       // outro valor, qualquer lugar da aplicação que referenciasse a classe
            //                       // teria seu valor alterado imediatamente.
            //                       // STATIC => Costuma ser utilizado para configurações que sejam globais

            //int valor1 = Matematica.adicionar(200);
            //int valor2 = Matematica.diminuir(200);

            //Console.WriteLine("Valor 1 = " + valor1);
            //Console.WriteLine("Valor 2 = " + valor2);
            #endregion

            Pessoa.maioridade = 21; // Membros estaticos são acessados diretamente da classe

            Pessoa p1 = new Pessoa(); 
            p1.nome = "Jeff Porcaro"; // Membros não estáticos são acessados através da instanciação do objeto
            p1.idade = Pessoa.CalcularIdade(1956);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);

            p1.apresentar();


            Console.ReadKey();
        }
    }
}
