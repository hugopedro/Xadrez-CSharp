namespace tabuleiro
{
    class Peca
    {
        //Conceito de associação: Uma peça vai ter que estar numa posição
        public Posicao posicao { get; set; }
        //Conceito de associação: Uma peça vai ter que ter uma cor
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; } //protected set; significa que ela só pode ser alterada por ela mesmo e as subclasses
        //Conceito de associação: Uma peça vai ter que estar em um tabuleiro
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
            //A quantidade de movimentos nao foi um argumento e inicializa com 0 porque
            // obviamente no inicio do jogo, quando a peça acaba de ser criada ela tem zero 
            // movimentos, ou seja, não mexeu ainda
        }
    }
}
