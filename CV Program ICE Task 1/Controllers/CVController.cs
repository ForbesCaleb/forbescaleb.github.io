using Microsoft.AspNetCore.Mvc;
using CV_Program_ICE_Task_1.Models;
using System.Collections.Generic;
using System.Linq;

namespace CV_Program_ICE_Task_1.Controllers
{
    public class CVController : Controller
    {
        // In-memory data (fine for ICE task). Later you can move to a DB.
        private static readonly Profile profile = new Profile
        {
            FullName = "Caleb Forbes",
            Location = "Johannesburg, South Africa",
            Phone = "072 931 0572",
            Email = "Caleb.forbes1@icloud.com",
            GitHubUser = "https://github.com/ForbesCaleb",

            ProfessionalSummary =
                "Motivated and detail-oriented individual with a strong interest in software development, cybersecurity, and business. " +
                "Experienced in problem-solving, technical projects, and continuous learning. Seeking opportunities to grow professionally " +
                "while contributing value to an organization.",

            TechnicalSkills = new List<string>
            {
                "Programming: C#, ASP.NET Core, SQL",
                "Web: HTML, CSS, JavaScript",
                "Databases: SQL Server, Azure Storage",
                "Tools: Git, GitHub, Visual Studio",
                "Cloud: Microsoft Azure (Basics)"
            },

            SoftSkills = new List<string>
            {
                "Problem-solving",
                "Communication",
                "Teamwork",
                "Time management",
                "Adaptability"
            },

            Qualification = "Qualification / Degree",
            Institution = "IIE MSA (now known as Emeris)",
            YearInfo = "Year 3",
            RelevantCoursework = new List<string>
            {
                "Systems Analysis",
                "Database Design",
                "Software Engineering"
            },

            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Name = "Event Booking System",
                    Subtitle = "ASP.NET Core MVC — 1st Year",
                    Description = "Web application focused on event booking with database + CRUD features and Azure integration.",
                    TechStack = "C#, ASP.NET Core MVC, SQL Server, Azure",
                    GitHubUrl = "https://github.com/ForbesCaleb/CalebForbes.github.iio.git", 
                    Bullets = new List<string>
                    {
                        "Designed database schema and implemented CRUD functionality",
                        "Integrated Azure services for storage and deployment"
                    }
                },
                new Project
                {
                    Id = 2,
                    Name = "C# Console Chatbot",
                    Subtitle = "2nd Year",
                    Description = "Console chatbot featuring validation, ASCII UI, voice greeting, and CI automation.",
                    TechStack = "C#, .NET, GitHub Actions",
                    GitHubUrl = "https://github.com/ForbesCaleb/CalebForbes.github.iio.git", 
                    Bullets = new List<string>
                    {
                        "Built input validation, ASCII art UI, and voice greeting",
                        "Implemented CI using GitHub Actions"
                    }
                },
                new Project
                {
                    Id = 3,
                    Name = "Cell C Project",
                    Subtitle = "Cybersecurity",
                    Description = "Cybersecurity-focused stakeholder assignment and documentation work.",
                    TechStack = "Documentation, Security Concepts, Automation",
                    GitHubUrl = "", // optional
                    Bullets = new List<string>
                    {
                        "Built a structured cybersecurity assignment for stakeholders",
                        "Leveraged automation",
                        "Development of high level document"
                    }
                }
            },

            WorkTitle = "Vac Work",
            WorkPlace = "Cell C",
            WorkBullets = new List<string>
            {
                "Completed a period of vac work for Cell C under supervision",
                "Completed a project to demonstrate what I learnt and understood"
            },

            Certifications = new List<string>
            {
                "Microsoft Azure Fundamentals (AZ-900)",
                "Cybersecurity / IT-related certificates"
            },

            ReferencesNote = "Available upon request."
        };

        public IActionResult Index()
        {
            return View(profile);
        }

        public IActionResult Details(int id)
        {
            var project = profile.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return RedirectToAction(nameof(Index));
            return View(project);
        }
    }
}