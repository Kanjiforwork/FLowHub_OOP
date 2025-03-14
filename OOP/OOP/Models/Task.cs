using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
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

}
