using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        
        enum Notas
        {
            Minima = 0,
            Media = 5,
            Maxima = 10
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

       
        
        static void Main(string[] args)
        {
            /* 
               VARIAVEIS SÃO ESPAÇOS RESERVADOS NA MEMÓRIA DO COMPUTADOR 
               PARA ARMAZENAR DADOS DURANTE A EXECUÇÃO DO PROGRAMA.
            */

            #region Numericas Integrais
            //// Integral assinado

            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, –32.768 a 32.767
            //int num3 = 30; // 32 bits, –2.147.483.648 a 2.147.483.647
            //long num4 = 40L; // 64 bits, –9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //// Integral sem sinal

            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30;  // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;         

            //sbyte num1 = 25;            

            //sbyte numero;

            //numero = 100; // Atribuição de valor real

            //numero = 123; // Atribuição de valor real

            //numero = num1; // Atribuição por referência
            #endregion

            #region Numeros Reais
            //float real1 = 100.75f; // 32 bits, intervalo dde 1,5 x 10-45 a 3,4 x 1038, 
            //                       // precisão de 7 dígitos, necessita sufixo f., Ex.: 10.5f

            //double real2 = 12500.45; // 64 bits, de 5,0 × 10-324 a 1,7 × 10308, 
            //                         // precisão de 15 dígitos => Sufixo d (opcional), Ex.: 10.5d

            //decimal real3 = 752538.457m; // 128 bits, intervalo de pelos menos –7,9 × 10-28 a 7,9 × 1028, 
            //                             // com precisão de pelo menos 28 dígitos => Sufixo m, Ex.: 10.5m

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            char letra = '\u0041'; // O código representa um único caracter: Ex => (A)
            char escape = '\n'; // O codigo representa caracter de escape: Ex => (Quebra de linha)
            char literal = 'C'; // Declaração do caracter de forma literal: Ex => (C)
            #endregion

            # region Boolean
            bool verificar = false;
            verificar = true;
            #endregion

            #region string (Cadeia de caracteres)
            string texto = @"Edu Andrade\n 17/01/1979\n ... "; // A @ no inicio anula o caracter de escape (\n)
            string mensagem = null;
            mensagem = texto;
            #endregion

            #region Tipo implícito Var
            var valor = 120; // O tipo var não tem tipo definido até que recebe um valor
                             // e a partir de então não pode ser alterado
            valor = 250;
            // valor = "Oi"
            #endregion

            #region Tipo Object (Base para todos os tipos)
            // Variavel da qual todas as outras variáveis herdam. É base para todos os outros tipos no C#.
            // Por isso pode receber qualquer tipo de dado.

            object obj = 500;
            obj = false;
            obj = "Hello!";
            #endregion

            #region Constantes
            // O valor recebido na declaração nao poderá ser alterado

            const double pi = 3.1415;
            const string nome = "Irmão do Jorel";
            //nome = "Jorel"; (ERR)
            #endregion

            #region Enumeração
            // Enum que está na linha 12, deve vir antes do MAIN para que contemple todo o código
            Notas notaAlunos = Notas.Media;
            #endregion

            #region Estruturas (Struct)
            Pessoa p1 = new Pessoa();
            p1.nome = "Dio";
            p1.idade = 56;
            p1.altura = 1.67;

            Pessoa p2 = new Pessoa()
            {
                nome = "Jonas",
                idade = 46,
                altura = 1.80
            };

            p1.nome = "Joseph";
            #endregion



            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}
