using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models;

namespace OOP.Services
{

    public class ProjectManager
    {
        private static ProjectManager _instance;
        private static readonly object _lock = new object();

        public List<Project> Projects { get; private set; }

        private ProjectManager()
        {
            Projects = new List<Project>();
        }

        public static ProjectManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ProjectManager();
                    }
                    return _instance;
                }
            }
        }

        public void AddProject(Project project)
        {
            Projects.Add(project);
        }

        public void RemoveProject(Project project)
        {
            Projects.Remove(project);
        }
    }




}
