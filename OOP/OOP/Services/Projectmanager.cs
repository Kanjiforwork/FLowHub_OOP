using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    internal class ProjectManager
    {
        public List<Project> Projects { get; set; }

        public ProjectManager() 
        {
            Projects = new List<Project>();
        }

        public void AddProject()
        {
            Projects.Add(new Project());
        }
        public void DeleteProject(string ProjectName)
        {
            Project project = Projects.Find(p => p.ProjectName == ProjectName);
            if (project != null)
            {
                Projects.Remove(project);
            }
            else
            {
                //Raise exception
            }
        }
        public Project FindProject(string ProjectName)
        {
            return Projects.Find(p => p.ProjectName == ProjectName);
        }

    }


    public class Project
    {
        public string ProjectName { get; set; }
        public string ProjectId {  get; set; }


    }

}
