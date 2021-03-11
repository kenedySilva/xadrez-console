using System;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.exception;
using xadrez_console.xadrez;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.coloarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.coloarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.coloarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                tab.coloarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            { Console.WriteLine(e.Message); }
        }
    }
}
