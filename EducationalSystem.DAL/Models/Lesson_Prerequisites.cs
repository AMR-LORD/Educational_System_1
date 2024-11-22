using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Lesson_Prerequisites 
    {
        [Key]
        public int PrerequisiteID { get; set; }

        [ForeignKey(nameof(CurrentLesson))]
        public int CurrentLessonID { get; set; }

        [ForeignKey(nameof(PrerequisiteLesson))]
        public int PrerequisiteLessonID { get; set; }

        [InverseProperty("CurrentLessonPrerequisites")] // Maps to the CurrentLesson navigation
        public Lessons CurrentLesson { get; set; }

        [InverseProperty("PrerequisiteLessonPrerequisites")] // Maps to the PrerequisiteLesson navigation
        public Lessons PrerequisiteLesson { get; set; }
    }
}
