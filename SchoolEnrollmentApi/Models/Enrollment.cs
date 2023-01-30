using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolEnrollmentApi.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    //[Table("Enrollment")]
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        // Navigation props
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
    
}
