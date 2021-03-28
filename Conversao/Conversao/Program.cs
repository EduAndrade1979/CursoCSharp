using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversao implícita
            // A conversão implicita acontece porque um tipo é suportado pelo outro.

            byte num1 = 100; // 8 bits, de 0 a 255
            ushort num2; // 16 bits, de 0 a 65.535

            num2 = num1;

            float num3 = 1250.65f;
            double num4 = num3; // Como se trata de abrangencia, o inverso nao é possível!

            num3 = num1;
            num4 = num2;

            int numero = 'W'; // Será impresso o numero (código) referente ao caracter.
            #endregion

            #region Conversao explícita
            ushort num5 = 150;              // Neste caso pode ocorrer perda de dados
            byte num6 = (byte)num5;         // porque a coversao é realizada 
                                            // mas nao evita a perda!

            float num7 = 2500.73f;    // A conversao ocorre, porem, se usar decimais, há perda.
            int num8 = (int)num7;

            char letra1 = (char)98; // Tipo char não aceita um numero como valor.
            #endregion

            #region Método Parse
            string txtNumero = "90";

            int numeroTxt = int.Parse(txtNumero);

            byte num9 = byte.Parse("127");

            double num10 = double.Parse("10,9"); // Usa-se virgula porque se trata de uma 
                                                 // representação e não um valor literal.

            float num11 = float.Parse("219,78"); // Representação, por isso descarta-se o 'f'.
            #endregion

            #region Classe Convert
            int numberToString = 256;
            string text = Convert.ToString(numberToString); // Poderia ser passado 
                                                            // como valor literal.

            double stringToDouble = Convert.ToDouble("750");
            #endregion

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
