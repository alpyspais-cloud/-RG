
namespace CollegeManagement.Models
{
    public class UserAccount
    {
        private string _login;
        private string _password;
        private bool _isLoggedIn;

        public string LoginName => _login;
        public bool IsLoggedIn => _isLoggedIn;

        public UserAccount(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Введите логин.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Введите пароль.");

            _login = login;
            _password = password;
            _isLoggedIn = false;
        }

        public bool Login(string login, string password)
        {
            if (_login == login && _password == password)
            {
                _isLoggedIn = true;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            _isLoggedIn = false;
        }

        public string GetAccountInfo()
        {
            return $"Логин: {_login}, авторизован: {_isLoggedIn}";
        }
    }
}
