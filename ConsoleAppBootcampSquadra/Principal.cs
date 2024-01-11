using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //Gato obj = new();
            //obj.Idade = 20;
            //obj.Nome = "Bob";
            //obj.Genero = "Maculino";

            //Console.WriteLine(obj.Idade);
            //Console.WriteLine(obj.Nome);
            //Console.WriteLine(obj.Genero);
            //obj.Arranhar();
            //obj.Comer();
            //obj.Dormir();

            //aula 4

            //Animal animal = new Animal();

            //int[] numeros = new int[2];
            //numeros[0] = 1;
            //numeros[1] = 2;

            //int[] numero = {1,2,3,4,5,6,7,8,9,10};

            // for (int i = 0; i < numero.Length; i++)
            //{
            // Console.WriteLine(numeros[i]); 
            // }

            //    Console.Write("Informe a quantidade de números: ");
            //    if (!int.TryParse(Console.ReadLine(), out int quantidadeNumeros) || quantidadeNumeros <= 0)
            //    {
            //        Console.WriteLine("Por favor, insira um número inteiro válido maior que zero.");
            //        return;
            //    }

            //    // Criação do array para armazenar os números
            //    int[] numeros = new int[quantidadeNumeros];

            //    // Solicita ao usuário que insira os números e os armazena no array
            //    for (int i = 0; i < quantidadeNumeros; i++)
            //    {
            //        Console.Write($"Informe o número {i + 1}: ");
            //        if (!int.TryParse(Console.ReadLine(), out numeros[i]))
            //        {
            //            Console.WriteLine("Por favor, insira um número inteiro válido.");
            //            i--; // Decrementa i para repetir a entrada do número inválido
            //        }
            //    }

            //    // Calcula a média dos números no array
            //    double media = CalcularMedia(numeros);

            //    // Exibe o resultado
            //    Console.WriteLine($"A média dos números é: {media}");
            //}

            //// Função para calcular a média dos números em um array
            //static double CalcularMedia(int[] numeros)
            //{
            //    if (numeros.Length == 0)
            //    {
            //        return 0; // Retorna 0 se o array estiver vazio para evitar divisão por zero
            //    }

            //    int soma = 0;

            //    // Soma todos os números no array
            //    foreach (int numero in numeros)
            //    {
            //        soma += numero;
            //    }

            //    // Calcula a média
            //    double media = (double)soma / numeros.Length;

            //    return media;
            //}

            //List<string> nomes = new List<string>();
            //nomes.Add("Felipe");
            //nomes.Add("Natalia");
            //nomes.Add("Mateus");
            //nomes.Add("Nice");
            //nomes.Add("Danilo");


            ////nomes.Remove(3);
            ////nomes.RemoveAt(3);
            //nomes.AddRange(new List<string> {"Pedro", "Ana" });
            //nomes.Insert(0, "Sergio");
            //bool existe = nomes.Contains("Felipe");
            //int ocorrencia = nomes.IndexOf("Natalia");
            //nomes.Sort();
            //Console.WriteLine(nomes.Count);

            //foreach (string i in nomes)
            //{
            //    Console.WriteLine("Itens da lista: " + i);
            //}

            //List<int> numeros = new List<int>();

            //numeros.Add(1);
            //numeros.Add(8);
            //numeros.Add(27);
            //numeros.Add(4);
            //numeros.Add(12);

            //numeros.Sort();

            //foreach (int i in numeros)
            //{
                //Console.WriteLine("Itens da lista: " + i);
            //}
        }
    }
}
