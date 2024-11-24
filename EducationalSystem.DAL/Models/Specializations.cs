using System.ComponentModel.DataAnnotations;

namespace EducationalSystem.DAL.Models
{
    public class Specializations : BaseEntity
    {
        public string SpecializationName { get; set; }
        public ICollection<Instructor_Specializations> Instructor_Specializations { get; set; }

    }
}
