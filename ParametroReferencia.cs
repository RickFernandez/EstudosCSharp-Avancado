using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class ParametroReferencia
    {
        public static void alterarRef(ref int num)
        {
            num += 500;
        }

        public static void alterarOut(int num)
        {
            num = 0;
            num += 50;
        }

        public static void Main()
        {
            int x = 5;
            alterarRef(ref x);
            Console.WriteLine(x);
            
            int y = 8;
            alterarOut(y);
            Console.WriteLine(y);
        }
    }
}
