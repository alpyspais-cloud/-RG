
namespace CollegeManagement.Models
{
    public class GradeBook
    {
        private readonly List<int> _grades = new();

        public IReadOnlyList<int> Grades => _grades.AsReadOnly();

        public void AddGrade(int grade)
        {
            if (grade < 2 || grade > 5)
                throw new ArgumentException("Оценка должна быть от 2 до 5.");

            _grades.Add(grade);
        }

        public void RemoveGrade(int grade)
        {
            _grades.Remove(grade);
        }

        public double GetAverageGrade()
        {
            if (_grades.Count == 0)
                return 0;

            return _grades.Average();
        }

        public int GetGradeCount()
        {
            return _grades.Count;
        }
    }
}
