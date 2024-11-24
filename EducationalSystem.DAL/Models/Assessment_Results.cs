using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Assessment_Results :BaseEntity
    {

        [ForeignKey(nameof(ApplicationUser))]
        public string UserID { get; set; }
        public int Score {  get; set; }
        public DateTime? AttemptDate { get; set; }
        public ApplicationUser User { get; set; }
    }
}
