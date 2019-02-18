using System;
using tabuleiro;
using xadrez;

namespace tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while(!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem:"); //.toPosicao() para converter a matriz a nivel de sistema
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao(); //esse método irá ler do teclado uma posicao do Xadrez
                    Console.Write("Destino:");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao(); //esse método irá ler do teclado uma posicao do Xadrez
                    // depois que o usuario leu a origem e o destino:
                    partida.executaMovimento(origem, destino);
                }                           
                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}