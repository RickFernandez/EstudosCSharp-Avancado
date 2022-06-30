/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class Professor
    {
        protected readonly float salarioMaximo; //Atributo 'readonly' não pode ser mmodificado
        float salarioAtual;

        public Professor(float salarioMaximo)
        {
            this.salarioMaximo = salarioMaximo;
        }

        protected float modificarSalario(float Modf)
        {
            float novoSalario = salarioAtual + Modf;

            if(novoSalario < 0)
            {
                salarioAtual = 0;
            } 
            else if(novoSalario > salarioMaximo)
            {
                salarioAtual = salarioMaximo;
            }
            else
            {
                salarioAtual = novoSalario;
            }
            return salarioAtual;
        }

        public float aumenaroSalario()
        {
            return modificarSalario(+500);
        }
    
        public float diminuirSalario()
        {
            return modificarSalario(-500);

        }

        public class Prof : Professor
        {
            public Prof() : base(1400)
            {

            }

        }

        public static void Main()
        {
            Console.WriteLine("Professor1: ");
            Prof prof1 = new Prof();
            prof1.salarioAtual = 800;
            Console.WriteLine(prof1.aumenaroSalario());
            Console.WriteLine(prof1.diminuirSalario());
        }
    }
}
*/