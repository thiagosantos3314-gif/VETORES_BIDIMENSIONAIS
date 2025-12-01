using System;

namespace VETORES_BIDIMENSIONAIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolver um progrma que simule uma agenda de cadastro
            // pessoal com nome, CPF, bairro, e tres pessoas

            string[,] agenda;
            int i;
            agenda = new string[3,3];
            Console.WriteLine("cadastro de");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"\npessoa {i + 1}");
                Console.WriteLine("nome: ");
                agenda[i, 0] = Console.ReadLine();

                Console.WriteLine("CPF: ");
                agenda[i, 1] = Console.ReadLine();

                Console.WriteLine("BAIRRO: ");
                agenda[i, 2] = Console.ReadLine();

            }

            Console.WriteLine($"\n==== Lista de pessoas ===");
            for (i = 0;i < 3; i++)
            {
                Console.WriteLine($"\n{i + 1} pessoa");
                Console.WriteLine($"nome: {agenda[i, 1]}");
                Console.WriteLine($"bairro: {agenda[i, 2]}");
            
            } */

            string[,] tabela;
            int i;
            tabela = new string[3, 4];

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"\n VEICULO: {i + 1}");
                Console.WriteLine("PLACA: ");
                tabela[i, 0] = Console.ReadLine();

                Console.WriteLine("MODELO: ");
                tabela[i, 1] = Console.ReadLine();

                Console.WriteLine("ANO: ");
                tabela[i, 2] = Console.ReadLine();

                Console.WriteLine("VALOR DA DIARIA");
                tabela[i, 3] = Console.ReadLine();

            }

            Console.WriteLine($"\n==== DOS VEICULOS  ===");
            for (i = 0; i < 3; i++)
            {
                
                Console.WriteLine($"PLACA: {tabela[i,0]}"); 
                Console.WriteLine($"MODELO: {tabela[i,1]}");
                Console.WriteLine($"ANO:  {tabela[i, 2]}");
                Console.WriteLine($"VALOR DA DIARIA {tabela[i, 3]}");
            }

        }

    }
}
