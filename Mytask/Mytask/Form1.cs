using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mytask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        public List<Task> tasks = new List<Task>();
        public List<Project> projects = new List<Project>();
        private void Form1_Load(object sender, EventArgs e)
        {

            tasks.Add(new Task("1", "hoàn thành báo cáo", "Hoàn thành", new DateTime(2025, 3, 20), "P001"));
            tasks.Add(new Task("2", "họp nhóm", "Chưa hoàn thành", new DateTime(2025, 3, 21), "P001"));
            tasks.Add(new Task("3", "kiểm tra code", "Hoàn thành", new DateTime(2025, 3, 18), "P002"));
            tasks.Add(new Task("4", "gửi email khách hàng", "Chưa hoàn thành", new DateTime(2025, 3, 22), "P002"));
            tasks.Add(new Task("5", "viết tài liệu", "Hoàn thành", new DateTime(2025, 3, 25), "P003"));





            tasks.Sort();
            RenderTasks(tasks);


            projects.Add(new Project("P001", "Online Learning Platform"));
            projects.Add(new Project("P002", "Smart Home System"));
            projects.Add(new Project("P003", "Blockchain Payment Gateway"));

        }


        private void RenderTasks(List<Task> tasks)
        {
            pnRecentAssigned.Controls.Remove(tblTask);
            tblTask.Dispose();
            tblTask = null;

            tblTask = new TableLayoutPanel
            {
                Name = "tblTask",
                Dock = DockStyle.Fill, // Hoặc tùy chỉnh kích thước
                ColumnCount = 5, // Số cột của bảng
                AutoSize = true,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble,
            };

            // Thêm lại vào container mong muốn
            pnRecentAssigned.Controls.Add(tblTask);
            tblTask.RowCount = tasks.Count;
            tblTask.AutoSize = true;
            tblTask.ColumnStyles.Clear();

            tblTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 255F)); // Cột 1: Checkbox + Task Name
            tblTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F)); // Cột 2: DateTimePicker
            tblTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F)); // Cột 3: TextBox 1
            tblTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F)); // Cột 4: TextBox 2
            tblTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F)); // Cột 5: Label "My Workspace"
            tblTask.RowStyles.Clear();
            for (int i = 0; i < tasks.Count; i++)
            {
                tblTask.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            }


            for (int i = 0; i < tasks.Count; i++)
            {
                Task task = tasks[i];
                Console.WriteLine(task.taskName);
                CheckBox checkBox = new CheckBox
                {
                    Text = task.taskName,
                    AutoSize = false,
                    Height = 30, // cố định chiều cao
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };

                DateTimePicker dtpDeadline = new DateTimePicker { Value = task.dealine, Format = DateTimePickerFormat.Short, Width = 120, Dock = DockStyle.Fill };
                TextBox txtBox1 = new TextBox { Width = 100, Dock = DockStyle.Fill, Text = task.status };
                TextBox txtBox2 = new TextBox { Width = 100, Dock = DockStyle.Fill, Text = task.projectID };
                Label lblWorkspace = new Label { Text = "My Workspace", AutoSize = false, Width = 150, Dock = DockStyle.Fill };


                tblTask.Controls.Add(checkBox, 0, i);
                tblTask.Controls.Add(dtpDeadline, 1, i);
                tblTask.Controls.Add(txtBox1, 2, i);
                tblTask.Controls.Add(txtBox2, 3, i);
                tblTask.Controls.Add(lblWorkspace, 4, i);
            }
        }

        private void RenderNewTask(Task task)
        {
            tblTask.RowCount += 1;
            CheckBox checkBox = new CheckBox
            {
                Text = task.taskName,
                AutoSize = false,
                Height = 30, // cố định chiều cao
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill
            };

            DateTimePicker dtpDeadline = new DateTimePicker { Value = task.dealine, Format = DateTimePickerFormat.Short, Width = 120, Dock = DockStyle.Fill };
            TextBox txtBox1 = new TextBox { Width = 100, Dock = DockStyle.Fill };
            TextBox txtBox2 = new TextBox { Width = 100, Dock = DockStyle.Fill, Text = task.projectID };
            Label lblWorkspace = new Label { Text = "My Workspace", AutoSize = false, Width = 150, Dock = DockStyle.Fill };


            tblTask.Controls.Add(checkBox, 0, tasks.Count);
            tblTask.Controls.Add(dtpDeadline, 1, tasks.Count);
            tblTask.Controls.Add(txtBox1, 2, tasks.Count);
            tblTask.Controls.Add(txtBox2, 3, tasks.Count);
            tblTask.Controls.Add(lblWorkspace, 4, tasks.Count);

        }

        private void AddTaskToTable(Task task)
        {
            int rowIndex = tblTask.RowCount;

            tblTask.RowCount += 1;
            tblTask.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

            CheckBox checkBox = new CheckBox
            {
                Text = task.taskName,
                AutoSize = false,
                Height = 30, // cố định chiều cao
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill
            };

            DateTimePicker dtpDeadline = new DateTimePicker { Value = task.dealine, Format = DateTimePickerFormat.Short, Width = 120, Dock = DockStyle.Fill };
            TextBox txtBox1 = new TextBox { Width = 100, Dock = DockStyle.Fill };
            TextBox txtBox2 = new TextBox { Width = 100, Dock = DockStyle.Fill, Text = task.projectID };
            Label lblWorkspace = new Label { Text = "My Workspace", AutoSize = false, Width = 150, Dock = DockStyle.Fill };

            tblTask.Controls.Add(checkBox, 0, rowIndex);
            tblTask.Controls.Add(dtpDeadline, 1, rowIndex);
            tblTask.Controls.Add(txtBox1, 2, rowIndex);
            tblTask.Controls.Add(txtBox2, 3, rowIndex);
            tblTask.Controls.Add(lblWorkspace, 4, rowIndex);
        }




        private void mnuBoard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMore_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExpand_Click_1(object sender, EventArgs e)
        {
            tblTask.Visible = !tblTask.Visible;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void paneltask_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnExpandDoToday_Click(object sender, EventArgs e)
        {
            tlpDoToday.Visible = !tlpDoToday.Visible;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMore_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMore, new Point(20, btnMore.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addtask addTaskForm = new Addtask(projects);
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(addTaskForm.NewTask); // Thêm task mới vào danh sách
                //RenderNewTask(addTaskForm.NewTask); // Cập nhật lại danh sách trên giao diện
                AddTaskToTable(addTaskForm.NewTask);
            }
        }

        private void ctmTask_Click(object sender, EventArgs e)
        {
            tasks.Sort();
            RenderTasks(tasks);
        }

        private void ctnApproval_Click(object sender, EventArgs e)
        {
            tasks.Sort();
            tasks.Reverse(); RenderTasks(tasks);
        }

        private void ctmMilestone_Click(object sender, EventArgs e)
        {
            List<Task> taskslistother = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.status == "Hoàn thành")
                {
                    taskslistother.Add(task);
                }
            }
            RenderTasks(taskslistother);
        }

        private void ctnSection_Click(object sender, EventArgs e)
        {
            List<Task> taskslistother = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.status != "Hoàn thành")
                {
                    Console.WriteLine(task.taskName);
                    taskslistother.Add(task);
                }
            }
            RenderTasks(taskslistother);

        }
    }
}
