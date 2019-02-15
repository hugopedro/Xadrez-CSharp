using System;
using tabuleiro;

//Essa classe é pra adaptar a posição do xadrez mais para a realidade.

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        
        public Posicao toPosicao()
        { //Aqui será convertido a posição do xadrez para uma posição interna de matriz
          //De acordo com a figura: file:///C:/Users/Hugo/Documents/C%23%20COMPLETO%202019%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos%20+%20Projetos/Projeto%20Xadrez/xadrez-console/xadrez-treino/Posicao%20xadrez.PNG
            return new Posicao(8 - linha, coluna - 'a');
            // esse coluna - a é porque na conversão.. exemplo: a-a = 0 , b -a = 1 , c - a = 2
            // ou seja,  de acordo com a figura, a posição da matriz (7,0) VIRA (1,A) 
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
