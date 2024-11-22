using System.ComponentModel.DataAnnotations;

namespace EducationalSystem.DAL.Models
{
    public class Categories 
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Courses> Courses { get; set; }
    }
}
