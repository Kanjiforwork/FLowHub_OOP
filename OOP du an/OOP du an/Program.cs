using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_du_an
{
    public enum Role
    {
        Admin,
        Member
    }

    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Role UserRole { get; private set; }
        public int Phonenumber { get; private set; }

        public User(int userId, string name, string email, Role userRole, int phonenumber)
        {
            UserID = userId;
            Name = name;
            Email = email;
            UserRole = userRole;
            Phonenumber = phonenumber;
        }

        public void ChangeRole(Role newRole)
        {
            UserRole = newRole;
            Console.WriteLine("Quyền của " + Name + " đã được thay đổi thành " + UserRole);
        }
    }

    public class MenuUI
    {
        public void ShowMenu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("===== MENU CHÍNH =====");
            Console.WriteLine("1. Hiển thị danh sách thành viên");
            Console.WriteLine("2. Thêm thành viên mới ");
            Console.WriteLine("3. Thay đổi quyền thành viên");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn một tùy chọn: ");
        }
    }

    internal class Program
    {
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            users.Add(new User(1, "Hào", "hao@example.com", Role.Member, 93812312));
            users.Add(new User(2, "An", "an@example.com", Role.Admin, 93812313));

            MenuUI menu = new MenuUI();

            while (true)
            {
                menu.ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    DisplayUsers();
                }
                else if (choice == "2")
                {
                    AddUser();
                }
                else if (choice == "3")
                {
                    ChangeUserRole();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Thoát chương trình.");
                    break;
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        static void DisplayUsers()
        {
            Console.Clear();
            Console.WriteLine("===== DANH SÁCH THÀNH VIÊN =====");
            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                Console.WriteLine("ID: " + user.UserID + ", Tên: " + user.Name + ", Email: " + user.Email + ", Quyền: " + user.UserRole);
            }
        }

        static void AddUser()
        {
            Console.Clear();
            Console.Write("Nhập ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nhập tên: ");
            string name = Console.ReadLine();

            Console.Write("Nhập email: ");
            string email = Console.ReadLine();

            Console.Write("Nhập số điện thoại: ");
            int phone = int.Parse(Console.ReadLine());

            users.Add(new User(id, name, email, Role.Member, phone));
            Console.WriteLine("Thành viên mới đã được thêm với quyền mặc định là Member.");
        }

        static void ChangeUserRole()
        {
            Console.Clear();
            Console.WriteLine("===== THAY ĐỔI QUYỀN THÀNH VIÊN =====");
            DisplayUsers();

            Console.Write("\nNhập ID thành viên cần thay đổi quyền: ");
            int id = int.Parse(Console.ReadLine());

            User user = null;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserID == id)
                {
                    user = users[i];
                    break;
                }
            }

            if (user == null)
            {
                Console.WriteLine("Không tìm thấy thành viên.");
                return;
            }

            Console.WriteLine("Người dùng hiện tại: " + user.Name + " - Vai trò: " + user.UserRole);
            Console.Write("Nhập quyền mới (0: Admin, 1: Member): ");
            int roleInput;
            if (int.TryParse(Console.ReadLine(), out roleInput) && (roleInput == 0 || roleInput == 1))
            {
                user.ChangeRole((Role)roleInput);
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }
    }
}
