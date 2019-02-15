using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        // O construtor de Rei recebendo o tabuleiro tab e a cor é na verdade repassar essa instrução
        // para a classe peça. (base(tab,cor)) 
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        { //RETORNAR R na interface do tabuleiro
            return "R";
        }
    }
}
