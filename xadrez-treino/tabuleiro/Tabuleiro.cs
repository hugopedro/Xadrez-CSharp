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
    }
}
