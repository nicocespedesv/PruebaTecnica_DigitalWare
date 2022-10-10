using Business.Interface;
using Microsoft.Extensions.Configuration;
using Models.Models;
using System.Data;
using System.Data.SqlClient;

namespace Business.Implementation
{
    public class StudentsService: IStudentsInterface
    {
        private string _connection;

        public StudentsService(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            DataTable studentsDt = new DataTable();

            SqlConnection conn = new SqlConnection(_connection);
            SqlCommand cmd = new SqlCommand("SP_GET_STUDENTS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(studentsDt);

            for (int i = 0; i < studentsDt.Rows.Count; i++)
            {
                Student student = new Student();

                student.Id = Int32.Parse(studentsDt.Rows[i]["ID"].ToString());
                student.Name = studentsDt.Rows[i]["NOMBRE"].ToString();
                student.LastName = studentsDt.Rows[i]["APELLIDO"].ToString();
                student.Email = studentsDt.Rows[i]["EMAIL"].ToString();
                student.Age = studentsDt.Rows[i]["EDAD"].ToString();

                students.Add(student);
            }

            return students;
        }
    }
}
