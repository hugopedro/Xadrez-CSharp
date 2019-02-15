using System;
using tabuleiro;

namespace tabuleiro
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else // imprime a peça e depois um espaçinho em branco
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            { //aqui ele joga a cor cinza do console numa variavel de sistema aux
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow; //obriga a cor cinza do console virar amarelo
                Console.Write(peca); // escreve a peça amarela
                Console.ForegroundColor = aux; // devolve o valor cinza padrão novamente
            }
        }

    }
}