using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public Project Project { get; set; }
        public User AssignedTo { get; set; }

        public Task(int id, string content, DateTime deadline, Project project, User assignedTo)
        {
            ID = id;
            Content = content;
            Deadline = deadline;
            Project = project;
            AssignedTo = assignedTo;
        }
    }

}
