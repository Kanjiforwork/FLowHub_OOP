
using OOP.Models;
using OOP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;

using System.IO;
using System.Xml;

namespace OOP
{
    public partial class Projects: Form
    {
        private Label lblProjectDescription;
        List<Panel> projectPosts = new List<Panel>();
        private Button btnBack;

        List<Models.Project> projects = new List<Models.Project>();
       /* private void Inbox_Load(object sender, EventArgs e)
        {
            // Tạo panel chứa các post (cuộn được)
            panelPostContainer = new Panel();
            panelPostContainer.AutoScroll = true;
            panelPostContainer.BorderStyle = BorderStyle.FixedSingle;
            panelPostContainer.Size = new Size(500, 300);
            // panelPostContainer.Location = new Point(textBox1.Location.X, textBox1.Bottom + 10);
            panelPostContainer.Size = new Size(panel1.Width - 40, 120);
            this.Controls.Add(panelPostContainer);
        }*/
        public Projects()
        {
            InitializeComponent();
            // textBox1.KeyDown += textBox1_KeyDown;
            btnBack = new Button();
            btnBack.Text = "Quay về";
            btnBack.Size = new Size(117, 34);
            btnBack.Location = new Point(0, 10);
            btnBack.Visible = false; // Ẩn ban đầu
           // btnBack.Click += BtnBack_Click; // Gắn sự kiện click
            //panel2.Controls.Add(btnBack); // Thêm vào panel2
            LoadProjectsFromFile();

        }


        private List<Label> projectDescriptions = new List<Label>(); // Danh sách để lưu các Label
        private int currentYOffset = 10; // Khoảng cách giữa các dòng mô tả

        //private void textBox1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        MessageBox.Show("Enter Key Pressed!"); // Kiểm tra sự kiện có gọi không
        //        e.SuppressKeyPress = true; // Chặn tiếng "Beep"

        //        string content = textBox1.Text.Trim();
        //        if (string.IsNullOrEmpty(content) || content == "What's this project about")
        //        {
        //            MessageBox.Show("Please enter a valid project description.");
        //            return;
        //        }

        //        AddPost(content);
        //        textBox1.Text = "What's this project about"; // Reset lại textbox
        //        textBox1.ForeColor = Color.Gray;
        //    }
        //}

       /* private void AddPost(string content)
        {
            if (panelPostContainer == null)
            {
                MessageBox.Show("Panel chứa bài post chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo Panel bài post
            Panel postPanel = new Panel();
            postPanel.Size = new Size(panelPostContainer.Width - 10, 70);
            postPanel.BorderStyle = BorderStyle.FixedSingle;
            postPanel.BackColor = Color.White;

            Label lblContent = new Label();
            lblContent.Text = content;
            lblContent.Size = new Size(postPanel.Width - 80, 50);
            lblContent.Font = new Font("Arial", 10, FontStyle.Regular);
            lblContent.Location = new Point(10, 10);

            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Size = new Size(60, 30);
            btnDelete.Location = new Point(postPanel.Width - 70, 20);
            btnDelete.Click += (s, e) =>
            {
                panelPostContainer.Controls.Remove(postPanel);
                projectPosts.Remove(postPanel);
                RearrangePosts();
            };

            // Vị trí bài post mới
            int yOffset = projectPosts.Count * (postPanel.Height + 5);
            postPanel.Location = new Point(5, yOffset);

            postPanel.Controls.Add(lblContent);
            postPanel.Controls.Add(btnDelete);
            projectPosts.Add(postPanel);
            panelPostContainer.Controls.Add(postPanel);

            // Nếu vượt quá chiều cao, bật cuộn
            if (panelPostContainer.Controls.Count * (postPanel.Height + 5) > panelPostContainer.Height)
            {
                panelPostContainer.AutoScroll = true;
            }

            // Cập nhật vị trí listBox1 nhưng không làm nó mất
            //listBox1.Top = Math.Max(button1.Bottom + 10, panelPostContainer.Bottom + 10);
        }*/
        private void SaveProjectsToFile()
        {
            string filePath = "projects.json";
            string json = JsonConvert.SerializeObject(projects, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
            MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadProjectsFromFile()
        {
            if (File.Exists("projects.json"))
            {
                string json = File.ReadAllText("projects.json");
                projects = JsonConvert.DeserializeObject<List<Project>>(json) ?? new List<Project>();
            }
            else
            {
                projects = new List<Project>();
            }

            //LoadProjectButtons(); // Gọi hàm này để load lại UI từ JSON
        }
        private void RearrangePosts()
        {
            for (int i = 0; i < projectPosts.Count; i++)
            {
                projectPosts[i].Location = new Point(10, i * (projectPosts[i].Height + 5));
            }
        }
        //private void AdjustLayout()
        //{
        //    int yOffset = textBox1.Bottom + 10;
        //    foreach (Control ctrl in panel1.Controls)
        //    {
        //        if (ctrl is Panel && ctrl != textBox1.Parent)
        //        {
        //            ctrl.Location = new Point(10, yOffset);
        //            yOffset = ctrl.Bottom + 10;
        //        }
        //    }

        //    label2.Location = new Point(label2.Location.X, yOffset + 20);
        //    button1.Location = new Point(button1.Location.X, label2.Bottom + 10);
        //    listBox1.Location = new Point(listBox1.Location.X, button1.Bottom + 10);
        //}
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 10, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 260 };
                Button confirmation = new Button() { Text = "OK", Left = 100, Width = 100, Top = 80 };

                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                prompt.ShowDialog();
                return textBox.Text;
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }

