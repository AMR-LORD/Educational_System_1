using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Course_Enrollments 
    {
        [Key]
        public int EnrollmentID { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public string UserID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        [ForeignKey(nameof(Courses))]
        public int CourseId { get; set; }
        public Courses Course { get; set; }
        public ApplicationUser User { get; set; }
    }
}
