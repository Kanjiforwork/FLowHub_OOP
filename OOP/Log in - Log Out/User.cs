using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable] // Thêm attribute Serializable để có thể serialize object
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; } // Thêm username
        public string Password { get; set; } // Thêm password
        public string Email { get; set; } // Thêm email
        public byte[] Avatar { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<User> Friends { get; set; } = new List<User>();

        public User(int id, string username, string password, string email)
        {
            ID = id;
            Username = username;
            Password = password;
            Email = email;
        }

        public User() { } // Constructor mặc định cho việc deserialize
        }
 }