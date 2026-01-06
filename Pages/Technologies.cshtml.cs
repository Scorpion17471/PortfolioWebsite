using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortfolioWebsite.Pages
{
    public class TechnologiesModel : PageModel
    {
        public Dictionary<string, List<string>> Languages { get; } = new Dictionary<string, List<string>>
        {
            {
                "Programming", new List<string>
                {
                    "C#",
                    "JavaScript/TypeScript",
                    "Python",
                    "C++",
                    "C"
                }
            },
            {
                "Markup & Stylesheet", new List<string>
                {
                    "HTML",
                    "CSS",
                }
            },
            {
                "Database", new List<string>
                {
                    "SQL",
                    "PostgreSQL",
                    "SQLite",
                    "MongoDB"
                }
            }
        };

        public Dictionary<string, List<string>> Frameworks { get; } = new Dictionary<string, List<string>>
        {
            {
                "C#", new List<string>
                {
                    ".NET Core",
                    "ASP.NET Core",
                    "ASP.NET MVC",
                    "Entity Framework Core",
                    "Razor Pages"
                }
            },
            {
                "JavaScript/TypeScript", new List<string>
                {
                    "Node",
                    "React",
                    "Express",
                    "Mocha"
                }
            },
            {
                "Python", new List<string>
                {
                    "Django",
                    "Pandas",
                    "Matplotlib"
                }
            },
            {
                "C++", new List<string>
                {
                    "SFML",
                    "Boost Testing",
                    "Boost Regex"
                }
            }
        };

        public List<string> Tools { get; } =
        [
            "Git",
            "GitHub",
            "Docker",
            "Visual Studio",
            "Visual Studio Code",
            "Figma",
            "JIRA",
            "Azure"
        ];

        private readonly ILogger<TechnologiesModel> _logger;

        public TechnologiesModel(ILogger<TechnologiesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
