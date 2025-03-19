using System;
using System.IO;
using System.Windows.Forms;

namespace OOP.Models
{ 
    public class FileAttachment
    {
        public int FileID { get; set; }
        public string FilePath { get; private set; }
        public Task RelatedTask { get; set; }

        public FileAttachment(int fileID, Task relatedTask)
        {
            FileID = fileID;
            RelatedTask = relatedTask;
        }

        //public void AttachFile(string filePath)
        //{
        //    if (File.Exists(filePath))
        //    {
        //        FilePath = filePath;
        //        MessageBox.Show("Tệp tin đã được đính kèm vào nhiệm vụ: " + RelatedTask.Title, 
        //                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tệp tin không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }

}
