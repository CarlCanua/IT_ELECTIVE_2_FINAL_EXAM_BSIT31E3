namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models
{
    public class ProjectItem
    {
        public string Title { get; set; } = "";
        public ProjectStage Stage { get; set; }
        public string RepoUrl { get; set; } = "";
        public string? LiveUrl { get; set; }
        public string Description { get; set; } = "";
        public List<string> TechStack { get; set; } = new();
        // Optional screenshot used by portfolios that have project images.
        public string? ImagePath { get; set; }
    }
}
