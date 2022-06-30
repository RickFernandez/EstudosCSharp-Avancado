/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class ParametrosVariaveis
    {
        // 'params' faz com que seja possível atribuir diversos parâmetros aos métodos, criando um Array
        public static void Despedida(params string[] alunos) 
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine("Tchau {0}, até a próxima aula!", aluno);
            }
        }

        static void Main(string[] args)
        {
            Despedida("Rick", "Luiz", "Gabriel");
        }
    }
}
*/