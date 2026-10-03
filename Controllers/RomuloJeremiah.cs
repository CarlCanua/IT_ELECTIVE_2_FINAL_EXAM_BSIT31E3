using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // Jeremiah Romulo's portfolio, built on the FINAL EXAM structure.
    // Uses the project's existing ClassmateProfile / ProjectItem models and the
    // shared _PortfolioProfile partial, so Home discovers it automatically.
    [Classmate("Romulo, Jeremiah")]
    public class JeremiahRomuloController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Jeremiah Romulo",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering my Prelim, Midterm, and Prefinals activities, quizzes, exams, and projects built with ASP.NET Core MVC.",
                PhotoPath = "~/images/default.png", // TODO: replace with ~/images/jeremiah.jpg after adding your photo
                Email = "your-email@example.com",   // TODO: put your real email here
                GitHubUrl = "https://github.com/Softjeeem",
                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core MVC",
                    "Git",
                    "GitHub",
                    "Web Development"
                },
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "BSIT31E3 Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_A1_ROMULO_JEREMIAHH.git",
                        Description = "First prelim activity for BSIT 31E3, focused on the fundamentals of MVC-based application structure and basic CRUD operations.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "BSIT31E3 Prelim Activity 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_A2_ROMULO_JEREMIAH.git",
                        Description = "Second prelim activity building on Activity 1, expanding the application's features and reinforcing MVC design patterns.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project2.svg"
                    },
                    new ProjectItem
                    {
                        Title = "BSIT31E3 Prelim Hands-on 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_H1_ROMULO_JEREMIAH.git",
                        Description = "Hands-on prelim exercise applying course concepts in a guided lab setting, emphasizing controller and view logic.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project3.svg"
                    },
                    new ProjectItem
                    {
                        Title = "BSIT31E3 Prelim Hands-on 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_H2_Romulo_Jeremiah.git",
                        Description = "Second hands-on prelim lab exercise, continuing to build practical skills with the MVC framework covered in class.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project4.svg"
                    },
                    new ProjectItem
                    {
                        Title = "BSIT31E3 Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Softjeeem/BSIT_31E3_PRELIM_Q1_ROMULO_JEREMIAH.git",
                        Description = "Prelim quiz project demonstrating understanding of core programming and application-design topics from the first grading period.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project5.svg"
                    },
                    new ProjectItem
                    {
                        Title = "BSIT31E3 Prelim Activity 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_A3_ROMULO_JEREMIAH.git",
                        Description = "Third prelim activity, further practicing application structure, data handling, and view rendering.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project6.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Activity 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_Midterm_A1_Romulo_Jeremiah.git",
                        Description = "First midterm activity for IT Elective 2, applying more advanced application-development concepts introduced mid-semester.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project7.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 (BSIT 31E3) Project",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Softjeeem/IT_ELECTIVE_BSIT_31E3_Romulo_Jeremiah.git",
                        Description = "A supporting project for IT Elective 2 that ties together concepts from the BSIT 31E3 curriculum into a working application.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project8.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_MIDTERM_Q2_Romulo_Jeremiah.git",
                        Description = "Midterm quiz project showcasing skills in application logic and feature implementation for the second grading milestone.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project9.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Softjeeem/ROMULO_JEREMIAH_IT_ELECTIVE_2_MIDTERM_Q3.git",
                        Description = "Midterm quiz 3 project, continuing to build out application features and demonstrating problem-solving under exam conditions.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project10.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Exam 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_MIDTERM_EXAM_3_ROMULO.git",
                        Description = "Third midterm examination project, a more comprehensive application built to demonstrate cumulative course learning.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project11.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Hands-on 1-3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                        Description = "A combined set of midterm hands-on lab exercises (H1 through H3), covering iterative feature additions across three sessions.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project12.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Pre-Final Group Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo.git",
                        Description = "A collaborative pre-final project for IT Elective 2 (BSIT 31E3), built together with groupmates PJ Galang and Pelarca, bringing the semester's concepts into one larger application.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project13.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Pre-Final Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_ROMULO_JEREMIAH.git",
                        Description = "Individual pre-final examination project, demonstrating independent mastery of application development concepts covered throughout the term.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core MVC" },
                        ImagePath = "~/images/projects/romulo-project14.svg"
                    }
                }
            };

            return View(profile);
        }
    }
}
