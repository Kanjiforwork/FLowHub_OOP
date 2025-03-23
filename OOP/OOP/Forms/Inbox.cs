using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OOP
{
    public partial class Inbox : Form, IObserver
    {

        private List<Notification> notifications = new List<Notification>();
        // Delegate để thông báo khi có thông báo mới
        public delegate void NotificationAddedHandler(Notification notification);
        public event NotificationAddedHandler NotificationAdded;
        public Inbox()
        {
            InitializeComponent();
            LoadSampleData();
            DisplayNotifications();
            Debug.WriteLine($"Inbox Size: {this.Size}");
            Debug.WriteLine($"Inbox ClientSize: {this.ClientSize}");
            // Đăng ký sự kiện
            NotificationAdded += Inbox_NotificationAdded;
            NotificationManager.Instance.Subscribe(this); // Lắng nghe thông báo từ hệ thống
        }

        public void Update(Notification notification)
        {
            notifications.Add(notification);
            DisplayNotifications();
        }

        // Hàm xử lý sự kiện khi có thông báo được thêm.
        private void Inbox_NotificationAdded(Notification notification)
        {
            DisplayNotifications();
        }

        private void LoadSampleData()
        {
            notifications.Add(new TaskUpdateNotification("Admin", "Bạn đã được giao một nhiệm vụ mới!"));
            notifications.Add(new TaskUpdateNotification("Admin", "Task của bạn sắp đến hạn!"));
            notifications.Add(new ProjectAnnouncementNotification("System", "Dự án mới 'Project X' đã được tạo!"));
            notifications.Add(new ProjectAnnouncementNotification("System", "Dự án 'Project Y' có cập nhật mới!"));
            notifications.Add(new AccountNotification("System", "Tài khoản mới 'john_doe' đã được đăng ký!"));
        }

        private void DisplayNotifications()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (Notification notification in notifications)
                {
                    NotiUserControl item = new NotiUserControl();
                    Image avatarImage = null;
                    if (Properties.Resources.defaultProjectPic != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            try
                            {
                                // Lưu hình ảnh vào MemoryStream dưới định dạng PNG
                                Properties.Resources.defaultProjectPic.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                ms.Position = 0; // Đặt lại vị trí về đầu stream
                                avatarImage = Image.FromStream(ms);
                            }
                            catch (ArgumentException ex)
                            {
                                MessageBox.Show($"Lỗi chuyển đổi avatar: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    item.SetNotificationData(avatarImage, notification.NguoiGui, notification.ThoiGian, notification.NoiDung);
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị thông báo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Inbox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Hàm ví dụ thêm 1 thông báo, khi thêm thông báo sẽ gọi event để thông báo cho những hàm đã đăng ký với event đó.
        public void AddNotification(Notification notification)
        {
            notifications.Add(notification);
            if
                (NotificationAdded != null)
            {
                NotificationAdded(notification);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
   {
       Home home = new Home();
       home.Show();
       this.Hide();
   }

   private void btnTask_Click(object sender, EventArgs e)
   {
       Tasks tasks = new Tasks();
       tasks.Show();
       this.Hide();
   }

   private void btnNoti_Click(object sender, EventArgs e)
   {
       Inbox inbox = new Inbox();
       inbox.Show();
       this.Hide();
   }

   private void btnProject_Click(object sender, EventArgs e)
   {
       Projects projects = new Projects();
       projects.Show();
       this.Hide();
   }

    }
}