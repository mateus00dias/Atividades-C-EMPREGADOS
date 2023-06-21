using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeIdade
{
    internal class Funcionario
    {
        private String nome;
        private int idade;


        public Funcionario()
        {
            idade = 0;
            nome = " ";
        }

        public Funcionario(String nome, int idade)
        {
            this.nome = nome;  
            this.idade = idade;
        }

        public int Idade { get => idade; set => idade = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
