using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class Delegate
    {
        // Faz referência para uma operação que receberá dois números do tipo 'double'
        delegate double binaryNumericOperation(double n1, double n2);
        class Program
        {
            class Calculadora
            {
                public static double max(double x, double y)
                {
                    if(x> y)
                    {
                        return x;
                    }
                    else
                    {
                        return y;
                    }
                }

                public static double soma(double x, double y)
                {
                    return x + y;
                }
            }

            static void Main(string[] args)
            {
                double a = 10;
                double b = 30;

                binaryNumericOperation operacao = Calculadora.soma;
                Console.WriteLine(operacao(a, b));

                binaryNumericOperation operacao2 = Calculadora.max;
                Console.WriteLine(operacao2(a, b));
            }

        }
    }
}
