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
        public static User LoggedInUser { get; private set; } // Đây là người dùng đã đăng nhập, ví dụ "admin"
        public User(int id, string username,RoleType role)
        {
            ID = id;
            Name = username;
            Role = role;
        }
        public static void Login(string username, RoleType role)
        {
            // Tạo một đối tượng User và gán cho LoggedInUser
            LoggedInUser = new User(1, username, role   ); // Ví dụ, ID = 1, bạn có thể thay bằng cách tạo ID tự động
        }

        // Phương thức để lấy thông tin người dùng đăng nhập
        public static string GetLoggedInUserName()
        {
            return LoggedInUser?.Name ?? "No user logged in"; // Trả về tên người dùng nếu đã đăng nhập
        }

        // Phương thức để kiểm tra xem người dùng có đăng nhập không
        public static bool IsLoggedIn()
        {
            return LoggedInUser != null;
        }
    }
}
