using System;
using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class XmlParser<T> : IXmlParser<T>
    {
        private readonly XmlSerializer _serializer;

        public XmlParser()
        {
            _serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(typeof(T).Name.ToLower()));
        }
        public T Parser(string data)
        {
            using (TextReader reader = new StringReader(data))
            {
                return (T)_serializer.Deserialize(reader);
            }
            
        }

        public string ConvertToXml(T obj)
        {
            using (StringWriter textWriter = new StringWriter())
            {
                _serializer.Serialize(textWriter , obj);
                return textWriter.ToString();
            }
        }
    }
}