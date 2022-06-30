/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp_Avançado
{
    internal class Carro
    {
        private string nome;
        private string marca;
        private double potencia;

        public Carro(string nome, string marca, double potencia)
        {
            this.nome = nome;
            this.marca = marca;
            this.potencia = potencia;
        }

        public Carro() { }

        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public double getPotencia()
        {
            return potencia;
        }

        public void setPotencia(double potencia)
        {
            this.potencia = potencia;
        }

    }

    class Constructor
    {
        static void Main(String[] args)
        {
            var carro = new Carro();
            carro.setNome("Hilux");
            carro.setMarca("Toyota");
            carro.setPotencia(3.1);
            Console.WriteLine($"O {carro.getNome} da {carro.setMarca} tem {carro.getPotencia} de potência");

            var carro2 = new Carro("Celta", "Chevrolet", 1.0);
            Console.WriteLine($"O {carro2.getNome} da {carro2.getMarca} tem {carro2.getPotencia} de potência");
        }
        

    }
}
*/