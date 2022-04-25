using System;

namespace JogoDaAdivinhação
{
    class Advinhacao
    {

        static void Main(string[] args)
        {
            inicioDoPrograma:

            Console.Clear();


            int n, escolha = 0, cont = 0;

            Random segredo = new Random();

            char escolhaRepeticao;

            n = Convert.ToInt32(segredo.Next(1, 10));

            Console.WriteLine("\n**** Jogo da Adivinhação ****");
            Console.WriteLine("Adivinhe o número que eu pensei\n" +
            "(Dica: o número está entre 1 e 10): ");

            try
            {

                while (escolha != n)
                {

                    escolha = Convert.ToInt32(Console.ReadLine());

                    if (escolha > n)

                        Console.WriteLine("Errado. O número é menor.");

                    else if (escolha < n)

                        Console.WriteLine("Errado. O número é maior.");

                    else if (escolha == n && cont == 0)

                        Console.WriteLine("Incrível! Você acertou na primeira!\n");
                    else

                        Console.WriteLine("***** Acertou! " + n + " é o número! *****\n");

                    cont++;
                }

                Console.WriteLine("Deseja jogar novamente? [s / n]: ");
            }

            catch
            {
                Console.WriteLine("Sinto muito, você perdeu.\n" +
                "Não deixe em branco e digite apenas números!!!");
            }

            escolhaRepeticao = char.Parse(Console.ReadLine());

            if (escolhaRepeticao == 's' || escolhaRepeticao == 'S')
            {
                goto inicioDoPrograma;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n******** FIM DA PARTIDA! ********");
            }

        }
    }
}
