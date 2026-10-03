using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Honor, Bryll Christian J.")]
    public class BryllHonorController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Bryll Christian J. Honor",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "This portfolio presents my IT Elective 2 coursework, including prelim activities, quizzes, homework, a group project, and a prefinal exam. The projects demonstrate practice with C#, .NET, and GitHub.",
                PhotoPath = "~/images/honor.jpg",
                Email = "honorbryll7@gmail.com",
                GitHubUrl = "https://github.com/BryllHonor",
                Skills = new List<string> { "C#", ".NET", "ASP.NET Core", "Git", "GitHub", "Web Development" },
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Activity 1", Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/BryllHonor/BSIT31E3_A1_HONOR_BRYLL",
                        Description = "First graded activity for BSIT 31E3, creating a working C#/.NET project and committing it to source control.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/a1-honor-bryll.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Activity 2", Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/BryllHonor/BSIT31E3_A2_HONOR_BRYLL",
                        Description = "Follow-up activity applying programming topics covered in class.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/a2-honor-bryll.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Quiz 1", Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/BryllHonor/BSIT_31E3_PRELIM_Q1_HONOR_BRYLL",
                        Description = "Timed prelim quiz programming exercise.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/prelim-q1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prelims Homework 1", Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/BryllHonor/BSIT-31E3_PRELIMS_H1_HONOR_BRYLL",
                        Description = "Take-home exercise practicing programming fundamentals.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/prelims-h1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prelims Activity 3", Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/BryllHonor/BSIT31E3_PRELIMS_A3_HONOR_BRYLL",
                        Description = "Third prelim activity combining topics from earlier lessons.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/prelims-a3.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Activity 1", Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BryllHonor/IT_ELECTIVE_2_Midterm_A1_Honor_Bryll",
                        Description = "Opening activity for the IT Elective 2 midterm term.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/midterm-a1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Project", Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BryllHonor/BSIT-31E3-MIDTERM--PROJECT-HONOR-CANUA-ROMULO",
                        Description = "Group midterm project developed with teammates Canua and Romulo.",
                        TechStack = new List<string> { "C#", ".NET", "Team project" },
                        ImagePath = "~/images/bryll-projects/midterm-project.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective Coursework", Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BryllHonor/IT_ELECTIVE_BSIT_31E3_HONOR_BRYLL",
                        Description = "Repository for exercises and coursework across the IT Elective track.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/it-elective-base.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 2", Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BryllHonor/IT_ELECTIVE_2_MIDTERM_Q2_Honor_Bryll",
                        Description = "Second timed quiz for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/midterm-q2.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3", Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BryllHonor/IT_ELECTIVE_2_MIDTERM_Q3",
                        Description = "Third quiz in the midterm quiz series.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/midterm-q3.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam 9", Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BryllHonor/IT_ELECTIVE_2_MIDTERM_EXAM_9_HONOR",
                        Description = "Individual practical exam submission for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/midterm-exam-9.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Exam", Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/BryllHonor/IT_ELECTIVE_2_BSIT-31E3_PREFINAL_EXAM_Honor_Bryll",
                        Description = "Prefinal exam submission for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/bryll-projects/prefinal-exam.svg"
                    }
                }
            };

            return View(profile);
        }
    }
}
