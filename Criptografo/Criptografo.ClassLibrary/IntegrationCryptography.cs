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
        SHA256
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
                        case eTypeCryptography.SHA256:
                            cryptography = GetSHA256Crypt(content);
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
                        case eTypeCryptography.SHA256:
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

                switch (typeCryptography)
                {
                    case eTypeCryptography.DES:
                        if (string.IsNullOrEmpty(key))
                            throw new Exception("Erro 02 - A chave de criptografia não foi informada.");
                        break;
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
       
        #endregion
    }
}
