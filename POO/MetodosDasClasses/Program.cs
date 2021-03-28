using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Método Simples
            // m.Cumprimentar();
            #endregion

            #region Método com parâmetros
            //m.Somar(5, 9.5);
            //m.Apresentar("Marta", 49);
            #endregion

            #region Métodos: passagem de parametros por valor e por Referencia
            //double valor1 = 100;
            //double valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarValorRef(ref valor2);

            //Console.WriteLine("Valor1 = " + valor1);
            //Console.WriteLine("Valor2 = " + valor2);
            #endregion

            string nomeCompleto = m.MontaNome("Marta", "Andrade");
            int cod = m.CodigoChar('a');
            double pi = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(cod);
            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}
