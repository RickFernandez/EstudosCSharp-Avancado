using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class Mensagem
    {
        private String texto;

        public void exibir()
        {
            Console.WriteLine(this.texto);
        }

        public String getTexto()
        {
            return this.texto;
        }

        public void setTexto(String texto)
        {
            this.texto = texto;
        }

        static void Main(string[] args)
        {
            Mensagem msg1, msg2;

            msg1 = new Mensagem();
            msg1.setTexto("Curso avançado de C#");
            msg1.exibir();
        }
    }
}
