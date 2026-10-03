using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Esguerra, Ma. Corolla Anne M.")]
    public class MaCorollaEsguerraController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Ma. Corolla Esguerra",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelim, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/gli.jpg",
                Email = "",
                GitHubUrl = "https://github.com/MaCorollaEsguerra",
                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET MVC",
                    "ASP.NET Core",
                    "Razor",
                    "Bootstrap",
                    "Git",
                    "GitHub"
                },
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/BSIT31E3_PRELIM_A1_ESGUERRA_MA.-COROLLA",
                        Description = "The starting point of the course. This activity sets up an ASP.NET MVC project from scratch and walks through the request pipeline: a route reaches a controller action, the action passes a model to a view, and the view renders it with Razor. It is deliberately small so the moving parts stay visible.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Razor" },
                        ImagePath = "~/images/projects/prelim-a1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/BSIT31E3_PRELIM_A2_ESGUERRA_MA.COROLLA",
                        Description = "Builds on the first activity by adding input. A form posts back to the controller, model binding fills the view model, and data annotations reject anything invalid before it reaches the action body. Validation messages are rendered next to the fields that caused them.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Data annotations" },
                        ImagePath = "~/images/projects/prelim-a2.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/BSIT31E3_PRELIM_A3_ESGUERRA_MACOROLLA",
                        Description = "A pass over the view layer. Shared markup moves into a layout, repeated blocks become partial views, and the pages stop duplicating each other. The result is the same output with much less markup to maintain.",
                        TechStack = new List<string> { "ASP.NET MVC", "Razor", "Bootstrap" },
                        ImagePath = "~/images/projects/prelim-a3.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/BSIT31E3_PRELIM_H1_ESGUERRA_MA.COROLLA",
                        Description = "The graded hands-on for the prelim term. Everything from the three activities had to come together in one sitting: routing, a model, form handling with validation, and a layout that holds the pages together.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Razor" },
                        ImagePath = "~/images/projects/prelim-h1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 1 (pair repository)",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_H1_ROMULO_JEREMIAH",
                        Description = "A pair version of the prelim hands-on hosted on Jeremiah Romulo's account. Working from someone else's repository meant reading code written by another person before adding to it, which is closer to how real projects run than starting from an empty folder.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Git" },
                        ImagePath = "~/images/projects/prelim-h1-pair.svg"
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Working Repository",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/IT_ELECTIVE_BSIT_31E3_ESGUERRA_MA.COROLLA",
                        Description = "The catch-all repository for class work: small exercises, things tried during lectures, and experiments that did not need a repository of their own. It is the most honest record of the term because it shows the attempts that did not make it into the graded builds.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Git" },
                        ImagePath = "~/images/projects/it-elective-main.svg"
                    },
                    new ProjectItem
                    {
                        Title = "WebApplication1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/WebApplication1",
                        Description = "The default project name, kept on purpose. This is where new packages, scaffolding options and template settings get tried before they are used in something graded. Small, disposable, and useful exactly because nothing depends on it.",
                        TechStack = new List<string> { "ASP.NET", "C#", "NuGet" },
                        ImagePath = "~/images/projects/webapplication1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_2_MIDTERM_Q1",
                        Description = "A quiz answered as a team on the section's shared account. The interesting part was coordination: agreeing who owned which file so the work merged without stepping on each other, and keeping commits small enough to review.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Git" },
                        ImagePath = "~/images/projects/midterm-q1.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/IT_ELECTIVE_2_MIDTERM_Q3",
                        Description = "A solo quiz covering how a controller decides what to hand a view, and how the view renders a collection without putting logic where it does not belong. Short, focused, and graded on whether the separation holds.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Razor" },
                        ImagePath = "~/images/projects/midterm-q3.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3 (team repository)",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_2_MIDTERM_Q3",
                        Description = "The same quiz submitted through the section repository. Putting it next to the solo version is useful: two groups solved the same problem differently, and the differences in structure are easier to judge when the requirements are identical.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Git" },
                        ImagePath = "~/images/projects/midterm-q3-team.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Hands-On 1 to 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/IT_ELECTIVE_2_MIDTERM_H1_H2_H3",
                        Description = "The three midterm hands-on tasks live together so the progression is easy to follow. Each one adds something the previous did not have, and keeping them in one place makes it obvious which parts were reused and which were rewritten.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Razor" },
                        ImagePath = "~/images/projects/midterm-h1-h2-h3.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam - Item 9",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/IT_ELECTIVE_2_MIDTERM_EXAM_9_ESGUERRA",
                        Description = "The midterm exam answer. One problem, one sitting, no reference material. The constraint changes how you write: you reach for the pattern you already know works instead of trying something new halfway through.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#" },
                        ImagePath = "~/images/projects/midterm-exam-9.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Single Sign-On Integration",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A3",
                        Description = "A step past hardcoded credentials: signing users in through an external identity provider instead of checking a username and password in the application itself. It forces you to understand what a login actually is - a claims principal issued by something you trust, carried in a cookie - rather than treating it as a single if statement.",
                        TechStack = new List<string> { "ASP.NET", "Authentication", "OAuth" },
                        ImagePath = "~/images/projects/sso.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/MaCorollaEsguerra/-IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_ESGUERRA_MA.-COROLLA",
                        Description = "The prefinal exam build. Everything from the term was fair game, so the work was as much about deciding what to build first as about writing it. The structure had to hold up without any refactoring time at the end.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Razor" },
                        ImagePath = "~/images/projects/prefinal-exam.svg"
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Group Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/yuwanandrei/IT_ELECTIVE_PREFINALS_PROJECT_Esguerra_GalangJM_Gregorio",
                        Description = "The largest build of the term and the only one with three people in it. Scope had to be agreed before anyone started, the work was split so two people were never editing the same file, and the repository history shows how the pieces came together at the end.",
                        TechStack = new List<string> { "ASP.NET MVC", "C#", "Git", "Bootstrap" },
                        ImagePath = "~/images/projects/prefinals-project.svg"
                    }
                }
            };

            return View(profile);
        }
    }
}
