using Microsoft.Extensions.Configuration;
using Punto4.Models.Grades;
using Punto4.Services.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Punto4.Services.Implementation
{
    public class GradesService: IGradesServiceInterface
    {
        private IConfiguration configuration;
        string connection = string.Empty;

        public GradesService(IConfiguration config)
        {
            connection = config.GetConnectionString("DefaultConnection");
        }

        public List<AcademicRecord> GetGrades()
        {
            List<AcademicRecord> academicRecords = new List<AcademicRecord>();
            DataTable academicRecordsDt = new DataTable();
          
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SP_GET_GRADES", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", 0);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(academicRecordsDt);

            for (int i = 0; i < academicRecordsDt.Rows.Count; i++)
            {
                Subject subject = new Subject();
                subject.Id = Int32.Parse(academicRecordsDt.Rows[i]["ar_subjectId"].ToString());
                subject.Name = academicRecordsDt.Rows[i]["subject_name"].ToString();

                Student student = new Student();
                student.Id = academicRecordsDt.Rows[i]["ar_studentId"].ToString();
                student.FullName = academicRecordsDt.Rows[i]["student_fullname"].ToString();

                AcademicRecord academicRecord = new AcademicRecord();
                //academicRecord.Subject = subject;
                //academicRecord.Student = student;
                academicRecord.FirstPeriodGrade = double.Parse(academicRecordsDt.Rows[i]["ar_firstPeriodGrade"].ToString());
                academicRecord.SecondPeriodGrade = double.Parse(academicRecordsDt.Rows[i]["ar_secondPeriodGrade"].ToString());
                academicRecord.ThirdPeriodGrade = double.Parse(academicRecordsDt.Rows[i]["ar_thirdPeriodGrade"].ToString());
                academicRecord.FourthPeriodGrade = double.Parse(academicRecordsDt.Rows[i]["ar_fourthPeriodGrade"].ToString());

                academicRecords.Add(academicRecord);
            }

            return academicRecords;
        }

    }
}
