using Microsoft.AspNetCore.Identity;

namespace EducationalSystem.DAL.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string ProfileImageURL { get; set; }
        public Instructors Instructors { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Lesson_Completions> Lesson_Completions { get; set; }
        public ICollection<Assessment_Results> Assessment_Results { get; set; }
        public ICollection<Progress> progresses { get; set; }

        /*o One-to-Many with Instructors
o One-to-Many with Comments
o One-to-Many with Lesson_Completions
o One-to-Many with Assessment_Results
o One-to-Many with Progress
*/
    }
}
