﻿namespace EducationalSystem.Models
{
    public class Choices
    {
        public int ChoiceID { get; set; } 
        public int QuestionID { get; set; }
        public string ChoiceText { get; set; }
        public int IsCorrect { get; set; }


    }
}
