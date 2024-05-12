namespace Adapter
{
    // Target => the interface the client wants to use
    public interface IJsonParser<T>
    {
        T Parser(string data);
        string ConvertToJson(T obj);
    }
}