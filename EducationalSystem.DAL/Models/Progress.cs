using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Progress 
    {
        [Key]
        public int ProgressID { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public string UserID { get; set; }
        [ForeignKey(nameof(Courses))]
        public int CourseID { get; set; }
        public int Score { get; set; }
        public DateTime CompletedDate { get; set; }
        public ApplicationUser User { get; set; }
        public Courses Courses { get; set; }
    }
}
