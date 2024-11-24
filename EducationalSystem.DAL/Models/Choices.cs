using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Choices : BaseEntity
    {

        [ForeignKey(nameof(Questions))]
        public int QuestionID { get; set; }
        public string ChoiceText { get; set; }
        public int IsCorrect { get; set; }
        public Questions Questions { get; set; }

    }
}
