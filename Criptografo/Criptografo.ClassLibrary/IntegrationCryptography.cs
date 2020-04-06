using Criptografo.ClassLibrary.Cripts;
using Criptografo.ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Criptografo.ClassLibrary
{
    public static class IntegrationCryptography
    {
        #region Public Methods

        public static IEnumerable<Cryptography> GetCryptographies()
        {
            try
            {
                return new List<Cryptography>()
                {
                    new Cryptography() { Name = "AES", HasKey = true, TypeCryptography = eTypeCryptography.AES},
                    new Cryptography() { Name = "DES", HasKey = true, TypeCryptography = eTypeCryptography.DES},
                    new Cryptography() { Name = "MD5", HasKey = false, TypeCryptography = eTypeCryptography.MD5},
                    new Cryptography() { Name = "RSA", HasKey = false, TypeCryptography = eTypeCryptography.RSA},
                    new Cryptography() { Name = "SHA256", HasKey = false, TypeCryptography = eTypeCryptography.SHA256},
                    new Cryptography() { Name = "Zenit-Polar", HasKey = false, TypeCryptography = eTypeCryptography.ZenitPolar},
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool MakeRSAKeys => RSACripto.MakeKey();

        public static string GenerateAESKey()
        {
            return Guid.NewGuid().GetKeyFromGuid(16);
        }

        public static string GenerateDESKey()
        {
            return Guid.NewGuid().GetKeyFromGuid();
        }

        public static string GetCryptography(eTypeCryptography typeCryptography, string content, string key = null)
        {
            string cryptography = string.Empty;

            try
            {
                if (Validate(typeCryptography, content, key))
                {
                    switch (typeCryptography)
                    {
                        case eTypeCryptography.DES:
                            cryptography = DESCripto.ToCrypt(key, content);
                            break;
                        case eTypeCryptography.AES:
                            cryptography = AESCripto.ToCrypt(key, content);
                            break;
                        case eTypeCryptography.SHA256:
                            cryptography = SHA256.ToCrypt(content);
                            break;
                        case eTypeCryptography.MD5:
                            cryptography = MD5Cript.ToCrypt(content);
                            break;
                        case eTypeCryptography.ZenitPolar:
                            cryptography = Zenit_Polar.ToCript(content);
                            break;
                        case eTypeCryptography.RSA:
                            cryptography = RSACripto.Encrypt(content);
                            break;
                    }
                }

                return cryptography;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cryptography = string.Empty;
            }
        }

        public static string GetDescryptography(eTypeCryptography typeCryptography, string content, string key = null)
        {
            string cryptography = string.Empty;

            try
            {
                if (Validate(typeCryptography, content, key))
                {
                    switch (typeCryptography)
                    {
                        case eTypeCryptography.DES:
                            cryptography = DESCripto.ToDescrypt(key, content);
                            break;
                        case eTypeCryptography.AES:
                            cryptography = AESCripto.ToDescrypt(key, content);
                            break;
                        case eTypeCryptography.SHA256:
                        case eTypeCryptography.MD5:
                            throw new Exception("Este algoritmo não permite descriptografia.");
                        case eTypeCryptography.ZenitPolar:
                            cryptography = Zenit_Polar.ToDescript(content);
                            break;
                        case eTypeCryptography.RSA:
                            cryptography = RSACripto.Decrypt(content);
                            break;
                    }
                }

                return cryptography;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cryptography = string.Empty;
            }
        }

        #endregion

        #region Private Methods

        private static bool Validate(eTypeCryptography typeCryptography, string content, string key)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(content))
                    throw new Exception("Erro 01 - O conteúdo não foi informado.");

                if (string.IsNullOrEmpty(key))
                {
                    switch (typeCryptography)
                    {
                        case eTypeCryptography.DES:
                        case eTypeCryptography.AES:
                            throw new Exception("Erro 02 - A chave de criptografia não foi informada.");
                    }
                }
                else
                {
                    switch (typeCryptography)
                    {
                        case eTypeCryptography.DES:
                            if(key.Length != 8)
                                throw new Exception("Erro 04 - A chave de criptografia não contém 8 caractéres.");
                            break;
                        case eTypeCryptography.AES:
                            if(key.Length != 16)
                                throw new Exception("Erro 04 - A chave de criptografia não contém 16 caractéres.");
                            break;
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}
