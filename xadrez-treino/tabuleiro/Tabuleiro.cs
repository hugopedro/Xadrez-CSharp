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

        //Sobrecarga do método Peca
        // Ao invés de receber linha e coluna separadamente ele irá receber uma Posicao pos
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        { // verificação se existe uma peça em determinada posição
            validarPosicao(pos); // chama o método para ver a a posição é válida, se der algum erro de validação de posição esse método será cortado e vai lançar uma exceção
            return peca(pos) != null; // se isso for verdade quer dizer que existe uma peça naquela posiçao
            // entao aqui ta verificando se existe a peça em determinado quadrado e se já tem alguma peça lá
        }
    
        public void colocarPeca(Peca p, Posicao pos)
        { // colocar uma peça significa ir lá na matriz de peças do tabuleiro, na posição
          //pos.linha e pos.coluna recebe a peça p, e alem disso deve-se ir na posição do tabuleiro
          // e dizer que agora está ocupada pela peça pos
            if (existePeca(pos)) // controle de verificação para saber se ja existe uma peça no tabuleiro
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)
        { 
            // verificando as posições, n pode ser menos q 0 e maior que 8, pq o tabuleiro é 8x8
            if (pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna>=colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        { // caso a posição nao seja válida ele vai lançar uma exceção personalizada    
            if (!posicaoValida(pos)) // se a posicao nao for valida(verificao do método acima)
            {
                throw new TabuleiroException("Posicao Invalida!");
            }
        }
    }
}
