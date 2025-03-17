using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mytask
{
    public class Task
    {
        public int taskID { get; set; }
        public string taskName { get; set; }
        public string status { get; set; }
        //private User assighedTo { get; set; }

        public DateTime dealine { get; set; }

        public Task(int taskID, string taskName, string status, DateTime dealine)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            this.status = status;
            this.dealine = dealine;
        }

        public void UpdateStatus(string newStatus)
        {

        }

    }

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
