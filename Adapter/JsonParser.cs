using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Adapter
{
    public class JsonParser<T> : IJsonParser<T>
    {
        public T Parser(string data)
        {
            return JsonSerializer.Deserialize<T>(data);
        }

        public string ConvertToJson(T obj)
        {
            return JsonSerializer.Serialize(obj ,new JsonSerializerOptions{ WriteIndented = true});
        }
    }
}