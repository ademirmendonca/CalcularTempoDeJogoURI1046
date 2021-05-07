using System;

namespace CalcularTempoDeJogoURI1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int inicio, fim;
            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            if (inicio > fim)
            {
                Console.WriteLine("O JOGO DUROU " + (( fim + 24) - inicio ) + " HORA(S)");
            }

            else if (inicio < fim)
            {
                Console.WriteLine("O JOGO DUROU " + Math.Abs(inicio - fim) + " HORA(S)");
            }

            else if (inicio == fim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }

        }
    }
}
