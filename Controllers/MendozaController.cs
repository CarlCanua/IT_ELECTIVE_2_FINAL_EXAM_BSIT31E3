using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Vaughn Matthew Mendoza's portfolio merged into the FINAL EXAM structure.
    // The controller intentionally uses the final-exam project's existing models.
    [Classmate("Vaughn Mendoza")]
    public class VaughnMendozaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Vaughn Mendoza",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelim, Midterm, and Pre-Finals activities, quizzes, and projects.",
                PhotoPath = "~/images/vaughn.jpg",
                Email = "vaughnmendoza@gmail.com",
                GitHubUrl = "https://github.com/VaughnMatt",
                Skills = new List
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "MVC",
                    "Razor",
                    "HTML",
                    "CSS",
                    "Git",
                    "GitHub"
                },
                Projects = new List
                {
                    new ProjectItem
                    {
                        Title = "Personality Test",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/VaughnMatt/PersonalityTest",
                        Description = "An interactive personality test application that allows users to answer questions and discover their personality type.",
                        TechStack = new List { "C#", "ASP.NET Core MVC", "HTML", "CSS" },
                        ImagePath = "~/images/projects/personality-test.png"
                    },
                    new ProjectItem
                    {
                        Title = "Hackathon - Personality Test",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/dominicbillena06-prog/Hackthon---Personality-test",
                        Description = "A personality test application developed as part of a hackathon project focusing on interactive user testing.",
                        TechStack = new List { "C#", "ASP.NET Core MVC", "HTML", "CSS" },
                        ImagePath = "~/images/projects/hackathon-personality-test.png"
                    },
                    new ProjectItem
                    {
                        Title = "H1, H2, H3 Activities",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/VaughnMatt/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Mendoza",
                        Description = "A collection of activities and exercises completed for the IT Elective 2 midterm assessment requirements.",
                        TechStack = new List { "C#", "ASP.NET Core MVC", "HTML", "CSS" },
                        ImagePath = "~/images/projects/midterm-h1-h2-h3.png"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/VaughnMatt/IT_ELECTIVE_2_PRELIM_EXAM_VAUGHNN_MENDOZA",
                        Description = "A web development project created for the IT Elective 2 preliminary examination demonstrating key concepts covered in the course.",
                        TechStack = new List { "C#", "ASP.NET Core MVC", "HTML", "CSS" },
                        ImagePath = "~/images/projects/prelim-exam.png"
                    }
                }
            };

            return View(profile);
        }
    }
}