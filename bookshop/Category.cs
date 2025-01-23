using Newtonsoft.Json;
namespace bookshop
{
    public class Category
    {
        [JsonProperty("name")]
       public string Name { get; set; }
    }
}
