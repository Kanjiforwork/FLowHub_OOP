using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WinFormsApp1
{
    public class UserService
    {
        private static readonly string filePath = "users.json";

        public static List<User> LoadUsers()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<User>>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading users: {ex.Message}");
                }
            }
            return new List<User>();
        }

        public static User AuthenticateUser(string username, string password)
        {
            List<User> users = LoadUsers();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    return users[i];
                }
            }
            return null;
        }
        public static void SaveUsers(List<User> users)
        {
            try
            {
                string json = JsonSerializer.Serialize(users);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving users: {ex.Message}");
            }
        }
    }
}
