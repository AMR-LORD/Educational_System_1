using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Instructor_Specializations : BaseEntity
    {
        [ForeignKey(nameof(Instructors))]
        public int InstructorID { get; set; }
        [ForeignKey(nameof(Specializations))]
        public int SpecializationID { get; set; }
        public Instructors Instructors { get; set; }
        public Specializations Specializations { get; set; }
    }
}
