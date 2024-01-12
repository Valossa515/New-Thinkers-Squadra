using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    public class Circulo : Forma
    {
        public Circulo(double raio) : base(raio, raio) {
            
        }

        public override double CalcularArea()
        {
            return Math.PI * largura * altura;
        }
    }
}
