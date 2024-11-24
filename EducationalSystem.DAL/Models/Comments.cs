using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Comments : BaseEntity
    {

        [ForeignKey(nameof(Lessons))]
        public int LessonID { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public string UserID { get; set; }
        public string CommentText { get; set; }
        public DateTime PostedDate { get; set; }
        public Lessons Lessons { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
