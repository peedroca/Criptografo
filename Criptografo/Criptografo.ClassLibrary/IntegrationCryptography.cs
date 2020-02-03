using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Criptografo.ClassLibrary
{
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
    }

    public static class IntegrationCryptography
    {
        #region Public Methods

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
                            cryptography = GetDESCrypt(content, key);
                            break;
                        case eTypeCryptography.AES:
                            cryptography = GetAESCrypt(content, key);
                            break;
                        case eTypeCryptography.SHA256:
                            cryptography = GetSHA256Crypt(content);
                            break;
                        case eTypeCryptography.MD5:
                            cryptography = GetMD5Crypt(content);
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
                            cryptography = GetDESDescrypt(content, key);
                            break;
                        case eTypeCryptography.AES:
                            cryptography = GetAESDescrypt(content, key);
                            break;
                        case eTypeCryptography.SHA256:
                        case eTypeCryptography.MD5:
                            throw new Exception("Este algoritmo não permite descriptografia.");
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

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static string GetDESCrypt(string content, string key)
        {
            Cripts.DESCripto cripto = null;

            try
            {
                cripto = new Cripts.DESCripto();
                return cripto.ToCrypt(key, content);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cripto = null;
            }
        }

        private static string GetDESDescrypt(string content, string key)
        {
            Cripts.DESCripto cripto = null;

            try
            {
                cripto = new Cripts.DESCripto();
                return cripto.ToDescrypt(key, content);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cripto = null;
            }
        }

        private static string GetAESCrypt(string content, string key)
        {
            Cripts.AESCripto cripto = null;

            try
            {
                cripto = new Cripts.AESCripto();
                return cripto.ToCrypt(key, content);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cripto = null;
            }
        }

        private static string GetAESDescrypt(string content, string key)
        {
            Cripts.AESCripto cripto = null;

            try
            {
                cripto = new Cripts.AESCripto();
                return cripto.ToDescrypt(key, content);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cripto = null;
            }
        }

        private static string GetSHA256Crypt(string content)
        {
            Cripts.SHA256 cripto = null;

            try
            {
                cripto = new Cripts.SHA256();
                return cripto.ToCrypt(content);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cripto = null;
            }
        }

        private static string GetMD5Crypt(string content)
        {
            Cripts.MD5Cript cripto = null;

            try
            {
                cripto = new Cripts.MD5Cript();
                return cripto.ToCrypt(content);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cripto = null;
            }
        }

        #endregion
    }
}
