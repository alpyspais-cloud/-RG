
namespace CollegeManagement.Models
{
    public class Group
    {
        private string _name;
        private int _course;

        // Закрытый список студентов
        private readonly List<Student> _students = new();

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Course
        {
            get => _course;
            set
            {
                if (value < 1 || value > 6)
                    throw new ArgumentException("Некорректный курс.");

                _course = value;
            }
        }

        // Только чтение списка извне
        public IReadOnlyList<Student> Students => _students.AsReadOnly();

        public Group(string name, int course)
        {
            _name = name;
            _course = course;
        }

        // Задание 12
        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            if (!_students.Contains(student))
                _students.Add(student);
        }

        // Задание 13
        public void RemoveStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            _students.Remove(student);
        }

        public string GetGroupInfo()
        {
            return $"Группа: {Name}, курс: {Course}, студентов: {_students.Count}";
        }
    }
}
