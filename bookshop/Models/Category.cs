using Newtonsoft.Json;
namespace bookshop.Models
{
    public class Category
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
