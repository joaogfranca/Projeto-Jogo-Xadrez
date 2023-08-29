using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.QtdMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementaQtdMovimentos()
        {
            QtdMovimentos++;
        }
    }
}
