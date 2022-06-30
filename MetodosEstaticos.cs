using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class MetodosEstaticos //Não necessita da insância de um objeto para serem chamados
    {
        public static int somar(int x, int y)
        {
            return x + y;
        }

        public int multiplicar(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"A soma dos números é: {MetodosEstaticos.somar(3, 3)}");

            MetodosEstaticos calc = new MetodosEstaticos();
            Console.WriteLine($"A multiplicação dos números é: {calc.multiplicar(3, 3)}");
        }
    }
}
