using System.Text;
using Feng.WebCommon.Helpers;

HelpersTest();

void HelpersTest() {
    var md5 = HashHelper.Md5ToHex("123456");
    Console.WriteLine(md5);

    var key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    var buffer = Encoding.UTF8.GetBytes("刀锋");

    var hmacHex = Convert.ToHexString(HashHelper.HmacMd5(buffer, key));
    Console.WriteLine(hmacHex);
}