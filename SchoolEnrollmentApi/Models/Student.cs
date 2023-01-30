using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolEnrollmentApi.Models
{
    //[Table("Student")]
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation prop of foreign entity
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
