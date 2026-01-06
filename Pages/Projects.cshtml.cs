using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortfolioWebsite.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; } =
        [
            new Project
            {
                Title = "Store Mapper",
                Description = "This is a personal project originally intended as a Proof of Concept. " +
                "It is composed of a python web scraping server and dockerized C# mapping utility. " +
                "The server sits on the host machine, takes search queries in a CSV string from the client, and returns likely " +
                "aisle locations back to the client. The client gets search queries from user input, sends it to the client, then uses the returned " +
                "aisle list to highlight locations on a map and saves the image to a mounted folder for easy retrieval for the host.",
                Url = "https://github.com/Scorpion17471/storeMapper",
                ImageSources = new Dictionary<string, string>()
                {
                    {
                        "~/images/storeMapper client.png",
                        "The C# client application runsample from the docker container."
                    },
                    {
                        "~/images/storeMapper server.png",
                        "The python web scraping server running on the host machine."
                    },
                    {
                        "~/images/storeMapper output.png",
                        "The output image with highlighted aisles based on user search queries (derived from above samples)."
                    }
                }
            },
            new Project
            {
                Title = "Build Your Own Shell",
                Description = "This project follows the CodeCrafters.io guide to building a POSIX compliant shell. " +
                "As of the time of creating my portfolio website, this is currently still in progress as I have completed the first 3 stages " +
                "and I will be following up soon to work on the next stages (redirection, autocompletion, pipelines, history, and history persistence).",
                Url = "https://github.com/Scorpion17471/codecrafters-shell-csharp",
                ImageSources = new Dictionary<string, string>()
                {
                    {
                        "~/images/shellDemo.png",
                        "A demo of the shell running some basic commands including navigation."
                    }
                }
            },
            new Project
            {
                Title = "Computer & Network Security 1 Term Project - SFTP CLI v1.0",
                Description = "This project was created by me and two other students as a term project for a graduate level course in college. " +
                "It consists of a client-server architecture to encrypt and transfer files between clients. It has pseudorandom RSA key generation, " +
                "login-based access, user friending, salted and hashed passwords, among other security features. My main focus was registration, login, " +
                "storage logistics, networking, and cleaning up the UI, alongside directing the other members of our group.",
                Url = "https://github.com/Scorpion17471/C-NS1TermProject",
                ImageSources = new Dictionary<string, string>()
                {
                    {
                        "~/images/CNS1TP Dynamic keygen.png",
                        "Pseudorandom RSA key generation output example"
                    },
                    {
                        "~/images/CNS1TP register.png",
                        "User registration screen with example data fill"
                    },
                    {
                        "~/images/CNS1TP Friends.png",
                        "Users adding each other as friends"
                    },
                    {
                        "~/images/CNS1TP Transmission.png",
                        "Left screen shows server log from sending to downloading file, top right screen shows sending process, " +
                        "bottom right screen shows download process"
                    },
                    {
                        "~/images/CNS1TP Transmission filecontent.png",
                        "Filedata printed to terminal from sender and receiver to show content is properly delivered"
                    }
                }
            }
        ];
        public void OnGet()
        {
        }
    }

    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public Dictionary<string, string> ImageSources { get; set; } = new Dictionary<string, string>();
    }
}
