using Microsoft.VisualBasic.ApplicationServices;
using OOP.Models;
using OOP.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using User = OOP.Models.User;

namespace OOP
{
    public partial class Home : Form
    {
        public Home()
        {

            InitializeComponent();

            //Mouse Hover
            ApplyMouseEvents(TopPanel);
            ApplyMouseEvents(projectPanel);
            ApplyMouseEvents(taskPanel);

            //Task
            LoadTasks();
            //Project
            Loadprojects();
        }
        // Attach MouseMove & MouseLeave only to the **Panel itself** but still track child elements
        void ApplyMouseEvents(Panel panel)
        {
            panel.MouseMove += (s, e) => Panel_MouseMove(panel);
            panel.MouseLeave += (s, e) => Panel_MouseLeave(panel);

            foreach (Control child in panel.Controls)
            {
                child.MouseMove += (s, e) => Panel_MouseMove(panel); // Redirect child hover event to panel
                child.MouseLeave += (s, e) => Panel_MouseLeave(panel); // Redirect child leave event to panel
            }
        }

        // Change border style when hovering over the panel (but not its children directly)
        private void Panel_MouseMove(Panel panel)
        {
            panel.BorderStyle = BorderStyle.Fixed3D;
        }

        // Reset border when leaving the **entire** panel
        private void Panel_MouseLeave(Panel panel)
        {
            // Check if the mouse is still inside the panel
            if (!panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(Object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 72)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 150)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private Timer timer;
        private void Home_Load(object sender, EventArgs e)
        {
            // Cập nhật thời gian ban đầu và người dùng
            UpdateDateTime();
            UpdateName();

            // Tạo và cấu hình Timer
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += (s, ev) => UpdateDateTime();
            timer.Start();
        }
        private void UpdateDateTime()
        {
            timeDetail.Text = DateTime.Now.ToString("dddd, 'ngày' dd 'tháng' M");
        }
        private void UpdateName()
        {
            WelcomeName.Text = "Welcome back, Kanji";
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private List<Task> tasks = new List<Task>();
        private void LoadTasks()
        {
            // Ví dụ: tạo danh sách Task mẫu
            tasks.Add(new Task("1", "Quýnh VietAnh", "Pending", DateTime.Now.AddDays(3), "Project Alpha"));
            tasks.Add(new Task("2", "Code Login", "In Progress", DateTime.Now.AddDays(5), "Project Beta"));
            tasks.Add(new Task("3", "Fix Bug UI", "Completed", DateTime.Now.AddDays(-2), "Project Alpha"));


            // Xóa các control cũ trong panel trước khi thêm mới
            taskContainer.Controls.Clear();

            foreach (var task in tasks)
            {
                HomeTaskUserControl  taskItem = new HomeTaskUserControl(task);
                taskItem.Dock = DockStyle.Top; // Stack tasks from top to bottom
                taskContainer.Controls.Add(taskItem);
                ApplyMouseEvents(taskItem.TaskPanel);
            }
        }
        private List<Project> projects = new List<Project>();
        private void Loadprojects()
        {
            // Ví dụ: tạo danh sách Project mẫu
           /* projects.Add(new Project("1", "Quýnh vietAnh"));
            projects.Add(new Project("1", "Quýnh ThoaiHao"));*/
            // Xóa các control cũ trong panel trước khi thêm mới
            projectContainer.Controls.Clear();

            foreach (var project in projects)
            {
                HomeProjectUserControl projectItem = new HomeProjectUserControl(project);
                projectItem.Dock = DockStyle.Top; // Stack Project from top to bottom
                projectContainer.Controls.Add(projectItem);
            }
        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private User _user;
        public Home(User user)
        {
            InitializeComponent();
            //Mouse Hover
            ApplyMouseEvents(TopPanel);
            ApplyMouseEvents(projectPanel);
            ApplyMouseEvents(taskPanel);

            //Task
            LoadTasks();
            //Project
            Loadprojects();

            _user = user;
           /* lblUsername.Text = _user.Username;
            lblEmail.Text = _user.Email;*/
            if (_user.Avatar != null && _user.Avatar.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_user.Avatar))
                {
                    try
                    {
                        //pbUserAvatar.Image = Image.FromStream(ms);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi hiển thị ảnh đại diện: {ex.Message}");
                    }
                }
            }
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
