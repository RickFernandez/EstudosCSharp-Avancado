/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class StructClasse //Atribuição feita por valor, e não referência
    {
        public struct PontoS
        {
            public int x;
            public int y;
        }

        public class PontoC //Atribuição feita por referência
        {
            public int x;
            public int y;
        }

        public static void Main()
        {
            PontoS ponto = new PontoS { x = 5, y = 3};
            PontoS ponto2 = ponto;
            ponto.x = 3;

            Console.WriteLine("Ponto: {0}", ponto.x);
            Console.WriteLine("Ponto 2: {0}", ponto2.x);

            PontoC ponto3 = new PontoC { x = 5, y = 3 };
            PontoC ponto4 = ponto3;
            ponto3.x = 3;

            Console.WriteLine("Ponto 3: {0}", ponto3.x);
            Console.WriteLine("Ponto 4: {0}", ponto4.x);
        }
    }
}
*/