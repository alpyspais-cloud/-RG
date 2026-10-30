
namespace CollegeManagement.Models
{
    public class Subject
    {
        private string _name;
        private int _hours;
        private Teacher? _teacher;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Hours
        {
            get => _hours;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество часов должно быть больше нуля.");

                _hours = value;
            }
        }

        public Teacher? AssignedTeacher => _teacher;

        public Subject(string name, int hours)
        {
            _name = name;
            _hours = hours;
        }

        // Задание 15
        public void AssignTeacher(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentNullException(nameof(teacher));

            _teacher = teacher;
        }

        public string GetSubjectInfo()
        {
            string teacherName = _teacher == null
                ? "Не назначен"
                : $"{_teacher.Name} {_teacher.Surname}";

            return $"Предмет: {Name}, часов: {Hours}, преподаватель: {teacherName}";
        }
    }
}
