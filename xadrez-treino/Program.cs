using System;
using tabuleiro;
using xadrez;

namespace xadrez_treino
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadKey();
        }
    }
}   
