using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Inbox : Form
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
            // Đăng ký sự kiện
            NotificationAdded += Inbox_NotificationAdded;
        }

        // Hàm xử lý sự kiện khi có thông báo được thêm.
        private void Inbox_NotificationAdded(Notification notification)
        {
            DisplayNotifications();
        }

        private void LoadSampleData()
        {
            try
            {
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được thăng chức...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Nhiệm vụ mới", "John Doe", DateTime.Now, "Bạn được giao nhiệm vụ mới...", false));
                notifications.Add(new Notification("Bình luận", "Jane Smith", DateTime.Now.AddMinutes(-10), "Có bình luận mới...", false));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu mẫu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}