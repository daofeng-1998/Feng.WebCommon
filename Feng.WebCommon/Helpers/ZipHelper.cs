using System.IO.Compression;

namespace Feng.WebCommon.Helpers;

public static class ZipHelper {
    public static async Task<byte[]> CompressStringAsync(byte[] inputBytes) {
        using var outputStream = new MemoryStream();
        await using (var compressionStream = new GZipStream(outputStream, CompressionMode.Compress)) {
            await compressionStream.WriteAsync(inputBytes);
        }

        return outputStream.ToArray();
    }

    public static async Task<byte[]> DecompressStringAsync(byte[] compressedBytes) {
        using var inputStream = new MemoryStream(compressedBytes);
        await using var decompressionStream = new GZipStream(inputStream, CompressionMode.Decompress);
        using var outputStream = new MemoryStream();
        await decompressionStream.CopyToAsync(outputStream);
        return outputStream.ToArray();
    }
}