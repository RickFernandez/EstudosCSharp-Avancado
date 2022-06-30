using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class Enums
    {
        public enum Genero { Filme, Serie, Documentario };

        public class Filme
        {
            public string nome;
            public Genero genero;
        }

        static void Main()
        {
            int cod = (int)Genero.Serie;
            Console.WriteLine(cod);
        }
    }
}
