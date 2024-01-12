using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    public class Caixa<T>
    {
        private T conteudo { get; set; }
        public Caixa(T conteudo)
        {
            this.conteudo = conteudo;
        }

        public T ObterConteudo()
        {
            return conteudo;
        }
    }
}
