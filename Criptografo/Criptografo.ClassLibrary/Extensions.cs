using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografo.ClassLibrary
{
    public static class Extensions
    {
        public static string GetKeyFromGuid(this Guid guid, int size = 8)
        {
            return guid.ToString()?.Substring(0, size);
        }
    }
}
