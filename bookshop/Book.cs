using Newtonsoft.Json;

namespace bookshop
{
    public class Book
    {
        private double? _price;
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("cover")]
        public string Image { get; set; }
        [JsonProperty("genre")]
        public string Genre { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        public double? Price {
            get
            {
                return _price;
            }
            set {
                _price = 200.00;
                    } 
        }
    }
}
