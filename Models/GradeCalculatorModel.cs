using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _415_HW1.Models
{
    public class GradeCalculatorModel
    {
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for Assignments")]
        public double Assignments { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for Group Projects")]
        public double GroupProjects { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for Quizzes")]
        public double Quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for Exams")]
        public double Exams { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for Intex")]
        public double Intex { get; set; }
    }
}
