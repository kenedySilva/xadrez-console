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
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            PosicaoXadrez pos2 = new PosicaoXadrez('c', 3); 
            Console.WriteLine(pos);
            Console.WriteLine(pos.toposicao());
            Console.WriteLine(pos2);
            Console.WriteLine(pos2.toposicao());
            Console.ReadLine();
        }
    }
}
