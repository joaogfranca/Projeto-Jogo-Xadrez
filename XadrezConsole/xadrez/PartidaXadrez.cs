﻿using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
            Terminada = false;

        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementaQtdMovimentos();
            Peca PecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();
        }

        private void MudaJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());

        }
    }
}
