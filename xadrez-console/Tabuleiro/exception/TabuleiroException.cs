using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro.exception
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
