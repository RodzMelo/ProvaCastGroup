using System;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicioDoPrograma:
            Console.Clear();

            string[] remedios = { "paracetamol", "dorflex", "neosaldina", "torsilax", "puran", "neosoro", "sorine" };

            Console.WriteLine($"\nEscreva o nome do remédio que deseja comprar, temos a venda as opções abaixo:\n\n" +
                $"0-{remedios[0]}\n" +
                $"1-{remedios[1]}\n" +
                $"2-{remedios[2]}\n" +
                $"3-{remedios[3]}\n" +
                $"4-{remedios[4]}\n" +
                $"5-{remedios[5]}\n" +
                $"6-{remedios[6]}\n");

            string RemedioEscolhido = Console.ReadLine();


            // Métodos que tiram espaços em branco e transformam todas as letras em minusculas.
            RemedioEscolhido = RemedioEscolhido.ToLower();
            RemedioEscolhido = RemedioEscolhido.Replace(" ", String.Empty);

            char escolha;

            while (true)
            {
                if (RemedioEscolhido == "paracetamol")
                    Console.WriteLine("\nVocê escolheu Paracetamol. Possuimos 5 em estoque!\n");

                else if (RemedioEscolhido == "dorflex")
                    Console.WriteLine("\nVocê escolheu Dorflex. Infelizmente nosso estoque acabou!\n");

                else if (RemedioEscolhido == "neosaldina")
                    Console.WriteLine("\nVocê escolheu Neosaldina. Possuimos 2 em estoque!\n");

                else if (RemedioEscolhido == "torsilax")
                    Console.WriteLine("\nVocê escolheu Torsilax. Possuimos 23 em estoque!\n");

                else if (RemedioEscolhido == "puran")
                    Console.WriteLine("\nVocê escolheu Puran. Infelizmente nosso estoque acabou!\n");

                else if (RemedioEscolhido == "neosoro")
                    Console.WriteLine("\nVocê escolheu Neosoro. Infelizmente nosso estoque acabou!\n");

                else if (RemedioEscolhido == "sorine")
                    Console.WriteLine("\nVocê escolheu Sorine. Possuimos 12 em estoque!\n");

                else
                    Console.WriteLine("\nEscolha um remédio que temos em estoque!\n");
                break;
            }

            Console.WriteLine("Deseja comprar novamente? [s / n]: ");
            escolha = char.Parse(Console.ReadLine());

            if (escolha == 's' || escolha == 'S')
            {
                goto inicioDoPrograma;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n******** FIM DAS COMPRAS! ********");
            }

        }


    }
}