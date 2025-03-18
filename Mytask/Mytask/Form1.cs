using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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

            foreach ( ToolStripItem tsi in menuStrip1.Items)
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
        private void Form1_Load(object sender, EventArgs e)
        {
            
            tasks.Add(new Task("1", "hoàn thành báo cáo", "đang làm", new DateTime(2025, 3, 20)));
            tasks.Add(new Task("2", "họp nhóm", "chưa bắt đầu", new DateTime(2025, 3, 21)));
            tasks.Add(new Task("3", "kiểm tra code", "hoàn thành", new DateTime(2025, 3, 18)));
            tasks.Add(new Task("4", "gửi email khách hàng", "chưa bắt đầu", new DateTime(2025, 3, 22)));
            tasks.Add(new Task("5", "viết tài liệu", "đang làm", new DateTime(2025, 3, 25)));
            tasks.Add(new Task("6", "cập nhật database", "chưa bắt đầu", new DateTime(2025, 3, 23)));
            tasks.Add(new Task("7", "fix bug giao diện", "đang làm", new DateTime(2025, 3, 19)));
            tasks.Add(new Task("8", "test hệ thống", "hoàn thành", new DateTime(2025, 3, 17)));
            tasks.Add(new Task("9", "đánh giá tiến độ", "chưa bắt đầu", new DateTime(2025, 3, 24)));
            tasks.Add(new Task("10", "báo cáo tổng kết", "đang làm", new DateTime(2025, 3, 26)));

            RenderTasks(tasks);
        }

        private void RenderTasks(List<Task> tasks)
        {
            tblTask.Controls.Clear();
            tblTask.RowCount = tasks.Count;
            tblTask.ColumnCount = 5;
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
                tblTask.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F)); // đặt chiều cao cố định cho từng hàng
            }


            for (int i = 0; i < tasks.Count; i++)
            {
                Task task = tasks[i];

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
                TextBox txtBox2 = new TextBox { Width = 100, Dock = DockStyle.Fill };
                Label lblWorkspace = new Label { Text = "My Workspace", AutoSize = false, Width = 150, Dock = DockStyle.Fill };

                tblTask.Controls.Add(checkBox, 0, i);
                tblTask.Controls.Add(dtpDeadline, 1, i);
                tblTask.Controls.Add(txtBox1, 2, i);
                tblTask.Controls.Add(txtBox2, 3, i);
                tblTask.Controls.Add(lblWorkspace, 4, i);
            }
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
            tlpDoToday.Visible =!tlpDoToday.Visible;
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
            Addtask addTaskForm = new Addtask();
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(addTaskForm.NewTask); // Thêm task mới vào danh sách
                RenderTasks(tasks); // Cập nhật lại danh sách trên giao diện
            }
        }
    }
}
