using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // Harvey Ischei Pelarca's portfolio merged into the final exam project.
    // This controller uses the final exam project's existing portfolio design.
    [Classmate("Pelarca Harvey Ischei")]
    public class HarveyIscheiPelarcaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Harvey Ischei Pelarca",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "BS Information Technology student showcasing selected projects and coursework from IT Elective 2.",
                PhotoPath = "~/images/harvey.jpg",
                Email = "",
                GitHubUrl = "https://github.com/ishpo29",

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
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTIVE_2_PRELIM_EXAM_Pelarca_Harvey",
                        Description = "Practical exam project completed during the Prelim term of IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective Coursework",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTIVE_BSIT_31E3_Pelarca_Harvey",
                        Description = "IT Elective 2 coursework repository containing Harvey's development activities and course work.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "GitHub"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Exam — Set 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTIVE_2_MIDTERM_EXAM_SET1_Pelarca_Harvey",
                        Description = "Practical Midterm examination project for IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Homeworks H1–H3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Pelarca_Harvey",
                        Description = "Collection of Midterm homework activities 1, 2, and 3 completed for IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinals Group Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo",
                        Description = "Group project completed during the Prefinals term of IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "GitHub"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/ishpo29/IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY",
                        Description = "Practical Prefinal examination project for IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    }
                }
            };

            return View(profile);
        }
    }
}