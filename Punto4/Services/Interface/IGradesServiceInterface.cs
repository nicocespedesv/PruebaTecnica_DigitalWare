using Punto4.Models;

namespace Punto4.Services.Interface
{
    public interface IGradesServiceInterface
    {
        public List<AcademicRecord> GetGrades(int studentId);
    }
}