        //public void textBox1_Enter(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "What's this project about")
        //    {
        //        textBox1.Text = "";
        //        textBox1.ForeColor = System.Drawing.Color.Black;
        //    }
        //}

        //private void textBox1_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(textBox1.Text))
        //    {
        //        textBox1.Text = "What's this project about";
        //        textBox1.ForeColor = System.Drawing.Color.Gray;
        //    }
        //}
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }
        public void AddMember(string username, RoleType role)
        {
            //listBox1.Items.Add($"{username} - {role}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //singleton
        //
        //
        //
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            // Hiện hộp thoại yêu cầu nhập tên dự án
            string inputName = Prompt.ShowDialog("Nhập tên dự án:", "Tạo Project");

            if (string.IsNullOrWhiteSpace(inputName))
            {
                MessageBox.Show("Tên dự án không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID dự án (giả sử dựa trên số lượng dự án hiện tại)
            int projectID = projects.Count + 1;

            // Mô tả mặc định cho dự án
            string projectDescription = "Mô tả của " + inputName;

            // Quyền mặc định cho người tạo là 'Admin'
            RoleType defaultRole = RoleType.Admin;

            // Sử dụng tên người dùng đăng nhập làm người tạo dự án
            string createdBy = User.GetLoggedInUserName();

            // Tạo dự án mới
            Project newProject = new Project(projectID, inputName, projectDescription, defaultRole);
            newProject.CreatedBy = createdBy; // Gán người tạo dự án

            // Thêm vào danh sách dự án
            projects.Add(newProject);

            // Lưu dự án vào file
            SaveProjectsToFile();

            // Thêm nút dự án mới vào giao diện

            //AddProjectButton(newProject); // Chỉ thêm nút mới, không load lại toàn bộ danh sách
        }


       /* private void BtnBack_Click(object sender, EventArgs e)
        {
            panel3.Visible = false; // Ẩn panel3 (hiển thị chi tiết project)
            panel2.Visible = true;  // Hiển thị lại danh sách dự án

            // Kiểm tra xem đã có nút dự án nào chưa
            if (panel2.Controls.OfType<Button>().Count() == projects.Count)
                return; // Nếu số lượng nút đã khớp với số project, không cần thêm lại

            panel2.Controls.Clear(); // Xóa UI cũ

            // Ẩn nút "Quay về"
            btnBack.Visible = false;

            // Hiển thị lại danh sách project
            foreach (var project in projects)
            {
                Button btnProject = new Button();
                btnProject.Text = project.projectName;
                btnProject.Size = new Size(117, 34);
                btnProject.BackColor = Color.LightGray;
                btnProject.Tag = project;

                int yOffset = panel2.Controls.Count * 50;
                btnProject.Location = new Point(0, yOffset);

                btnProject.Click += (s, ev) =>
                {
                    Project selectedProject = (Project)((Button)s).Tag;
                    ShowProjectDetails(selectedProject);
                };

                panel2.Controls.Add(btnProject);
            }
        }*/




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowProjectDetails(Project project)
        {
            panel3.Controls.Clear(); // Xóa nội dung cũ trong panel3

            // Tạo nút Overview (đặt trên cùng)
            Button btnOverview = new Button();
            btnOverview.Text = "Overview";
            btnOverview.Size = new Size(100, 30);
            btnOverview.Location = new Point(5, 10);
            btnOverview.BackColor = Color.LightBlue;
            btnOverview.Click += (s, e) =>
            {
                LoadOverviewPanel(project);
            };
            panel3.Controls.Add(btnOverview);

            // Gọi Overview mặc định
            LoadOverviewPanel(project);

            // Hiển thị panel3 và ẩn panel2
            panel3.Visible = true;
            //panel2.Visible = false;
        }

        // Hiển thị thông tin Overview của project
        private void LoadOverviewPanel(Project project)
        {
            panel3.Controls.Clear(); // Xóa nội dung cũ

            // Tạo nút Overview trên cùng
            Button btnOverview = new Button();
            btnOverview.Text = "Overview";
            btnOverview.Size = new Size(100, 30);
            btnOverview.Location = new Point(5, 10);
            btnOverview.BackColor = Color.LightBlue;
            panel3.Controls.Add(btnOverview);

            // Label Project Description
            Label lblProjectDesc = new Label();
            lblProjectDesc.Text = "Project Description";
            lblProjectDesc.Font = new Font("Arial", 12, FontStyle.Bold);
            lblProjectDesc.Location = new Point(10, 50);
            panel3.Controls.Add(lblProjectDesc);

            // Hiển thị tên người tạo
            Label lblCreator = new Label();
            lblCreator.Text = $"Created by: {project.CreatedBy}"; // Hiển thị người tạo dự án
            lblCreator.Font = new Font("Arial", 10, FontStyle.Regular);
            lblCreator.Location = new Point(10, 110);
            panel3.Controls.Add(lblCreator);

            // TextBox nhập mô tả dự án
            TextBox txtDescription = new TextBox();
            txtDescription.Text = project.projectDescription;
            txtDescription.Size = new Size(300, 30);
            txtDescription.Location = new Point(10, 80);

            // Xử lý sự kiện KeyDown (lưu khi nhấn Enter)
            txtDescription.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)  // Kiểm tra nếu phím Enter được nhấn
                {
                    project.projectDescription = txtDescription.Text; // Cập nhật mô tả vào đối tượng Project
                    SaveProjectsToFile(); // Lưu lại dự án vào file sau khi thay đổi
                    MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Hiển thị thông báo
                    e.Handled = true;  // Ngăn chặn việc nhấn Enter làm textBox mất focus
                }
            };

            panel3.Controls.Add(txtDescription);

            // Label Project Role
            Label lblRole = new Label();
            lblRole.Text = "Project Role";
            lblRole.Font = new Font("Arial", 12, FontStyle.Bold);
            lblRole.Location = new Point(10, 120);
            panel3.Controls.Add(lblRole);

            // ListBox hiển thị thành viên
            ListBox listBoxMembers = new ListBox();
            listBoxMembers.Size = new Size(200, 100);
            listBoxMembers.Location = new Point(10, 150);
            listBoxMembers.Items.Clear();

            if (project.members == null)
            {
                project.members = new List<string>();
            }
            listBoxMembers.Items.AddRange(project.members.ToArray());
            panel3.Controls.Add(listBoxMembers);

            // Button thêm thành viên
            Button btnAddMember = new Button();
            btnAddMember.Text = "Add Member";
            btnAddMember.Size = new Size(100, 30);
            btnAddMember.Location = new Point(10, 260);
            btnAddMember.Click += (s, e) =>
            {
                Addmember userForm = new Addmember();
                if (userForm.ShowDialog() == DialogResult.OK)
                {
                    string newMember = userForm.MemberName;
                    RoleType newRole = userForm.SelectedRole;
                    string memberInfo = $"{newMember} ({newRole})";

                    if (!string.IsNullOrWhiteSpace(newMember) && !project.members.Contains(memberInfo))
                    {
                        project.members.Add(memberInfo);
                        listBoxMembers.Items.Add(memberInfo);
                    }
                }
            };
            panel3.Controls.Add(btnAddMember);

            // Nút quay lại
            Button btnBack = new Button();
            btnBack.Text = "Back";
            btnBack.Size = new Size(100, 30);
            btnBack.Location = new Point(120, 260);
            btnBack.Click += (s, e) =>
            {
                panel3.Visible = false;  // Ẩn panel3
                //panel2.Visible = true;   // Hiển thị danh sách project
            };
            panel3.Controls.Add(btnBack);
        }


      /*  private void LoadProjectButtons()
        {
            panel2.Controls.Clear(); // Xóa hết các nút cũ trước khi load lại

            foreach (var project in projects)
            {
                AddProjectButton(project);
            }
        }*/
       /* private void AddProjectButton(Project project)
        {
            Button btnProject = new Button();
            btnProject.Text = project.projectName;
            btnProject.Size = new Size(117, 34);
            btnProject.BackColor = Color.LightGray;
            btnProject.Tag = project;

            int yOffset = panel2.Controls.Count * 50;
            btnProject.Location = new Point(0, yOffset);

            btnProject.Click += (s, ev) =>
            {
                Project selectedProject = (Project)((Button)s).Tag;
                ShowProjectDetails(selectedProject);
            };

            panel2.Controls.Add(btnProject);
        }*/



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Projects_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

}
