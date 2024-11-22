using System.ComponentModel.DataAnnotations;

namespace EducationalSystem.DAL.Models
{
    public class QuestionType
    {
        [Key]
        public int QuestionTypeID { get; set; }
        public string QuestionTypeName { get; set; }

    }
}
