
namespace CollegeManagement.Models
{
    public class Teacher : Person
    {
        private string _subject;
        private int _experience;

        public string Subject
        {
            get => _subject;
            set => _subject = value;
        }

        public int Experience => _experience;

        public Teacher(
            string name,
            string surname,
            int age,
            string subject,
            int experience
        ) : base(name, surname, age, "Teacher")
        {
            _subject = subject;
            _experience = 0;

            UpdateExperience(experience);
        }

        // Задание 10
        public void UpdateExperience(int experience)
        {
            if (experience < 0 || experience > 60)
                throw new ArgumentException("Некорректный стаж.");

            _experience = experience;
        }

        // Задания 18 и 19
        public string GetTeacherInfo()
        {
            DisplayBasicInfo();

            return $"{GetFullName()}, предмет: {Subject}, стаж: {Experience} лет";
        }
    }
}