using System.Text;
using Feng.WebCommon.Helpers;

HelpersTest();

async Task HelpersTest() {
    var str = "12311111111111111111111111111111111111111111111111";
    var zip = await ZipHelper.CompressStringAsync(Encoding.UTF8.GetBytes(str));
    Console.WriteLine(zip);
    var source = Encoding.UTF8.GetString(await ZipHelper.DecompressStringAsync(zip));
    Console.WriteLine(source);
}