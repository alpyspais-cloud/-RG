
namespace CollegeManagement.Models
{
    public class Student : Person
    {
        public int StudentId { get; private set; }

        public string Group { get; set; } = "";

        // Конструктор для Entity Framework
        private Student() : base()
        {
        }

        // Задания 17 и 5
        public Student(string name, string surname, int age, string group)
            : base(name, surname, age, "Student")
        {
            Group = group;
            ValidateStudentData();
        }

        // Задание 4
        public void SetAge(int age)
        {
            if (age < 15 || age > 70)
                throw new ArgumentException("Возраст должен быть от 15 до 70 лет.");

            Age = age;
        }

        // Задание 6
        private void ValidateStudentData()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Введите имя.");

            if (string.IsNullOrWhiteSpace(Surname))
                throw new ArgumentException("Введите фамилию.");

            if (Age < 15 || Age > 70)
                throw new ArgumentException("Некорректный возраст.");

            if (string.IsNullOrWhiteSpace(Group))
                throw new ArgumentException("Введите группу.");
        }

        // Задание 7 и 19
        public string GetStudentInfo()
        {
            DisplayBasicInfo();

            return $"ID: {StudentId}\n" +
                   $"Имя: {Name}\n" +
                   $"Фамилия: {Surname}\n" +
                   $"Возраст: {Age}\n" +
                   $"Группа: {Group}";
        }
    }
}