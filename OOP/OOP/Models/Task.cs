using System;

public class Task : IComparable<Task>
{
    public string taskID { get; set; }
    public string taskName { get; set; }
    public string status { get; set; }
    //private User assighedTo { get; set; }

    public DateTime dealine { get; set; }

    public string projectName { get; set; }

    public Task(string taskID, string taskName, string status, DateTime dealine, string projectName)
    {
        this.taskID = taskID;
        this.taskName = taskName;
        this.status = status;
        this.dealine = dealine;
        this.projectName = projectName;
    }
    public int CompareTo(Task other)
    {
        if (this.dealine < other.dealine) return -1;
        if (this.dealine > other.dealine) { return 1; }
        return 0;
    }
    public void UpdateStatus(string newStatus)
    {

    }
}

