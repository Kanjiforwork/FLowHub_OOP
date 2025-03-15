using System;
using System.Net.Mail;

namespace OOP.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }
        public DateTime CreatedAt { get; private set; }

        public Comment(int commentID, string content, User author)
        {
            CommentID = commentID;
            Content = content;
            Author = author;
            CreatedAt = DateTime.Now;
        }

        public void EditComment(string newContent)
        {
            Content = newContent;
        }
    }

}
