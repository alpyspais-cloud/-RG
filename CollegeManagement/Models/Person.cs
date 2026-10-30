
namespace CollegeManagement.Models
{
    public class Person : User
    {
        protected string _name;
        protected string _surname;
        protected int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 15 || value > 100)
                    throw new ArgumentException("Некорректный возраст.");

                _age = value;
            }
        }

        protected Person() : base("", "Person")
        {
            _name = "";
            _surname = "";
            _age = 15;
        }

        public Person(string name, string surname, int age, string role = "Person")
            : base(name, role)
        {
            _name = name;
            _surname = surname;
            Age = age;
        }

        protected void DisplayBasicInfo()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Фамилия: {_surname}");
            Console.WriteLine($"Возраст: {_age}");
        }

        protected internal string GetFullName()
        {
            return $"{_name} {_surname}";
        }

        private protected int CalculateStatistics()
        {
            return _age;
        }
    }
}
