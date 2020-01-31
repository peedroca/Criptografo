﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografo.ClassLibrary.Cripts
{
    internal class SHA256
    {
        internal string ToCrypt(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            
            return hash.ToString();
        }
    }
}
