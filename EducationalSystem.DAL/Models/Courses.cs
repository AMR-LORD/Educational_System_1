using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Courses : BaseEntity
    {

        public string CourseTitle { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(Categories))]
        public int CategoryID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ThumbnailURL { get; set; }
        public decimal TotalAmount { get; set; }
        public Categories Categories { get; set; }
        public ICollection<Lessons>? Lessons { get; set; }
        public ICollection<Discounts>? Discounts { get; set; }
        public ICollection<Assessments>? Assessments { get; set; }
        public ICollection<Course_Instructors>? Course_Instructors { get; set; }
        public ICollection<Course_Enrollments>? Course_Enrollments { get; set; }
        /*
o One-to-Many with Lessons
o One-to-Many with Discounts
o One-to-Many with Assessments
o Many-to-Many with Instructors through Course_Instructors
o One-to-Many with Course_Enrollments
 */
    }
}
