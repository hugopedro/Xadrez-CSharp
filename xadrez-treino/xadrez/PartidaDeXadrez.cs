using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    { // o que uma partida de xadrez tem:
        public Tabuleiro tab {get; private set;}
        private int turno;
        private Cor jogadorAtual;
        public bool terminada {get; private set;} // indica se a partida está terminada ou não
                                                  //{get; private set;} significa acesso apenas leitura

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false; //a partida começa sendo que nao está terminada
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem); // tira a peça da origem pq vai movimentar
            p.incrementarQteMovimentos(); //a peça mexeu
            Peca pecaCapturada = tab.retirarPeca(destino); // tira a peça do destino caso exista, se a peça foi capturada por isso o pecaCapturada
            tab.colocarPeca(p, destino); // coloca a peça no destino
        }

        private void colocarPecas()
        {                           // aqui poe na posição na visão do usuário, depois converte para a posição na visão de matriz
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());

        }
    }
}
