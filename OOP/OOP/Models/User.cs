using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<User> Friends { get; set; } = new List<User>();

        public User(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
