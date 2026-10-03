using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Canua, Carl James P.")]   // shown on the Home list; sorted by surname
    public class CanuaCarlJamesController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Carl James P. Canua",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "I'm an aspiring developer who loves creating web apps and working with databases. My goal is to keep learning C# and modern technology to build simple, useful software.",
                PhotoPath = "~/images/CanuaCarlJames.jpg",
                Email = "canuacarljames@email.com",
                GitHubUrl = "https://github.com/CarlCanua",

                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET Core MVC",
                    "SQL",
                    "HTML/CSS",
                    "Git"
                },

                // Keep these in Prelim → Midterm → PreFinal order
                Projects = new List<ProjectItem>
                {
                    // =========================
                    // PRELIM
                    // =========================

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 - Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/CarlCanua/BSIT_31E3_PRELIM_A1_CANUA_CARL.git",
                        Description = "Prelim Activity 1 demonstrating fundamental C# programming concepts and application development.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "Programming Fundamentals"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 - Prelim Activity 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/CarlCanua/BSIT_31E3_PRELIM_A2_CANUA.git",
                        Description = "Prelim Activity 2 focused on C# programming logic, user input, and application processing.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "Control Flow"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 - Prelim Hands-On 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/CarlCanua/-BSIT31E3_PRELIM_H1_CANUA.git",
                        Description = "Prelim hands-on activity implementing practical C# programming exercises.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "Hands-On Programming"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 - Prelim Hands-On 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/CarlCanua/BSIT_31E3_PRELIM_H2_CANUA_CARL.git",
                        Description = "Prelim hands-on activity focused on programming logic and practical C# implementation.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "Programming Logic"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 - Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/CarlCanua/BSIT-31E3_PRELIMS_Q1_CANUA_CARL.git",
                        Description = "Prelim Quiz 1 covering fundamental programming concepts, syntax, and C# basics.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 - Prelim Activity 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/CarlCanua/BSIT-31E3_PRELIMS_A3_CANUA_CARL.git",
                        Description = "Prelim Activity 3 applying programming fundamentals through a practical C# application.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "Application Development"
                        }
                    },

                    // =========================
                    // MIDTERM
                    // =========================

                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Exam 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/CarlCanua/IT_ELECTIVE_2_MIDTERM_EXAM_7_CARL_CANUA.git",
                        Description = "Vehicle Service Monitoring System console application built for Midterm Exam 1.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "OOP"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/CarlCanua/IT_ELECTIVE_2_MIDTERM_Q2_CANUA_CARL_JAMES.git",
                        Description = "Midterm Quiz 2 demonstrating C# programming concepts, control structures, and application logic.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "Control Flow"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/CarlCanua/IT_ELECTIVE_2_MIDTERM_Q3_CANUA_CARL_JAMES.git",
                        Description = "Midterm Quiz 3 focused on object-oriented programming concepts and class-based programming.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "OOP",
                            "Encapsulation"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Hands-On 1, 2 & 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/CarlCanua/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_CANUA.git",
                        Description = "Consolidated midterm hands-on activities featuring interactive C# applications covering user input, arrays, loops, and programming logic.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Console",
                            "Arrays",
                            "Loops"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Assignment",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/CarlCanua/IT_ELECTIVE_2_Assignment_CarlJames.git",
                        Description = "IT Elective 2 programming assignment demonstrating applied C# programming and problem-solving.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Programming",
                            "Problem Solving"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "ASP.NET Core MVC Model Binding",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/CarlCanua/IT_ELECTIVE_BSIT_31E3_CANUA_CARL.git",
                        Description = "A simple Login Page application demonstrating Model Binding, Data Annotations, and ModelState validation without a database.",
                        TechStack = new List<string>
                        {
                            "ASP.NET Core MVC",
                            "C#",
                            "Data Annotations"
                        }
                    },

                    // =========================
                    // PREFINAL
                    // =========================

                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/CarlCanua/IT_ELECTIVE_2_31E3_PREFINAL_EXAM_Canua_Carl.git",
                        Description = "Prefinal examination project demonstrating practical application development using C# and ASP.NET Core.",
                        TechStack = new List<string>
                        {
                            "ASP.NET Core",
                            "C#",
                            "MVC"
                        }
                    }
                }
            };

            return View(profile);
        }
    }
}
