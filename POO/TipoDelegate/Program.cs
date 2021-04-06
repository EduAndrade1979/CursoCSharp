using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Program
    {
        // DELEGATE: TIPO DE OBJETO QUE VAI RECEBER ATRIBUIÇÕES DE MÉTODOS DESDE QUE UTILIZE 
        // O MESMO RETORNO E OS MESMOS PARAMETROS DOS MÉTODOS REFERENCIADOS.
        
        delegate void Operacao(int n1, int n2); // Deve ter o mesmo formato 
                                                //(retorno e parametros do metodo).

        static void Main(string[] args)
        {
            Matematica m = new Matematica(); // Referencia do metodo.

            Operacao conta = null; // Criação do objeto do tipo Operação para o qual 
                                   // serão delegados os métodos contidos na classe "Matematica" conforme 
                                   // a necessidade.

            conta += m.Somar; // Está sendo delegada ao objeto conta, 
                              // a atribuição (+=) do metodo Somar contido na classe Matematica.
                              // A partir daí o objeto se comportará conforme o método atribuido.

            conta += m.Subtrair;
            conta += m.Multiplicar;
            conta += m.Dividir;


            conta(10, 2); // Todos os métodos referenciados serão executados de uma só vez
            
            conta -= m.Dividir; // Retirada da atribuição do método Dividir!!

            conta(5, 3);


            Console.ReadKey();
        }
    }
}
