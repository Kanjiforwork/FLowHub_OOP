using System;
using System.IO;
using System.Windows.Forms;

public class Task
{
    public int TaskID { get; set; }
    public string Title { get; set; }
    public List<Comment> Comments { get; set; }  // Danh sách bình luận

    public Task(int taskID, string title)
    {
        TaskID = taskID;
        Title = title;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}



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

    public void AttachFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            FilePath = filePath;
            MessageBox.Show("Tệp tin đã được đính kèm vào nhiệm vụ: " + RelatedTask.Title, 
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Tệp tin không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
