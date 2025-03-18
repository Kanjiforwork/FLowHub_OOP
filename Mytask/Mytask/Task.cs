using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mytask
{
    public class Task : IComparable<Task>
    {
        public string taskID { get; set; }
        public string taskName { get; set; }
        public string status { get; set; }
        //private User assighedTo { get; set; }

        public DateTime dealine { get; set; }
        public string projectID { get; set; }   

        public Task(string taskID, string taskName, string status, DateTime dealine, string projectID)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            this.status = status;
            this.dealine = dealine;
            this.projectID = projectID;
        }
        public int CompareTo(Task other)
        {
            if (this.dealine <  other.dealine) return -1;
            if (this.dealine > other.dealine) { return 1; }
            return 0;
        }
        public void UpdateStatus(string newStatus)
        {

        }

    }

    public class Project
    {
        public string projectID { get; set; }
        public string projectName { get; set; }

        public List<Task> tasks = new List<Task>();

        public Project(string  projectID, string projectName)
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
