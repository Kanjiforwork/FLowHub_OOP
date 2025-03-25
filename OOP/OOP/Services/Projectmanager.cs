using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models;

namespace OOP.Services
{
    internal class ProjectManager
    {
        public List<Project> Projects { get; set; }

        public ProjectManager()
        {
            Projects = new List<Project>();
        }

        public void AddProject(Project project)
        {
            Projects.Add(project);

            // Gửi thông báo đến tất cả user về dự án mới
            NotificationManager.Instance.Notify(new ProjectAnnouncementNotification("System", $"Dự án '{project.projectName}' đã được tạo!"));
        }
        /* public void DeleteProject(string ProjectName)
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
         }*/

    }

}