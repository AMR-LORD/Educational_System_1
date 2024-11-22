using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Lessons 
    {
        [Key]
        public int LessonID { get; set; }
        [ForeignKey(nameof(Courses))]
        public int CourseID { get; set; }
        public string LessonTitle { get; set; }
        public string Content { get; set; }
        public int LessonOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        // Inverse navigation for CurrentLesson
        public ICollection<Lesson_Prerequisites> CurrentLessonPrerequisites { get; set; }

        // Inverse navigation for PrerequisiteLesson
        public ICollection<Lesson_Prerequisites> PrerequisiteLessonPrerequisites { get; set; }
        public ICollection<Assessments>? Assessments { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public Courses Courses { get; set; }

    }
}
