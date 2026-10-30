
namespace CollegeManagement.Services
{
    public class ReportManager
    {
        // Задание 24
        protected internal string GenerateReport(string title, string content)
        {
            return $"ОТЧЁТ: {title}\n\n{content}\n\nДата: {DateTime.Now}";
        }

        public string CreateStudentReport(int count)
        {
            return GenerateReport(
                "Отчёт по студентам",
                $"Общее количество студентов: {count}"
            );
        }
    }
}
