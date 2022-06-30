using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    public static class Extensao
    {
        public static double soma (this double n1, double n2) //Passa 'this' no parâmetro
        {
            return n1 + n2;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            double x = 3;

            Console.WriteLine(x.soma(7));
            Console.WriteLine(9.2.soma(7));
            //Por conta do this, pode-se passar variáveia ou valores diretamente
        }
    }
}
