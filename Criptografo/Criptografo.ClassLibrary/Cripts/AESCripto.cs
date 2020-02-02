using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografo.ClassLibrary.Cripts
{
    internal class AESCripto
    {
        internal string ToCrypt(string chave, string mensagem)
        {
            System.Security.Cryptography.RijndaelManaged rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Mode = System.Security.Cryptography.CipherMode.CBC;
            rijndael.KeySize = 128;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string criptografia;

            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Encoding.UTF8.GetBytes(mensagem);


            System.Security.Cryptography.ICryptoTransform cryptor = rijndael.CreateEncryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            criptografia = Convert.ToBase64String(criptografiaBytes);
            return criptografia;
        }

        internal string ToDescrypt(string chave, string criptografia)
        {
            System.Security.Cryptography.RijndaelManaged rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Mode = System.Security.Cryptography.CipherMode.CBC;
            rijndael.KeySize = 128;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string mensagem;

            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Convert.FromBase64String(criptografia);


            System.Security.Cryptography.ICryptoTransform cryptor = rijndael.CreateDecryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            mensagem = Encoding.UTF8.GetString(criptografiaBytes);
            return mensagem;
        }
    }
}
