using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Criptografo.ClassLibrary.Cripts
{
    internal static class RSACripto
    {
        private readonly static string pubKeyPath = "/crypt/public.key";//change as needed
        private readonly static string priKeyPath = "/crypt/private.key";//change as needed

        internal static bool MakeKey(int dwKeySize = 2048)
        {
            if (!Directory.Exists("/crypt"))
                Directory.CreateDirectory("/crypt");

            //lets take a new CSP with a new 2048 bit rsa key pair
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(dwKeySize);

            //how to get the private key
            RSAParameters privKey = csp.ExportParameters(true);

            //and the public key ...
            RSAParameters pubKey = csp.ExportParameters(false);

            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();
                File.WriteAllText(pubKeyPath, pubKeyString);
            }
            string privKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, privKey);
                //get the string from the stream
                privKeyString = sw.ToString();
                File.WriteAllText(priKeyPath, privKeyString);
            }

            return true;
        }

        internal static string Encrypt(string content)
        {
            //converting the public key into a string representation
            string pubKeyString;
            {
                using (StreamReader reader = new StreamReader(pubKeyPath)) { pubKeyString = reader.ReadToEnd(); }
            }
            //get a stream from the string
            var sr = new StringReader(pubKeyString);

            //we need a deserializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            //get the object back from the stream
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.ImportParameters((RSAParameters)xs.Deserialize(sr));
            byte[] bytesPlainTextData = Encoding.ASCII.GetBytes(content);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCipherText = csp.Encrypt(bytesPlainTextData, false);
            //we might want a string representation of our cypher text... base64 will do
            return Convert.ToBase64String(bytesCipherText);            
        }

        internal static string Decrypt(string content)
        {
            //we want to decrypt, therefore we need a csp and load our private key
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();

            string privKeyString;
            {
                privKeyString = File.ReadAllText(priKeyPath);
                //get a stream from the string
                var sr = new StringReader(privKeyString);
                //we need a deserializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //get the object back from the stream
                RSAParameters privKey = (RSAParameters)xs.Deserialize(sr);
                csp.ImportParameters(privKey);
            }
            byte[] bytesCipherText = Convert.FromBase64String(content);

            //decrypt and strip pkcs#1.5 padding
            byte[] bytesPlainTextData = csp.Decrypt(bytesCipherText, false);
            return Encoding.ASCII.GetString(bytesPlainTextData);
        }
    }
}
