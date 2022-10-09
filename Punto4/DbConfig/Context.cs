
using Microsoft.EntityFrameworkCore;
using Punto4.Models.Grades;

namespace Punto4.DbConfig
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<AcademicRecord> AcademicRecord { get; set; }
    }
}
