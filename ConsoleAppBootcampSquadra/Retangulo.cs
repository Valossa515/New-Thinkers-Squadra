using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    public class Retangulo : Forma
    {
        public Retangulo(double largura, double altura) : base(largura, altura) {

        }

        public override double CalcularArea()
        {
            return largura * altura;
        }
    }
}
