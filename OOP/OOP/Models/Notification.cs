using System;
using System.Windows.Forms;

public class Notification
{ 
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public Notification(int id, string message)
        {
            ID = id;
            Message = message;
            Timestamp = DateTime.Now;
        }
  
}
