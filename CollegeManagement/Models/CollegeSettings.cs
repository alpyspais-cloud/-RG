
namespace CollegeManagement.Models
{
    internal class CollegeSettings
    {
        private string _collegeName;
        private string _academicYear;

        public CollegeSettings(string collegeName, string academicYear)
        {
            _collegeName = collegeName;
            _academicYear = academicYear;
        }

        public string CollegeName => _collegeName;
        public string AcademicYear => _academicYear;

        // Задание 22
        internal void UpdateSettings(string collegeName, string academicYear)
        {
            if (string.IsNullOrWhiteSpace(collegeName))
                throw new ArgumentException("Введите название колледжа.");

            _collegeName = collegeName;
            _academicYear = academicYear;
        }

        internal string GetSettings()
        {
            return $"Колледж: {_collegeName}, учебный год: {_academicYear}";
        }
    }
}
