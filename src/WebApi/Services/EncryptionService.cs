using NETCore.Encrypt;

namespace WebApi.Services
{
    public class EncryptionService
    {
        private const string _key = "uAugKPuIzZpUNtTjwDhn5xPqou4ySNA2";
        private const string _vector = "qwerty1234567890";

        public string Encrypt(string data)
        {
            return EncryptProvider.AESEncrypt(data, _key, _vector);
        }

        public string Decrypt(string data)
        {
            return EncryptProvider.AESDecrypt(data, _key, _vector); 
        }

    }
}
