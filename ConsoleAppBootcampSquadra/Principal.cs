using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    class Principal
    {
        static void Main()
        {
            //Aula1

            //Console.WriteLine("Digite um numero: ");
            ////int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("O numero digitado é: " + numero);
            //Console.WriteLine();

            //Aula2

            Aluno aluno = new();
            string nome;
            string sobrenome;
            nome = aluno.nome = "Felipe ";
            sobrenome = aluno.sobrenome = "Martins";
            string nomeCompleto = nome + " " + sobrenome;
            string nomeCompleto2 = string.Concat(nome, sobrenome);
            string nomeCompleto3 = $"{nome} {sobrenome}";
            string nomeCompleto4 = string.Format("{0} {1}", nome, sobrenome );
            string[] partes = { nome, sobrenome };
            string nomeCompleto5 = string.Join("", partes);

            StringBuilder sb = new StringBuilder();
            sb.Append(nome);
            sb.Append(" "); 
            sb.Append(sobrenome);

            string nomeCompleto6 = sb.ToString();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(nomeCompleto2);
            Console.WriteLine(nomeCompleto3);
            Console.WriteLine(nomeCompleto4);
            Console.WriteLine(nomeCompleto5);
            Console.WriteLine(nomeCompleto6);


            string token = "   dbacbuuwheu@6271287e6";
            string parte = token.Substring(7);
            Console.WriteLine(parte);
            Console.WriteLine(parte.ToUpper());
            Console.WriteLine(parte.ToLower());
            string modificado = token.Replace("@", "#");
            Console.WriteLine(modificado);

            string tiraEspaco = token.Trim();
            Console.WriteLine(tiraEspaco);

            string[] itens = token.Split(',');

            foreach (var s in itens)
            {
                Console.WriteLine(s);
            }

        }
    }
}
