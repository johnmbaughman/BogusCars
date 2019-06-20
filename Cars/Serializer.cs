using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Cars
{
    public class Serializer
    {
        public static T Deserialize<T>(Stream stream)
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(T));
            string readToEnd = ReadToEnd(stream);

            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(readToEnd)))
            {
                memoryStream.Position = 0;
                return (T)jsonSerializer.ReadObject(memoryStream);
            }
        }

        static string ReadToEnd(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}