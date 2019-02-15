using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        // O construtor de Rei recebendo o tabuleiro tab e a cor é na verdade repassar essa instrução
        // para a classe peça. (base(tab,cor)) 
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        { //RETORNAR R na interface do tabuleiro
            return "T";
        }
    }
}
