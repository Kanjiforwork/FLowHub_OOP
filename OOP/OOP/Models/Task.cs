using System;
using System.Collections.Generic;
using System.Data;
using OOP.Models;

public abstract class AbaseTask : IComparable<AbaseTask>
{
    private IUpdateStatus updateStatus;
    public string taskID { get; set; }
    public string taskName { get; set; }
    public string status { get; set; }
    public DateTime dealine { get; set; }

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
        this.status = updateStatus.UpdateStatus(dealine);
    }

    public AbaseTask(string taskID, string taskName, string status, DateTime deadline)
    {
        this.taskID = taskID;
        this.taskName = taskName;
        this.status = status;
        this.dealine = deadline;


    }

    public int CompareTo(AbaseTask other)
    {
        if (this.dealine < other.dealine) return -1;
        if (this.dealine > other.dealine) { return 1; }
        return 0;
    }

    public abstract void MarkAsCompleted();
    public abstract void UpdateStatus(string newStatus);

}

public class Task : AbaseTask
{
    public User assighedTo { get; set; }
    public string projectName { get; set; }
    public Task(string taskID, string taskName, string status, DateTime deadline, string projectName, User assignedTo)
        : base(taskID, taskName, status, deadline)
    {
        this.projectName = projectName;
        this.assighedTo = assignedTo;
    }

    public override void MarkAsCompleted()
    {
        status = "Completed";
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

    public Meeting(string taskID, string taskName, string status, DateTime deadline, string location, List<User> participants)
        : base(taskID, taskName, status, deadline)
    {
        Location = location;
        Participants = participants;
    }

    public override void MarkAsCompleted()
    {
        status = "Completed";
    }

    public override void UpdateStatus(string newStatus)
    {
        status = newStatus;
    }


}

public class Milestone : AbaseTask
{
    public string Description { get; set; }

    public Milestone(string taskID, string taskName, string status, DateTime deadline, string description)
        : base(taskID, taskName, status, deadline)
    {
        Description = description;
    }

    public override void MarkAsCompleted()
    {
        status = "Completed";
    }

    public override void UpdateStatus(string newStatus)
    {
        status = newStatus;
    }


}
