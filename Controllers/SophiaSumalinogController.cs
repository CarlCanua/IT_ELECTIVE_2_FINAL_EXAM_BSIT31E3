using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Sophia Sumalinog's portfolio merged into the FINAL EXAM structure.
    // The controller intentionally uses the final-exam project's existing models.
    [Classmate("Sophia Sumalinog")]
    public class SophiaSumalinogController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Sophia Sumalinog",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "\"C:\\Users\\STUDENT\\Downloads\\sumalinog.jpg\"",
                Email = "c1982-24@itmlyceumalabang.onmicrosoft.com",
                GitHubUrl = "https://github.com/AceySumalinog",
                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "GitHub",
                    "Git",
                    "Web Development"
                },
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                Id = 1,
                Title = "FizzBuzz Program",
                Description = "A C# console application implementing the classic FizzBuzz programming problem.",
                GitHubUrl = "https://github.com/AceySumalinog/BSIT31E3_PRELIM_A1_SUMALINOG_SOPHIA",
                ThumbnailUrl = "/images/project1.png",
                Technologies = "C#"
            },

            new Project
            {
                Id = 2,
                Title = "Calculator Application",
                Description = "A C# calculator application with loops, user input handling, and validation.",
                GitHubUrl = "https://github.com/AceySumalinog/BSIT31E3_PRELIM_A2_SUMALINOG_SOPHIA",
                ThumbnailUrl = "/images/project2.png",
                Technologies = "C#"
            },

            new Project
            {
                Id = 3,
                Title = "Student Management System",
                Description = "A procedural C# student management system designed to manage student information.",
                GitHubUrl = "https://github.com/AceySumalinog/BSIT31E3_PRELIM_H1_SUMALINOG_SOPHIA",
                ThumbnailUrl = "/images/project3.png",
                Technologies = "C#"
            },

            new Project
            {
                Id = 4,
                Title = "Transport Resolver",
                Description = "An object-oriented C# application demonstrating interfaces and different types of transportation.",
                GitHubUrl = "https://github.com/AceySumalinog/BSIT_31E3_PRELIM_Q1_SUMALINOG_SOPHIA",
                ThumbnailUrl = "/images/project4.png",
                Technologies = "C#, OOP"
            },

            new Project
            {
                Id = 5,
                Title = "OOP & REST API Project",
                Description = "A C# project demonstrating object-oriented programming principles and HTTP Client REST API consumption.",
                GitHubUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_PRELIM_EXAM_SUMALINOG_SOPHIA",
                ThumbnailUrl = "/images/project5.png",
                Technologies = "C#, .NET, REST API"
            },

            new Project
            {
                Id = 6,
                Title = "Playlist Application",
                Description = "An ASP.NET Core MVC playlist application with authentication and session-based access.",
                GitHubUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_Q2_Sumalinog_Sophia",
                ThumbnailUrl = "/images/project6.png",
                Technologies = "ASP.NET Core MVC, C#, Bootstrap"
            },

            new Project
            {
                Id = 7,
                Title = "IT Elective 2 Assignment 1",
                Description = "A C# programming assignment completed as part of the IT Elective 2 coursework.",
                GitHubUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_Midterm_A1_Sumalinog_Sophia",
                ThumbnailUrl = "/images/project7.png",
                Technologies = "C#"
            },

            new Project
            {
                Id = 8,
                Title = "Chapter One POS System",
                Description = "A Point of Sale web application for a specialty Manga and Manhwa bookstore.",
                GitHubUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Sumalinog_Sophia",
                ThumbnailUrl = "/images/project8.png",
                Technologies = "ASP.NET Core, C#, HTML, CSS, JavaScript"
            },

            new Project
            {
                Id = 9,
                Title = "MVC.Auth Portfolio Guard",
                Description = "An ASP.NET MVC authentication project featuring login, logout, forgot password, and change password functionality.",
                GitHubUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_Q3_Sumalinog_Sophia",
                ThumbnailUrl = "/images/project9.png",
                Technologies = "ASP.NET Core MVC, C#, HTML, CSS"
            },

            new Project
            {
                Id = 10,
                Title = "Vehicle Service Monitoring System",
                Description = "A system designed to monitor vehicle service and maintenance information.",
                GitHubUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_EXAM_1_Sumalinog_Sophia",
                ThumbnailUrl = "/images/project10.png",
                Technologies = "C#, .NET"
            },

            new Project
            {
                Id = 11,
                Title = "Manhwa Level-Up MVC System",
                Description = "A creative ASP.NET Core MVC exam application inspired by a manhwa level-up system.",
                GitHubUrl = "https://github.com/AceySumalinog/-IT_ELECTIVE_2_-BSIT-31E3-_PREFINAL_EXAM_Sumalinog_Sophia",
                ThumbnailUrl = "/images/proj11.png",
                Technologies = "ASP.NET Core MVC, C#, HTML, CSS, JavaScript"
            }
                }
            };

            return View(profile);
        }
    }
}
