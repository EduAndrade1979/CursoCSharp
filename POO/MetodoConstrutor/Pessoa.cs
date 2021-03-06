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

        public Pessoa(string nome, string sobrenome, int anoNascimento) 
            // Sobrecarga do método construtor, definindo assinatura
            // referenciando os campos da classe (THIS)
            
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            idade = Idade();
        }

        private int Idade()
        {
            return (2021 - anoNascimento);
        }

        public Pessoa(string nome, string sobrenome)        

        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = 2003;
            idade = Idade();
        }

    }   
    
}
