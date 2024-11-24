using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalSystem.DAL.Models
{
    public class Discounts : BaseEntity
    {

        [ForeignKey(nameof(Courses))]
        public int CourseID { get; set; }
        public int DiscountValue { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public Courses Courses { get; set; }
    }
}
