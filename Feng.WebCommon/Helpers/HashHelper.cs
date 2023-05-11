using System.Security.Cryptography;
using System.Text;

namespace Feng.WebCommon.Helpers;

public static class HashHelper {
    public static byte[] Md5(byte[] buffer) {
        using var md5 = MD5.Create();
        return md5.ComputeHash(buffer);
    }

    public static string Md5ToHex(string data, Encoding encoding) {
        var buffer = encoding.GetBytes(data);
        return Convert.ToHexString(Md5(buffer));
    }

    public static string Md5ToHex(string data) {
        return Md5ToHex(data, Encoding.UTF8);
    }

    public static byte[] HmacMd5(byte[] buffer, byte[] key) {
        using var hmacMd5 = new HMACMD5 {
            Key = key
        };

        return hmacMd5.ComputeHash(buffer);
    }
}