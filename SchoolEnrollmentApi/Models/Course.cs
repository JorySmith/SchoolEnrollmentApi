using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolEnrollmentApi.Models
{    
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // Navigation prop of foreign entity collection
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
