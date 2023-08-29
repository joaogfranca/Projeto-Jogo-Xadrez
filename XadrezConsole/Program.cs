using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 1));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 6));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 3));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

        }
    }
}