using System;
using System.Collections.Generic;
using System.Data;
using OOP.Models;
using OOP.Services;
using Newtonsoft.Json;

namespace OOP.Models
{
    public abstract class AbaseTask : IComparable<AbaseTask>
    {
        private IUpdateStatus updateStatus;
        public string taskID { get; set; }
        public string taskName { get; set; }
        public string status { get; set; }
        public DateTime deadline { get; set; }
        public int AssignedTo { get; set; } // ✅ Moved AssignedTo to AbaseTask

        public void SetUpdateStatus(IUpdateStatus updateStatus)
        {
            this.updateStatus = updateStatus;
        }
        public IUpdateStatus GetUpdateStatus()
        {
            return this.updateStatus;
        }

        public void UpdateStatus()
        {
            this.status = updateStatus.UpdateStatus(deadline);
        }

        public AbaseTask(string taskID, string taskName, string status, DateTime deadline, int assignedTo)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            this.status = status;
            this.deadline = deadline;
            this.AssignedTo = assignedTo; // ✅ Now all tasks have AssignedTo
        }

        public int CompareTo(AbaseTask other)
        {
            if (this.deadline < other.deadline) return -1;
            if (this.deadline > other.deadline) return 1;
            return 0;
        }

        public abstract void MarkAsCompleted();
        public abstract void MarkAsInComleted();
        public abstract void UpdateStatus(string newStatus);
    }



    public class Task : AbaseTask
    {
        public string ProjectName { get; set; }

        public Task(string taskID, string taskName, string status, DateTime deadline, string projectName, int assignedTo)
            : base(taskID, taskName, status, deadline, assignedTo)
        {
            this.ProjectName = projectName;
        }

        public override void MarkAsCompleted()
        {
            status = "Completed";
        }
        public override void MarkAsInComleted()
        {
            status = "InCompleted";
        }


        public override void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }
    }

    public class Meeting : AbaseTask
    {
        public string Location { get; set; }
        public List<User> Participants { get; set; }

        public Meeting(string taskID, string taskName, string status, DateTime deadline, string location, List<User> participants, int assignedTo)
            : base(taskID, taskName, status, deadline, assignedTo)
        {
            Location = location;
            Participants = participants ?? new List<User>();
        }

        public override void MarkAsCompleted()
        {
            status = "Completed";
        }
        public override void MarkAsInComleted()
        {
            status = "InCompleted";
        }

        public override void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }
    }


    public class Milestone : AbaseTask
    {
        public string Description { get; set; }

        public Milestone(string taskID, string taskName, string status, DateTime deadline, string description, int assignedTo)
            : base(taskID, taskName, status, deadline, assignedTo)
        {
            Description = description;
        }

        public override void MarkAsCompleted()
        {
            status = "Completed";
        }
        public override void MarkAsInComleted()
        {
            status = "InCompleted";
        }

        public override void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }
    }


}

