using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IStudentsInterface
    {
        public List<Student> GetStudents();
    }
}
