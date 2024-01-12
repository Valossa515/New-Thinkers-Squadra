using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    internal interface IEmail
    {
        public void SendEmail(string email);
        public string EnviarNotificacao(string message);

    }
}
