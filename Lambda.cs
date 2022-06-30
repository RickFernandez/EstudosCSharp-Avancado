/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class Lambda
    {
        static void Main(string[] args)
        {
            // Action - Tipo de função sem retorno
            Action apresentaConsole = () =>
            {
                Console.WriteLine("Action - Tipo de função sem retorno");
            };

            apresentaConsole();

            // Func - Tipo de função com retorno
            Func<int> sorteio = () =>
            {
                Random random = new Random();
                return random.Next(1, 10);
            };

            Console.WriteLine(sorteio());
        }
    }
}
*/