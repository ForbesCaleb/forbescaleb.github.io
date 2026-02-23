using System.Collections.Generic;

namespace CV_Program_ICE_Task_1.Models
{
    public class Profile
    {
        public string FullName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // ✅ GitHub profile link
        public string GitHubUser { get; set; }

        public string ProfessionalSummary { get; set; }

        public List<string> TechnicalSkills { get; set; } = new();
        public List<string> SoftSkills { get; set; } = new();

        public string Qualification { get; set; }
        public string Institution { get; set; }
        public string YearInfo { get; set; }

        public List<string> RelevantCoursework { get; set; } = new();

        public List<Project> Projects { get; set; } = new();

        public string WorkTitle { get; set; }
        public string WorkPlace { get; set; }

        public List<string> WorkBullets { get; set; } = new();

        public List<string> Certifications { get; set; } = new();

        public string ReferencesNote { get; set; }
    }
}