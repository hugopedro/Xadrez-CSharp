namespace tabuleiro {
    class Tabuleiro {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // o tabuleiro tem uma matriz de peças

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }
        // método pras peças poderem acessar as linhas e colunas
        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }
        // métodos pras peças poderem ir à determinada posição
        public Peca peca(Posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }
        // método que verifica se a peça existe em certa posição
        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) { // ou seja colocar uma peça p na posicao pos
            if (existePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p; // jogando a peça p na matriz na posição da linha e coluna especifica
            p.posicao = pos; // ir lá na peça p e afirmar que agora a posição dela é pos
        }

        public Peca retirarPeca(Posicao pos) {
            if (peca(pos) == null) {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }
        // método que verifica s
        public bool posicaoValida(Posicao pos) {
            if (pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna>=colunas) {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
