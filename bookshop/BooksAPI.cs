using bookshop.Models;
using Newtonsoft.Json;
namespace bookshop
{
    public class BooksAPI
    {
        static string _address = "https://wolnelektury.pl";
        private string result;
        private HttpClient client;

        public async Task<List<Category>> GetAllGenres()
        {
            string partOfUrl = "/api/genres/";
            string completeUrl = _address + partOfUrl;
            client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(completeUrl);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<Category>>(result);
            return categories;
    }
        public async Task<List<Book>> GetAllBooks()
        {
            string partOfUrl = "/api/books/";
            string completeUrl = _address + partOfUrl;
            client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(completeUrl);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            var books = JsonConvert.DeserializeObject<List<Book>>(result);

            return books;
        }
        
        public async Task<Book> GetBookByTitle(string title)
        {
            List<Book> books = await GetAllBooks();
            return (Book)books.FirstOrDefault(book => book.Title.ToLower() == title.ToLower());
        }

    }
}
