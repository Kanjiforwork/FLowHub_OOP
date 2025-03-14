using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Project
    {
        private int projectID { get; set; }
        private string projectName { get; set; }

        public List<Task> tasks = new List<Task>();

        public Project(int projectID, string projectName)
        {
            this.projectID = projectID;
            this.projectName = projectName;
        }

        public void AddTask(Task task)
        {

        }

        public void RemoveTask(int taskID)
        {

        }



    }
}
