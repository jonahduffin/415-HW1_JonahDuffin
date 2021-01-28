using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _415_HW1.Models;

namespace _415_HW1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GradeCalculator")]
        public IActionResult GradeCalculator()
        {
            ViewBag.Percentage = "0%";
            return View();
        }

        [HttpPost("GradeCalculator")]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            double assignments = model.Assignments;
            double groupprojects = model.GroupProjects;
            double quizzes = model.Quizzes;
            double exams = model.Exams;
            double intex = model.Intex;
            double finalgrade = (.5 * assignments) + (.1 * groupprojects) + (.1 * quizzes) + (.2 * exams) + (.1 * intex);

            if (finalgrade > 0 && finalgrade <= 100
                && assignments > 0 && assignments <= 100
                && groupprojects > 0 && groupprojects <= 100
                && quizzes > 0 && quizzes <= 100
                && exams > 0 && exams <= 100
                && intex > 0 && intex <= 100)
            {
                string lettergrade;

                if (finalgrade >= 94)
                    lettergrade = "A";
                else if (finalgrade >= 90)
                    lettergrade = "A-";
                else if (finalgrade >= 87)
                    lettergrade = "B+";
                else if (finalgrade >= 84)
                    lettergrade = "B";
                else if (finalgrade >= 80)
                    lettergrade = "B-";
                else if (finalgrade >= 77)
                    lettergrade = "C+";
                else if (finalgrade >= 74)
                    lettergrade = "C";
                else if (finalgrade >= 70)
                    lettergrade = "C-";
                else if (finalgrade >= 67)
                    lettergrade = "D+";
                else if (finalgrade >= 64)
                    lettergrade = "D";
                else if (finalgrade >= 60)
                    lettergrade = "D-";
                else
                    lettergrade = "E";

                string gradeoutput = finalgrade.ToString("#.##") + "% " + lettergrade;
                ViewBag.Percentage = gradeoutput;
            }
            else
            {
                ViewBag.Percentage = "0%";
            }
            
            return View();
        }
    }
}
