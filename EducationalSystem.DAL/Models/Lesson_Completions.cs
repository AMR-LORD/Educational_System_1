using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Lesson_Completions :BaseEntity
    {

        [ForeignKey(nameof(ApplicationUser))]
        public string UserID { get; set; }
        [ForeignKey(nameof(Lessons))]
        public int LessonID { get; set; }
        public DateTime CompletionDate { get; set; }
        public Lessons Lessons { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
