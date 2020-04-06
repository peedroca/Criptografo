using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografo.ClassLibrary.Cripts
{
    internal static class MD5Cript
    {
        internal static string ToCrypt(string mensagem)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] mensagemBytes = Encoding.UTF8.GetBytes(mensagem);
            byte[] criptografiaBytes = md5.ComputeHash(mensagemBytes);
            string criptografia = Convert.ToBase64String(criptografiaBytes);

            return criptografia;
        }
    }
}
