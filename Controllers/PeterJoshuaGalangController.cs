using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Galang, Peter Joshua")]   
    public class PeterJoshuaGalangController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Peter Joshua Galang",
                Tagline = "BS Information Technology Student | IT Elective 2",                                   
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/GalangPeterJoshua.png",
                Email = "peterjoshua.pjg@gmail.com",
                GitHubUrl = "https://github.com/peterjoshuapjg",
                LinkedInUrl = null,
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "ASP.NET Core Web API", "Entity Framework Core", "SQLite", "Bootstrap" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT31EE3_PRELIM_A1_GALANG_PETERJOSHUA",
                        Description = "FizzBuzz console program that prints 1 to 100, practising loops, conditionals and the modulo operator.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT31EE3_PRELIM_A2_GALANG_PETERJOSHUA",
                        Description = "Console calculator that loops on two numbers and an operator until the user types \"exit\", guarding against division by zero and invalid operators.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT31E3_PRELIM_A3_GALANG_PETERJOSHUA",
                        Description = "Two-project solution: an ASP.NET Core Web API supporting GET, POST, PUT and DELETE, and an HttpClient console app that calls it and prints the response.",
                        TechStack = new List<string> { "C#", "ASP.NET Core Web API", "HttpClient" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-on 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT31E3_PRELIM_H1_GALANG_PETERJOSHUA",
                        Description = "Menu-driven student grade manager that adds students, shows each average, computes the class average and finds the top grade.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-on 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT31E3_PRELIM_H2_Galang_PeterJoshua",
                        Description = "File reader engine for TXT, CSV, JSON and XML using the Strategy and Factory patterns.",
                        TechStack = new List<string> { "C#", "Console", "Strategy & Factory" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT_31E1_PRELIM_Q1_Galang_PeterJoshua",
                        Description = "Transport model challenge using a Vehicle base class, interfaces and a factory, with a built-in PASS/FAIL test run.",
                        TechStack = new List<string> { "C#", "Console", "OOP" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Activity 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/peterjoshuapjg/IT_ELECTIVE_2_Midterm_A1_Galang_PeterJoshua",
                        Description = "Personal portfolio website with a fixed sidebar linking Home, About Me, Skills, Projects and Contact sections.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "Bootstrap" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Project",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/peterjoshuapjg/IT_ELECTIVE_2_BSIT_31E3_Galang_PeterJoshua",
                        Description = "Login page demonstrating model binding, Data Annotations and ModelState validation with hard-coded credentials.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "Model Binding", "Data Annotations" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/peterjoshuapjg/IT_ELECTIVE_2_MIDTERM_Q2_Galang_PeterJoshua",
                        Description = "Playlist builder for YouTube links with session-based login, a custom AuthorizeSession filter and an in-memory mock database.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "Session", "Action Filters" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Hands-on 1–3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT31E3_IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Galang_PeterJoshua",
                        Description = "Pizza Corner point-of-sale system with a stock-aware cart, checkout and order history, using in-memory repositories.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "Bootstrap 5" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/peterjoshuapjg/IT_ELECTIVE_2_MIDTERM_EXAM_2_GalangPeterJoshua",
                        Description = "Clinic patient visit monitoring system with cookie authentication, visit status tracking, search and edit views.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "Cookie Auth", "Repository Pattern" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/peterjoshuapjg/BSIT31E3_IT_ELECTIVE_2_MIDTERM_Q3_Galang_PeterJoshua",
                        Description = "Cookie authentication with login, password reset and change, and account lockout after repeated failed attempts.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "Cookie Auth", "[Authorize]" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Group Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo",
                        Description = "HelpDesk ticketing system built with groupmates Pelarca and Romulo, covering tickets, assignments, comments, attachments and workload monitoring.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "Entity Framework Core", "SQLite" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/peterjoshuapjg/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Galang_PeterJoshua",
                        Description = "20-question exam interface with question-number navigation and Previous/Next buttons, using read-only hard-coded answers.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Quiz",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/peterjoshuapjg/IT_ELECTIVE_2_BSIT31E3_PREFINALS_QUIZ_PETERJOSHUA_GALANG.git",
                        Description = "Personal portfolio website that showcases my IT Elective 2 projects, with project details pages and sign-in-only comments.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }  
                    }
                }
            };

            return View(profile);
        }
    }
}
