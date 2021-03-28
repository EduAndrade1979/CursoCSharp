using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            // Classes representam tipos que recebem objetos com 
            // atributos (dados) e metodos (comportamentos).

            MinhaClasse mClasse = new MinhaClasse(); // Novo objeto do tipo MinhaClasse
            MinhaClasse mClasse2 = null; // Objeto instanciado mas nao inicializado

            OutraClasse Outra = new OutraClasse();
            OutraClasse Outra2 = Outra; // Objeto pode receber a referencia de outro objeto.
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Julia";
            p1.sobrenome = "Andrade";
            p1.anoNascimento = 2011;

            Pessoa p2 = new Pessoa() // O uso das chaves indica que está dentro do escopo,
                                     // por isso não é necessário referenciar "p2."               
            {
                nome = "Clara",
                sobrenome = "Andrade",
                anoNascimento = 2004                
            };

            p1.sobrenome = "Candido Andrade"; // Basta refenciar p1 para alterar o valor recebido.

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
            p1.cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
            p2.cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
    
}
