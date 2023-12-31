using Microsoft.Extensions.Configuration;

namespace DrMadWill.Extensions.ReadJson;

public class JsonRead
{
    protected readonly ConfigurationManager Json;

    public JsonRead(string path)
    { 
        Json = new();
        Json.SetBasePath(Path.Combine(path));
    }

    public JsonRead()
    {
        Json = new(); 
    }

    public void WriteJson(string path)
    {
        Json.SetBasePath(path); 
    }

}