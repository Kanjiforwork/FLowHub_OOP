using Microsoft.VisualBasic.ApplicationServices;
using OOP.Models;
using OOP.Services;
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

        TaskManager taskManager = TaskManager.GetInstance();
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
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void LoadTasks()
        {

            // Xóa các control cũ trong panel trước khi thêm mới
            taskContainer.Controls.Clear();

            foreach (var task in taskManager.GetTasksByUser(User.LoggedInUser))
            {
                HomeTaskUserControl taskItem = new HomeTaskUserControl(task);
                taskItem.Dock = DockStyle.Top; // Stack tasks from top to bottom
                taskContainer.Controls.Add(taskItem);
                ApplyMouseEvents(taskItem.TaskPanel);
            }
        }
        private List<Project> projects = new List<Project>();
        private void Loadprojects()
        {
          
            projectContainer.Controls.Clear();

            foreach (var project in projects)
            {
                HomeProjectUserControl projectItem = new HomeProjectUserControl(project);
                projectItem.Dock = DockStyle.Top; // Stack Project from top to bottom
                projectContainer.Controls.Add(projectItem);
            }
        }


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

            if (User.LoggedInUser != null)
            { 
                WelcomeName.Text = $"Hey {User.LoggedInUser.Username}, sẵn sàng làm việc chưa? 🚀";
                if (User.LoggedInUser.Avatar != null && User.LoggedInUser.Avatar.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(User.LoggedInUser.Avatar))
                    {
                        try
                        {
                            avatar.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi hiển thị ảnh đại diện: {ex.Message}");
                           avatar.Image = Properties.Resources.DefaultAvatar; // Ảnh mặc định nếu lỗi
                        }
                    }
                }
                else
                {
                    avatar.Image = Properties.Resources.DefaultAvatar; // Ảnh mặc định nếu không có ảnh
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ConfirmExit()) // Nếu người dùng chọn Yes, thoát chương trình
            {
                Application.Exit();
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmExit())
            {
                e.Cancel = true; // Hủy đóng chương trình nếu chọn No
            }
        }

        private bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}
