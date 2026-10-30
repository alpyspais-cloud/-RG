
namespace CollegeManagement.Models
{
    public class User
    {
        protected string _username;
        protected string _role;

        public string Username => _username;
        public string Role => _role;

        public User(string username, string role)
        {
            _username = username;
            _role = role;
        }

        public string GetUserInfo()
        {
            return $"Пользователь: {_username}, роль: {_role}";
        }
    }

    // Администратор
    public class Admin : User
    {
        public Admin(string username)
            : base(username, "Admin")
        {
        }
    }
}
