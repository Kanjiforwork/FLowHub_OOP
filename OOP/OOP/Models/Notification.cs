using Microsoft.VisualBasic.ApplicationServices;
using OOP.Models;
using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(Notification notification);
}
public class Notification
{
    public string TieuDe { get; set; }
    public string NguoiGui { get; set; }
    public DateTime ThoiGian { get; set; }
    public string NoiDung { get; set; }
    public bool DaDoc { get; set; }

    public Notification(string tieuDe, string nguoiGui, DateTime thoiGian, string noiDung, bool daDoc)
    {
        TieuDe = tieuDe;
        NguoiGui = nguoiGui;
        ThoiGian = thoiGian;
        NoiDung = noiDung;
        DaDoc = daDoc;
    }
}
public class NotificationManager
{
    private static NotificationManager instance;
    private List<IObserver> observers = new List<IObserver>();
    private List<OOP.Models.User> users = new List<OOP.Models.User>();
    private NotificationManager() { }

    public static NotificationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new NotificationManager();
            }
            return instance;
        }
    }

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(Notification notification)
    {
        foreach (IObserver observer in observers)
        {
            if (notification is TaskUpdateNotification)
            {
                foreach (OOP.Models.User user in users)
                {
                    if (user.Role == RoleType.Member)
                    {
                        observer.Update(notification);
                    }
                }
            }
            else
            {
                observer.Update(notification);
            }
        }
    }
}
public class TaskUpdateNotification : Notification
{
    public TaskUpdateNotification(string sender, string message)
        : base("Task Update", sender, DateTime.Now, message, false) { }
}

public class ProjectAnnouncementNotification : Notification
{
    public ProjectAnnouncementNotification(string sender, string message)
        : base("Project Announcement", sender, DateTime.Now, message, false) { }
}

public class AccountNotification : Notification
{
    public AccountNotification(string sender, string message)
        : base("New Account", sender, DateTime.Now, message, false) { }
}