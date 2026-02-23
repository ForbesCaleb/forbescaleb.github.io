namespace CV_Program_ICE_Task_1.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Subtitle { get; set; }       // e.g. "ASP.NET Core MVC - 1st Year"
        public string Description { get; set; }    // short summary
        public string TechStack { get; set; }      // optional
        public string GitHubUrl { get; set; }      // must include at least one real GitHub link

        public List<string> Bullets { get; set; } = new();
    }
}