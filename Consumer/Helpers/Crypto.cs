using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Gkdr.Consumer.Helpers
{
    // public readonly string key = "skjdfhksdhfkjdshkfjhdksjfhkdsj89798kjkslai";
    // Properties.Resources.ResourceManager.GetString("Key")
    public interface IKeyProvider
    {
        byte[] getKey { get; }
    }

    public class KeyProvider : IKeyProvider
    {
        public byte[] getKey
        {
            get { return Convert.FromBase64String("skjdfhksdhfkjdshkfjhdksjfhkdsj89798kjkslai"); }
        }
    }
    
    public class Crypto
    {
        enum CrtyptDirection
        {
            Encrypt,
            Decrypt
        }
        public static string EncryptMessage(IKeyProvider keyProvider, string message)
        {
            var input = Encoding.UTF32.GetBytes(message);
            var key = new RSACryptoServiceProvider();
            key.ImportCspBlob(keyProvider.getKey);
            var res = CryptMessageInner(input, key, CrtyptDirection.Encrypt);
            return res;
        }
        public static string DecryptMessage(IKeyProvider keyProvider, string message)
        {
            var key = new RSACryptoServiceProvider();
            key.ImportCspBlob(keyProvider.getKey);
            var input = message.ToCharArray().Select(a => (byte)a).ToArray();
            var res = CryptMessageInner(input, key, CrtyptDirection.Decrypt);
            return res;
        }

        private static string CryptMessageInner(byte[] message, RSACryptoServiceProvider key, CrtyptDirection direction)
        {
            if (message.Length == 0)
                return string.Empty;
            var maxLen = direction == CrtyptDirection.Encrypt ? 128 : 256;
            var forCrypt = message;
            if (message.Length > maxLen)
            {
                forCrypt = message.Take(maxLen).ToArray();
                message = message.Skip(maxLen).ToArray();
            }
            else
                message = new byte[0];
            var tmp = direction == CrtyptDirection.Encrypt ? key.Encrypt(forCrypt, false) : key.Decrypt(forCrypt, false);
            var charArray = tmp.Select(a => (char)a);
            var res = direction == CrtyptDirection.Encrypt
                          ? new string(charArray.ToArray())
                          : Encoding.UTF32.GetString(tmp);
            res += CryptMessageInner(message, key, direction);
            return res;
        }

        static public string MD5_hash(string s)
        {
            var bytes = Encoding.Unicode.GetBytes(s);
            var csp = new MD5CryptoServiceProvider();
            var bytehash = csp.ComputeHash(bytes);
            return bytehash.Aggregate(string.Empty, (current, b) => current + string.Format("{0:x2}", b));
        }
    }
}