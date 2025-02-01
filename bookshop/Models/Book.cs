using Newtonsoft.Json;


namespace bookshop.Models
{
    public class Book

    {
        private static Random random = new Random();
        private double? _price;
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("cover")]
        public string Image { get; set; }
        [JsonProperty("genre")]
        public string Genre { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        public double? Price
        {
            get;
        }

        public Book()
        {
            Price = Math.Round(random.NextDouble() * 200, 2);
        }
    }

}
