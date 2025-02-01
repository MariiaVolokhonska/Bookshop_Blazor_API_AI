using System.Runtime.InteropServices;

namespace bookshop.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
