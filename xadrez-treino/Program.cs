﻿using System;
using tabuleiro;

namespace xadrez_treino
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            Console.ReadKey();
        }
    }
}   
