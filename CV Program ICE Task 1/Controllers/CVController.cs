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

           
            AboutMe =
"I am a final-year Information Technology student with a strong interest in software development, cloud computing, and cybersecurity. " +
"I have experience developing applications using C#, ASP.NET Core MVC, SQL databases, and Microsoft Azure. Through my academic projects, " +
"I have built full-stack web applications, console applications, and cloud-integrated systems that focus on practical problem solving " +
"and clean system design. " +

"I have worked on projects such as an Event Booking System using ASP.NET Core MVC and Azure services, as well as a C# console-based chatbot " +
"that included input validation, structured logic, and automated testing. These projects strengthened my understanding of database design, " +
"software architecture, and system development principles. " +

"I am passionate about continuously improving my technical skills and learning new technologies, especially in the areas of backend development " +
"and cybersecurity. My long-term goal is to become a skilled software engineer and eventually build my own technology-driven business.",

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
                    GitHubUrl = "",
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
    "Certificate in Full Stack Development – FNB App Academy (IT Varsity), 2025",
    "Microsoft Azure Fundamentals (AZ-900)"
},


            ContactInfo =
                "Email: Caleb.forbes1@icloud.com\n" +
                "Phone: 072 931 0572\n" +
                "GitHub: https://github.com/ForbesCaleb\n" +
                "LinkedIn: www.linkedin.com/in/caleb-forbes-2bab133b2"
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