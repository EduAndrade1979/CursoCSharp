using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        public Pessoa() // Metodo Construtor: SEMPRE PUBLIC, SEM RETORNO, 
                        // LEVA O NOME DA CLASSE ONDE SERÁ UTILIZADO.
                        // Metodo Construtor é bastante utilizado para inicializar 
                        // um método quando ele ainda não recebeu valores, aplicando valores padrões.
                        // Constroi um objetro padrão a partir dos campos definidos na classe.
        {
            nome = "Desconhecido";
            sobrenome = "Nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        
    }   
    
}
