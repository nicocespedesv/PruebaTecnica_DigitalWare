using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Punto4.Models.Grades
{
    public class AcademicRecord
    {
        [Key]
        [Display(Name = "Id registro")]
        public int RecordId { get; set; }

        [Required(ErrorMessage = "Ingrese el id.")]
        [Display(Name = "Identificación estudiante")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Ingrese la materia")]
        [Display(Name = "Materia")]
        public string Subject { get; set; }

        [Display(Name = "Nota periodo 1")]
        public double FirstPeriodGrade { get; set; }

        [Display(Name = "Nota periodo 2")]
        public double SecondPeriodGrade { get; set; }

        [Display(Name = "Nota periodo 3")]
        public double ThirdPeriodGrade { get; set; }

        [Display(Name = "Nota periodo 4")]
        public double FourthPeriodGrade { get; set; }
    }
}
