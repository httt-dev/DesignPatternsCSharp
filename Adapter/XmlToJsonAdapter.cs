namespace Adapter
{
    public class XmlToJsonAdapter<T> : IJsonParser<T>
    {
        public T Parser(string data)
        {
            IXmlParser<T> xmlParser = new XmlParser<T>();
            return xmlParser.Parser(data);
        }

        public string ConvertToJson(T obj)
        {
            IJsonParser<T> jsonParser = new JsonParser<T>();
            return jsonParser.ConvertToJson(obj);
        }
    }
}