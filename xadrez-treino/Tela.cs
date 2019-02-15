using System;
using tabuleiro;

namespace xadrez_treino
{
    class Tela
    {
        //Começando a implementar um método que imprime o tabuleiro
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i =0; i<tab.linhas; i++)
            {
                for (int j=0; j<tab.colunas; j++)
                { // se a peça na posicao i,j for nula nao tem peça, entao imprimo o Tracinho - 
                    if (tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
