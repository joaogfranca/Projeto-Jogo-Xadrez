using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //norte
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //leste
            pos.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            //sul
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //oeste
            pos.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;

        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}