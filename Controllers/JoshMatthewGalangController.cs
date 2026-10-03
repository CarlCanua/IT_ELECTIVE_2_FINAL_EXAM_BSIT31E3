using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Galang, Josh Matthew S.")]
    public class JoshMatthewGalangController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Josh Matthew Galang",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "BSIT student building projects and completing coursework in programming, web development, and IT.",
                PhotoPath = "~/images/josh.jpg",
                Email = "YOUR_EMAIL_HERE",
                GitHubUrl = "https://github.com/Josh-Galang",

                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "MVC",
                    "HTML",
                    "CSS",
                    "Bootstrap",
                    "Git",
                    "GitHub"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Homework 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Josh-Galang/BSIT31E3_PRELIM_H1_GALANG_JOSH",
                        Description = "Prelim homework project for BSIT31E3.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Homework 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Josh-Galang/BSIT31E3_PRELIM_H2_GALANG_JOSH",
                        Description = "Second prelim homework project for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Josh-Galang/IT_ELECTIVE_2_PRELIM_EXAM_Galang_JoshMatthew",
                        Description = "Prelim examination project for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Activity 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Josh-Galang/IT_ELECTIVE_2_Midterm_A1_Galang_Josh",
                        Description = "Midterm activity for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Homeworks 1-3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Josh-Galang/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Galang_Josh",
                        Description = "Collection of midterm homework activities.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam Set 6",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Josh-Galang/IT_ELECTIVE_2_MIDTERM_EXAM_SET6_GALANG",
                        Description = "Midterm examination project for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Homework 1",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/Josh-Galang/BSIT31E3_PREFINALS-H1-GALANG_JOSH",
                        Description = "Prefinals homework project for BSIT31E3.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/Josh-Galang/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_GALANG_JOSH",
                        Description = "Prefinals examination project for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective Course Repository",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Josh-Galang/IT_ELECTIVE_BSIT_31E3_GALANG_JOSH",
                        Description = "Repository containing IT Elective coursework and projects.",
                        TechStack = new List<string> { "C#", ".NET", "GitHub" }
                    }
                }
            };

            return View(profile);
        }
    }
}
