namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; } 
        public int colunas { get; set; }
        // o jogo de xadrez tambem terá uma matriz de peças
        private Peca[,] pecas; //private pq nao pode ser acessados por alguem de fora

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; // Instanciando a matriz de peças
            // as peças irão receber uma nova matriz de peças que vai receber as linhas e colunas
            //passadas no argumento, portanto não entra diretamente no argumento
        }

        // método para usar no tabuleiro para colocar a peça no tabuleiro, (encapsulamento)
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        { // colocar uma peça significa ir lá na matriz de peças do tabuleiro, na posição
            //pos.linha e pos.coluna recebe a peça p, e alem disso deve-se ir na posição do tabuleiro
            // e dizer que agora está ocupada pela peça pos
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
