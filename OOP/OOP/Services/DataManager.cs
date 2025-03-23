using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    internal class DataManager
    {
        private static string filePath = "projects.dats";


        //Lưu danh sách dự án
        private static void SaveData(ProjectManager projectManager)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, projectManager);
                }
            }
            catch 
            {
                //Error
            }
        }

        //Đọc danh sách dự án 
        public static ProjectManager LoadData()
        {
            try
            {
                //Trả về danh sách rỗng nếu chưa có file
                if (File.Exists(filePath)) return new ProjectManager();
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (ProjectManager)formatter.Deserialize(fs);
                }
            }
            catch
            {
                //Error
                return new ProjectManager();
            }
        }
    }
}
