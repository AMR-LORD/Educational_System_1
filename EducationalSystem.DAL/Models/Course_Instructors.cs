using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Course_Instructors 
    {
        [Key]
        public int CourseInstructorID { get; set; }
        [ForeignKey(nameof(Courses))]
        public int CourseID { get; set; }
        [ForeignKey(nameof(Instructors))]
        public int InstructorID { get; set; }
        public string Role {  get; set; }
        public Courses Courses { get; set; }
        public Instructors Instructors { get; set; }

    }
}
