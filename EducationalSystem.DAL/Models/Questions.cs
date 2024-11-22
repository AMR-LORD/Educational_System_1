using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Questions 
    {
        [Key]
        public int QuestionID { get; set; }
        [ForeignKey(nameof(Assessments))]
        public int AssessmentID { get; set; }
        public string QuestionText { get; set; }
        [ForeignKey(nameof(QuestionType))]
        public int QuestionTypeID { get; set; }
        public int Points { get; set; }
        public ICollection<Choices> Choices { get; set; }
        public QuestionType QuestionType { get; set; }
        public Assessments Assessments { get; set; }
    }
}
