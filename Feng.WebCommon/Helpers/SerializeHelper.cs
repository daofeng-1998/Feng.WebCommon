using System.Runtime.Serialization.Formatters.Binary;

namespace Feng.WebCommon.Helpers; 

public  static class SerializeHelper {
    public static byte[] Serialize(object obj) {
        var formatter = new BinaryFormatter();
        using var stream = new MemoryStream();
        formatter.Serialize(stream, obj);
        return stream.ToArray();
    }

    public static T Deserialize<T>(byte[] buffer) {
        var formatter = new BinaryFormatter();
        using var stream = new MemoryStream(buffer);
        return (T)formatter.Deserialize(stream);
    }
}