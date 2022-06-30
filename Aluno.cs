using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class Aluno
    {
        public String nome;
        public int idade;
        public int serie;

        public String Apresentacao()
        {
            return String.Format($"O aluno {nome} tem {idade} anos e está na {serie} série da escola");
        }

        public void ApresentacaoConsole()
        {
            Console.WriteLine(Apresentacao());
        }

        static void Main(String[] args)
        {
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Rick";
            aluno1.idade = 13;
            aluno1.serie = 6;
            aluno1.ApresentacaoConsole();
        }
    }
}
