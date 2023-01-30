using Microsoft.EntityFrameworkCore;
using SchoolEnrollmentApi.Models;

namespace SchoolEnrollmentApi.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) 
            : base(options)
        {        
        }

        public DbSet<Course> Course { get; set; }  
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
