﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OOP.Models;
using OOP.Usercontrols;

namespace OOP
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            // Ví dụ: tạo danh sách Task mẫu
            tasks.Add(new Task("1", "Quýnh VietAnh", "Pending", DateTime.Now.AddDays(3), "Project Alpha"));
            tasks.Add(new Task("2", "Code Login", "In Progress", DateTime.Now.AddDays(5), "Project Beta"));
            tasks.Add(new Task("3", "Fix Bug UI", "Completed", DateTime.Now.AddDays(-2), "Project Alpha"));

            // Ví dụ: tạo danh sách project mẫu
          /*  projects.Add(new Project("1", "Quýnh vietAnh"));
            projects.Add(new Project("1", "Quýnh ThoaiHao"));*/
            LoadTasks(tasks);

            //Apply mouseEvent
            ApplyMouseEvents(taskContainer);
            ApplyMouseEvents(sidebar);
            ApplyMouseEvents(TopPanel);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            foreach (ToolStripItem tsi in menuStrip1.Items)
            {
                if (tsi == e.ClickedItem)
                {
                    tsi.BackColor = SystemColors.ControlDark;

                }
                else
                {
                    tsi.BackColor = SystemColors.Control;
                }
            }
        }

        private void mnuList_Click(object sender, EventArgs e)
        {
            //if (!mnuList.Checked)
            //  {
            //      mnuList.Checked = true;
            //  }
            //else
            //  {
            //      mnuList.Checked = false;
            //  }
            //Console.WriteLine(mnuList.Checked);
        }
        private List<Project> projects = new List<Project>();
        private List<Task> tasks = new List<Task>();

        private void LoadTasks(List<Task> tasks)
        {
            // Xóa các control cũ trong panel trước khi thêm mới
            taskContainer.Controls.Clear();

            foreach (var task in tasks)
            {
                TasksFullUserControl taskItem = new TasksFullUserControl(task);
                taskItem.Dock = DockStyle.Top; // Stack tasks from top to bottom
                taskContainer.Controls.Add(taskItem);
                ApplyMouseEvents(taskItem.TaskPanel);
            }
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

        private void btnMore_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMore, new Point(20, btnMore.Height));
        }

        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            Addtask addTaskForm = new Addtask(projects);
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(addTaskForm.NewTask); // Thêm task mới vào danh sách
                LoadTasks(tasks);
            }
        }

        private void ctmCloset_Click(object sender, EventArgs e)
        {
            tasks.Sort();
            tasks.Reverse();
            LoadTasks(tasks);
           // RenderTasks(tasks);
        }

        private void ctmFarest_Click(object sender, EventArgs e)
        {
            tasks.Sort();
             //RenderTasks(tasks);
             LoadTasks(tasks);
        }

        private void ctmFinished_Click(object sender, EventArgs e)
        {
            List<Task> taskslistother = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.status == "Finished")
                {
                    taskslistother.Add(task);
                }
            }
            LoadTasks(taskslistother);
        }

        private void ctnSection_Click(object sender, EventArgs e)
        {
            List<Task> taskslistother = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.status != "Finished")
                {
                    Console.WriteLine(task.taskName);
                    taskslistother.Add(task);
                }
            }
            LoadTasks(taskslistother);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Create a new instance of Form2
            this.Hide(); // Hide the current form
            home.Show(); // Show Form2
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks(); // Create a new instance of Form2
            this.Hide(); // Hide the current form
            tasks.Show(); // Show 
        }
    }
}