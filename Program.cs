using System;

namespace DesafiosVetoresMatrizes
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("=== Desafios Praticos com Vetores e Matrizes ===\n");
            while (true)
            {
                Console.WriteLine("Escolha um exercicio (1 a 30) ou 0 para sair:");
                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Por favor, informe um numero valido.\n");
                    continue;
                }

                if (opcao == 0)
                {
                    Console.WriteLine("Encerrando aplicacao. Ate mais!");
                    break;
                }

                try
                {
                    Exercises.Execute(opcao);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Numero de exercicio invalido. Tente novamente.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro ao executar o exercicio: {ex.Message}\n");
                }
            }
        }
    }
}
