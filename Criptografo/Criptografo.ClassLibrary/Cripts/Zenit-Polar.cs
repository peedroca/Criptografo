using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografo.ClassLibrary.Cripts
{
    internal static class Zenit_Polar
    {
        internal static string ToCript(string mensagem)
        {
            string cript = mensagem.ToLower()
                                   .Replace("z", "<<z>>").Replace("p", "z").Replace("<<z>>", "p")
                                   .Replace("e", "<<e>>").Replace("o", "e").Replace("<<e>>", "o")
                                   .Replace("n", "<<n>>").Replace("l", "n").Replace("<<n>>", "l")
                                   .Replace("i", "<<i>>").Replace("a", "i").Replace("<<i>>", "a")
                                   .Replace("t", "<<t>>").Replace("r", "t").Replace("<<t>>", "r");
            return cript;
        }

        internal static string ToDescript(string mensagem)
        {
            string cript = mensagem.ToLower()
                                   .Replace("p", "<<p>>").Replace("z", "p").Replace("<<p>>", "z")
                                   .Replace("o", "<<o>>").Replace("e", "o").Replace("<<o>>", "e")
                                   .Replace("l", "<<l>>").Replace("n", "l").Replace("<<l>>", "n")
                                   .Replace("a", "<<a>>").Replace("i", "a").Replace("<<a>>", "i")
                                   .Replace("r", "<<r>>").Replace("t", "r").Replace("<<r>>", "t");
            return cript;
        }
    }
}
