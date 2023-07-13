//See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;
using System.ComponentModel.Design;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das funções");
            Console.WriteLine("O teste 1 realiza um cálculo de média");
            Console.WriteLine("O teste 2 realiza um cálculo de média para uma quantidade x de provas");
            Console.WriteLine("O teste 3 permite a inserção de cada aluno e o cálculo das médias individuais");
            Console.WriteLine("Cada teste corresponde ao valor de seu número, ex: teste1 = 1, teste2 = 2");
            string escolha = Console.ReadLine();
            int valor = Convert.ToInt32(escolha);
            switch (valor)
            {
                case 1:
                    teste1();
                    break;
                case 2:
                    teste2();
                    break;
                case 3:
                    teste3();
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Encerrando o programa.");
                    break;

            }


            static void teste1()
            {
                Console.WriteLine("Insira a nota do primeiro semestre:");
                string nota1 = Console.ReadLine();
                int primeiroSemestre = Convert.ToInt32(nota1);

                Console.WriteLine("Insira a nota do segundo semestre:");
                string nota2 = Console.ReadLine();
                int segundoSemestre = Convert.ToInt32(nota2);

                // cálculo da média
                double media = (primeiroSemestre + segundoSemestre) / 2.0;

                Console.WriteLine("A média é: " + media);
            }


            static void teste2()
            {
                Console.WriteLine("olá, qual é seu nome");
                String aluno = Console.ReadLine();
                
                Console.WriteLine("Olá, insira a quantidade de provas realizadas :)");
                int qtdeNotas = int.Parse(Console.ReadLine());

                double soma = 0;

                //estrutura de repetição para receber e calcular todas as notas
                    

                for (int i =1; i<=qtdeNotas; i++)
                {
                    Console.WriteLine("Insira suas notas: ");
                    double nota = double.Parse(Console.ReadLine());
                    soma += nota;
                }


                double media = soma / qtdeNotas;
                    Console.WriteLine(aluno +"sua nota total foi:"+ soma + "e sua media é:" + media);                    
                }
            }



            static void teste3()
            {
            Console.WriteLine("Cálculo de médias de alunos");
            Console.WriteLine("Se quiser finalizar a operação digite 'fim' na opção 'insira o nome do aluno'");

            while (true)
            {
                Console.WriteLine("insira o nome do aluno");
                String aluno = Console.ReadLine();

                //término do programa em caso de fim
                if(aluno.ToLower() == "fim")
                {
                    break;
                }

                Console.WriteLine($"Insira a nota do primeiro semestre do {aluno}:");
                int nota1 = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"Insira a nota do segundo semestre do {aluno}:");
                int nota2 = int.Parse(Console.ReadLine());

                int media = (nota1 + nota2) / 2;
                if (media >= 6.5)
                {
                    Console.WriteLine($"Média do aluno {aluno}: {media}");
                    Console.WriteLine($"{aluno} aprovado");
                }
                else
                {
                    Console.WriteLine($"Média do aluno {aluno}: {media}");
                    Console.WriteLine($"{aluno} reprovado");
                }
                    Console.WriteLine();

            };
            }
        }
    }

