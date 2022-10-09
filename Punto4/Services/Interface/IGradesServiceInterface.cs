using Punto4.Models;
using Punto4.Models.Grades;
using System.Collections.Generic;

namespace Punto4.Services.Interface
{
    public interface IGradesServiceInterface
    {
        public List<AcademicRecord> GetGrades();
    }
}
