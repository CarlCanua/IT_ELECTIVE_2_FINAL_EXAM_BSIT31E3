using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Dominic Billena")]
    public class DominicBillenaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Dominic Billena",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolioo for IT Elective 2, covering Prelim, Midterm, and Pre-Finals activities, quizzes, and projects.",
                PhotoPath = "~/images/dominic.jpg",
                Email = "dominicbillena06@gmail.com",
                GitHubUrl = "https://github.com/dominicbillena06-prog",
                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "MVC",
                    "Razor",
                    "Git",
                    "GitHub",
                    "GitHub Desktop"
                },
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "C# FizzBuzz Challenge",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/dominicbillena06-prog/BSIT31EE1_PRELIM_A1_Billena_Dominic",
                        Description = "A C# console application implementing the classic FizzBuzz programming challenge using loops, conditional statements, and user input.",
                        TechStack = new List<string> { "C#", ".NET", "Visual Studio", "GitHub Desktop" },
                        ImagePath = "~/images/projects/fizzbuzz.png"
                    },
                    new ProjectItem
                    {
                        Title = "C# Calculator Challenge",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/dominicbillena06-prog/BSIT31E-x-_PRELIM_A2_Billena_Dominic",
                        Description = "A C# calculator application demonstrating arithmetic operations, user input, validation, and basic programming logic.",
                        TechStack = new List<string> { "C#", ".NET", "Visual Studio", "GitHub Desktop" },
                        ImagePath = "~/images/projects/calculator.png"
                    },
                    new ProjectItem
                    {
                        Title = "File Ingestion Engine",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/dominicbillena06-prog/BSIT31E3_PRELIM_H2_billena_dominic",
                        Description = "A C# file ingestion application designed to process different file types through separate reader implementations and a resolver-based architecture.",
                        TechStack = new List<string> { "C#", "Interfaces", "File Processing", "Strategy Pattern" },
                        ImagePath = "~/images/projects/file-ingestion-engine.png"
                    },
                    new ProjectItem
                    {
                        Title = "Personal Portfolio Website",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/dominicbillena06-prog/IT_ELECTIVE_2_Assignment_One_Billena_Dominic",
                        Description = "A responsive personal portfolio website created using ASP.NET Core MVC, Razor Views, and Bootstrap 5.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Razor", "Bootstrap 5" },
                        ImagePath = "~/images/projects/personal-portfolio.png"
                    },
                    new ProjectItem
                    {
                        Title = "MVC Model Binding",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/dominicbillena06-prog/IT_ELECTIVE_BSIT_-BSIT31E3-_-lBILLENA_DOMINIC---MIDTERM--PROJECT",
                        Description = "An ASP.NET Core MVC project demonstrating model binding and how submitted form data is transferred into C# model objects.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Razor", "Model Binding" },
                        ImagePath = "~/images/projects/mvc-model-binding.png"
                    },
                    new ProjectItem
                    {
                        Title = "MVC Authentication System",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/dominicbillena06-prog/BILLENA_IT_ELECTIVE_2_MIDTERM_Q3",
                        Description = "An ASP.NET Core MVC authentication project implementing login, logout, password functionality, account locking, and protected portfolio pages.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Authentication", "Authorization" },
                        ImagePath = "~/images/projects/mvc-authentication.png"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective Pre-Finals Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/dominicbillena06-prog/IT_ELECTIVE_PREFINALS_PROJECT_Billena_Pantaleon_Mendoza",
                        Description = "A group ASP.NET Core MVC project created for IT Elective 2 Pre-Finals. The project focuses on collaborative development, individual commits, pull requests, and application implementation.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "EF Core", "SQLite", "GitHub" },
                        ImagePath = "~/images/projects/prefinals-project.png"
                    },
                    new ProjectItem
                    {
                        Title = "Pre-Finals Quiz",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/dominicbillena06-prog/Billena_PREFINALS---QUIZ",
                        Description = "A Pre-Finals quiz project created as part of the IT Elective coursework. This project is included in the portfolio as one of the completed academic projects.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "Visual Studio", "GitHub" },
                        ImagePath = "~/images/projects/prefinals-quiz.png"
                    }
                }
            };

            return View(profile);
        }
    }
}