﻿using System.ComponentModel.DataAnnotations;

namespace EducationalSystem.DAL.Models
{
    public class Categories : BaseEntity
    {

        public string CategoryName { get; set; }
        public ICollection<Courses> Courses { get; set; }
    }
}
