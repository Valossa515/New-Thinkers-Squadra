using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Genero {  get; set; }
        public int Idade { get; set; }


        public Animal() { 
        
        }

        public void Comer()
        {
            Console.WriteLine("O animal esta comendo!");
        }

        public void Dormir()
        {
            Console.WriteLine("O animal esta dormindo!");
        }


    }
}
