using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcampSquadra
{
    class Principal
    {
        public static void Main(string[] args)
        {
            //Aula1

            //Console.WriteLine("Digite um numero: ");
            ////int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("O numero digitado é: " + numero);
            //Console.WriteLine();

            //Aula2
            /*
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
            */

            // Aula 3

            //double numero = 10.5;
            // int numeroInteiro = (int)numero;

            // Console.WriteLine(numeroInteiro);

            //string numeroTexto = "123";
            //int numeroConvertido;

            // numeroConvertido = int.Parse(numeroTexto);

            //Convert

            // Aluno aluno = new();
            //Console.WriteLine("Digite um numero: ");
            // int idadePermitida = int.Parse(Console.ReadLine());
            //aluno.idade = idadePermitida;
            // bool ehEstudante = true;
            // bool podePagar = false;
            // bool estaChovendo = false;
            // int contador = 0;

            //string[] fruta = { "Maçã", "Morango", "Banana", "Melancia", "Uva" };

            //if (idadePermitida >= 18)
            // {
            // Console.WriteLine("Maior de idade");
            // }
            //else
            // {
            //  Console.WriteLine("Menor de idade");
            //  }

            // if(idadePermitida % 2 == 0)
            // {
            //     Console.WriteLine("O numero é par");
            //}
            //else
            //{
            //Console.WriteLine("O numero é impar");
            // }

            //string ternario = (idadePermitida % 2 == 0) ? "Par" : "Impar";


            // if (idadePermitida >= 18 && ehEstudante)
            // {
            //     // Console.WriteLine("Pode ingressar na faculdade");
            // }
            // else
            //{
            //Console.WriteLine("Não pode ingressar na faculdade");
            // }

            // if (idadePermitida >= 18 || ehEstudante || podePagar)
            //   {
            //   Console.WriteLine("Pode ingressar na faculdade");
            //  }
            //  else
            //  {
            //Console.WriteLine("Não pode ingressar na faculdade");
            // }

            //if (!estaChovendo)
            //{
            //  Console.WriteLine("Não esta chovendo, pode sair sem guarda-chuva");
            // }
            // else
            //  {
            //Console.WriteLine("Está chovendo, leve seu garda-chuva");
            //  }

            //while(contador <5)
            //{
            //Console.WriteLine("Contagem: " + contador);
            //contador++;
            //}

            //do
            //{
            //Console.WriteLine("Contagem: " + contador);
            //contador++;
            //} while (contador < 5);

            //for(int i = 0; i < 5; i++)
            // {
            //if(i == 2)
            // {
            // break;
            //  }
            // Console.WriteLine("Contagem: " + i);
            // }


            //foreach(var x in fruta) { 
            //Console.WriteLine(x);
            //}


            //Aluno aluno = new();

            //Console.WriteLine("Digite sua idade: ");
            //int idadePermitida = int.Parse(Console.ReadLine());

            //Console.WriteLine("É um membro premium? (Digite 'sim' ou 'não'): ");
            //string respostaPremium = Console.ReadLine().ToLower();
            //bool ehpremium = respostaPremium == "sim" || respostaPremium == "s";

            //aluno.idade = idadePermitida;
            // aluno.ehpremium = ehpremium;

            //if (aluno.idade >= 18 && aluno.ehpremium)
            //{
            //Console.WriteLine("Pode acessar");
            // }
            //else
            //{
            //Console.WriteLine("Não Pode Acessar");
            // }

            //for(int i = 0; i <= 100; i++) { 
            //if(i %2 == 0) {
            // Console.WriteLine("Numero: " + i);

            //}

            //List<Animal> animals = new List<Animal>();

            Gato obj = new();
            obj.Idade = 20;
            obj.Nome = "Bob";
            obj.Genero = "Maculino";

            Console.WriteLine(obj.Idade);
            Console.WriteLine(obj.Nome);
            Console.WriteLine(obj.Genero);
            obj.Arranhar();
            obj.Comer();
            obj.Dormir();



        }
    }
}
