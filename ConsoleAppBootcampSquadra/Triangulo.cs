using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    public class Triangulo : Forma
    {
        public Triangulo(double altura, double largura) : base(largura, altura) {
            
        }

        public override double CalcularArea()
        {
            return (largura * altura)/2;
        }
    }
}
