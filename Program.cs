using System;

namespace StatusVotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Agora digite seu ano de nascimento: ");
            int AnoNasc = int.Parse(Console.ReadLine());
            int AnoAtual = 2021;
            int idade = AnoAtual - AnoNasc;

            if (idade < 16)
            {
                Console.WriteLine("Voce ainda  não vota.");
            }
            else if (idade >= 16 && idade > 70)
            {
                Console.WriteLine("Seu voto é opcional");
            }
            if (idade >= 18 && idade <= 70)
            {
                Console.WriteLine("O seu voto é obrigatório.");
            }

            Console.WriteLine($"Sua idade é {idade}");
            Console.ReadKey();
        }
    }
    }

