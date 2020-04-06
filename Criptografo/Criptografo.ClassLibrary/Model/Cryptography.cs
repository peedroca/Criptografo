using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Criptografo.ClassLibrary.Model
{
    /// <summary>
    /// Tipo de Criptografia
    /// </summary>
    public enum eTypeCryptography : int
    {
        [Description("DES")]
        DES,
        [Description("SHA256")]
        SHA256,
        [Description("AES")]
        AES,
        [Description("MD5")]
        MD5,
        [Description("Zenit-Polar")]
        ZenitPolar,
        [Description("RSA")]
        RSA,
    }

    /// <summary>
    /// Criptografia
    /// </summary>
    public class Cryptography
    {
        /// <summary>
        /// Nome da Criptografia
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Usa chave
        /// </summary>
        public bool HasKey { get; set; }

        /// <summary>
        /// Tipo de Criptografia
        /// </summary>
        public eTypeCryptography TypeCryptography { get; set; }
    }
}
