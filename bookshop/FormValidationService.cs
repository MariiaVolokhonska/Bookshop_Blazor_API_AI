using System.Text.RegularExpressions;
namespace bookshop
{
    public class FormValidationService
    {
        public bool ValidateLogin(string login)
        {
            return !string.IsNullOrWhiteSpace(login) && login.Length >= 8;
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{9}$");
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[\W_]).{8,}$");
        }
    }
}


