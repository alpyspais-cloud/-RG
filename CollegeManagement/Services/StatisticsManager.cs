
using CollegeManagement.Models;

namespace CollegeManagement.Services
{
    public class StatisticsManager : Person
    {
        public StatisticsManager(string name, string surname, int age)
            : base(name, surname, age)
        {
        }

        public int GetStatistics()
        {
            // Доступно, потому что класс наследуется от Person
            // и находится в той же сборке.
            return CalculateStatistics();
        }
    }
}
