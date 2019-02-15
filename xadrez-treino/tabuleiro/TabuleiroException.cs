using System;

namespace tabuleiro
{
    //exceções herdam da classe Exception do C#
    class TabuleiroException : Exception 
    {                   //base(msg) significa que ele repassa a msg para a class Exception do C#
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
