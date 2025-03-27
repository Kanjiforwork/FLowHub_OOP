using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OOP.Models;

namespace OOP.Services
{
    public class TaskManager
    {
        private static TaskManager _instance;
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.json");

        public List<AbaseTask> Tasks { get; private set; }

        public static TaskManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TaskManager();
            }
            return _instance;
        }

        private TaskManager()
        {
            Tasks = new List<AbaseTask>();
            LoadTasksFromFile();
        }

        // ✅ Thêm task mới
        public void AddTask(AbaseTask task)
        {
            if (task == null) return;
            Tasks.Add(task);
            SaveTasksToFile();
        }

        // ✅ Xóa task theo ID
        public void RemoveTask(string taskID)
        {
            Tasks.RemoveAll(t => t.taskID == taskID);
            SaveTasksToFile();
        }

        // ✅ Tìm task theo User
        public List<AbaseTask> GetTasksByUser(User user)
        {
            List<AbaseTask> userTasks = new List<AbaseTask>();

            foreach (AbaseTask task in Tasks)
            {
                if (task.AssignedTo == user.ID)
                {
                    userTasks.Add(task);
                }
            }

            return userTasks;
        }

        // ✅ Lưu danh sách task vào file
        public void SaveTasksToFile()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(Tasks, settings);
            File.WriteAllText(filePath, json);
        }

        // ✅ Load task từ file nếu có
        public void LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                Tasks = JsonConvert.DeserializeObject<List<AbaseTask>>(json, settings) ?? new List<AbaseTask>();
            }
        }

        public void UpdateTask(AbaseTask updatedTask)
        {
            if (updatedTask == null) return;

            int index = Tasks.FindIndex(t => t.taskID == updatedTask.taskID);
            if (index != -1)
            {
                Tasks[index] = updatedTask; // Cập nhật task
                SaveTasksToFile(); // Lưu lại file
            }
        }

        // ✅ Xóa file JSON
        public void DeleteTaskFile()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Deleted tasks.json successfully!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
    public class AbaseTaskConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(AbaseTask).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            string type = jsonObject["Type"]?.ToString();

            AbaseTask task;
            switch (type)
            {
                case "Task":
                    task = new Task("", "", "", DateTime.Now, "", 0);
                    break;
                case "Meeting":
                    task = new Meeting("", "", "", DateTime.Now, null, "", null, null, User.LoggedInUser.ID);
                    break;
                case "Milestone":
                    task = new Milestone("", "", "", DateTime.Now, null, null, 0);
                    break;
                default:
                    throw new Exception("Unknown task type");
            }

            serializer.Populate(jsonObject.CreateReader(), task);
            return task;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.FromObject(value);
            jsonObject.Add("Type", value.GetType().Name); // 🔥 Ghi Type vào JSON
            jsonObject.WriteTo(writer);
        }
    }
}
