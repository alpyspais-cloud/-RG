
namespace CollegeManagement.Services
{
    public class AttendanceManager
    {
        private readonly Dictionary<int, bool> _attendance = new();

        public void AddAttendance(int studentId, bool present)
        {
            _attendance[studentId] = present;
        }

        public void UpdateAttendance(int studentId, bool present)
        {
            if (!_attendance.ContainsKey(studentId))
                throw new ArgumentException("Студент не найден.");

            _attendance[studentId] = present;
        }

        public string GetStatistics()
        {
            int total = _attendance.Count;
            int present = _attendance.Values.Count(x => x);
            int absent = total - present;

            return $"Всего записей: {total}\n" +
                   $"Присутствовали: {present}\n" +
                   $"Отсутствовали: {absent}";
        }
    }
}
