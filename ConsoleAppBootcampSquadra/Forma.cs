using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    public abstract class Forma
    {
        public double largura { get; set; }
        public double altura { get; set; }

        public Forma()
        {
        }

        public Forma(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public abstract double CalcularArea();
    }
}
