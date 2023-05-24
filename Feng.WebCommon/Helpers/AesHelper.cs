using System.Security.Cryptography;

namespace Feng.WebCommon.Helpers;

public static class AesHelper {
    public static byte[] Encrypt(byte[] buffer, byte[] key, byte[] iv) {
        using var aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;

        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        using var encrypt = aes.CreateEncryptor();
        return encrypt.TransformFinalBlock(buffer, 0, buffer.Length);
    }
    
    public static byte[] Decrypt(byte[] buffer, byte[] key, byte[] iv) {
        using var aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;

        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        using var encrypt = aes.CreateDecryptor();
        return encrypt.TransformFinalBlock(buffer, 0, buffer.Length);
    }
}