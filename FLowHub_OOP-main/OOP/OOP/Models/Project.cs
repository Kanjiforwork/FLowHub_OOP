using OOP.Services;
using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace OOP.Models
{
    public enum RoleType
    {
        Admin,
        Member,
        Viewer
    }
   
    public class Project
    {
        private int projectID { get; set; }
        public string projectName { get; set; }
        public string projectDescription { get; set; }
        public List<Task> tasks = new List<Task>();
        public List<string> members { get; set; } = new List<string>();


        public Project() { }
        public RoleType UserRole { get; private set; }

        public Project(int projectID, string projectName, string projectDescription, RoleType role)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.UserRole = role;

        }
        public Project(int id, string name, string description)
        {
            this.projectID = id;
            projectName = name;
            projectDescription = description;
            members = new List<string>();
        }
        public void AddTask(Task task)
        {
            if (UserRole == RoleType.Admin || UserRole == RoleType.Member)
            {
                tasks.Add(task);
            }
            else
            {
                throw new UnauthorizedAccessException("Only Admins and Members can add tasks.");
            }
            
        }


        public void RemoveTask(Task task)
        {
            if (UserRole == RoleType.Admin)
            {
                tasks.Remove(task);
            }
            else
            {
                throw new UnauthorizedAccessException("Only Admins can remove tasks.");
            }
        }
        


    }
}
