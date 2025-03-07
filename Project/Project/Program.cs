using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Task
    {
        private int taskID { get; set; }
        private string taskName { get; set; }
        private string status { get; set; }
        //private User assighedTo { get; set; }

        private DateTime dealine { get; set; }

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

        //public void AssignTo(User user)
        //{

        //}
    }

    public class Project
    {
        private int projectID { get; set; }
        private string projectName { get; set; }

        public List<Task> tasks  = new List<Task>();

        public Project(int projectID, string projectName)
        { 
            this.projectID = projectID; 
            this.projectName = projectName;
        }

        public void AddTask (Task task)
        {

        }

        public void RemoveTask (int taskID)
        {

        }
        

        
    }
}
