using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class User
    {
        public RoleType Role { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<User> Friends { get; set; } = new List<User>();
        public List<User> allUsers = new List<User>();
        public User(int id, string username,RoleType role)
        {
            ID = id;
            Name = username;
            Role = role;
        }
    }
}
