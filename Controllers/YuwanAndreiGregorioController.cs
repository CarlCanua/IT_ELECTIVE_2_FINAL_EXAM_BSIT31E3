using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Yuwan Andrei Gregorio's portfolio merged into the FINAL EXAM structure.
    // The controller intentionally uses the final-exam project's existing models.
    [Classmate("Gregorio, Yuwan Andrei ")]
    public class YuwanAndreiGregorioController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Yuwan Andrei Gregorio",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/yuwan.jpg",
                Email = "yuwanandrei@gmail.com",
                GitHubUrl = "https://github.com/yuwanandrei",
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
                        Title = "Student Management System",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/yuwanandrei/BSIT31E1_PRELIM_H1_GREGORIO_YUWAN.git",
                        Description = "A student management app for adding, viewing, updating and removing student records.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/prelim-student-management-system.png"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/yuwanandrei/BSIT31E3_Prelim_A1_GregorioYuwanAndrei.git",
                        Description = "First graded hands-on activity of the Prelim term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/prelim-activity-1.png"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/yuwanandrei/BSIT31E3_Prelim_A2_GregorioYuwanAndrei.git",
                        Description = "Second graded hands-on activity of the Prelim term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/prelim-activity-2.png"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/yuwanandrei/BSIT31E3_PRELIM_A3_Gregorio_YuwanAndrei.git",
                        Description = "Third graded hands-on activity of the Prelim term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/prelim-activity-3.png"
                    },
                    new ProjectItem
                    {
                        Title = "Transport Resolver Challenge",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/yuwanandrei/BSIT_-section-_PRELIM_Q1_Gregorio_YuwanAndrei.git",
                        Description = "Prelim quiz: the Transport Resolver Challenge.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/prelim-quiz-transport-resolver.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Activity 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_2_Midterm_A1_Gregorio_YuwanAndrei.git",
                        Description = "Hands-on activity from the Midterm term of IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-activity-1.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Project",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_BSIT_31E1_Gregorio_YuwanAndrei.git",
                        Description = "The main project for the Midterm term of IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-project.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_2_MIDTERM_Q2_Gregorio_YuwanAndrei.git",
                        Description = "Second quiz of the Midterm term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-quiz-2.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_2_MIDTERM_Q3.git",
                        Description = "Third quiz of the Midterm term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-quiz-3.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_2_MIDTERM_EXAM_2_Gregorio_YuwanAndrei.git",
                        Description = "Practical exam for the Midterm term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-exam.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Homework 1 to 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                        Description = "Homework tasks 1, 2 and 3 from the Midterm term, kept in one repository.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-homework-1-3.png"
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_PREFINALS_PROJECT_Esguerra_GalangJM_Gregorio.git",
                        Description = "Team project for the Prefinals term.",
                        TechStack = new List<string> { "C#", ".NET", "GitHub" },
                        ImagePath = "~/images/projects/prefinals-project.png"
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Gregorio_YuwanAndrei.git",
                        Description = "Practical exam for the Prefinals term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/prefinals-exam.png"
                    }
                }
            };

            return View(profile);
        }
    }
}
