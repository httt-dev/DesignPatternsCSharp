namespace Adapter
{
    // Adaptee -> the interface that is incompatible with the target interface
    public interface IXmlParser<T>
    {
        T Parser(string data);
        string ConvertToXml(T obj);
    }
}