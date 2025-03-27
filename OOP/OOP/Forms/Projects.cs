using OOP.Models;
using OOP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

using System.IO;
using System.Xml;
using OOP.Usercontrols;
using System.Reflection;
using System.Web.UI.Design;

namespace OOP
{
    public partial class Projects : BaseForm
    {
        private Label lblProjectDescription;
        List<Panel> projectPosts = new List<Panel>();
        private Button btnBack;
        private int selectedProjectID = -1;
        List<Models.Project> projects = new List<Models.Project>();
      
        public Projects()
        {
            InitializeComponent();

            LoadProjectsFromFile();
            UpdateComboBox();

        }

      
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
            string projectDescription = "What's this project about ";

            // Quyền mặc định cho người tạo là 'Admin'
            RoleType defaultRole = RoleType.Admin;

            // Sử dụng tên người dùng đăng nhập làm người tạo dự án
            string createdBy = User.GetLoggedInUserName();

            // Tạo dự án mới
            Project newProject = new Project(projectID, inputName, projectDescription, defaultRole);
            newProject.CreatedBy = createdBy; // Gán người tạo dự án

            newProject.AdminID = User.LoggedInUser.ID;
            newProject.AdminName = User.LoggedInUser.Username;

            // Thêm vào danh sách dự án
            projects.Add(newProject);

            // Lưu dự án vào file
            SaveProjectsToFile();
            // thêm vào comboBox1
            comboBox1.Items.Add($"{newProject.projectID} - {newProject.projectName}");

            // Thêm nút dự án mới vào giao diện

            //AddProjectButton(newProject); // Chỉ thêm nút mới, không load lại toàn bộ danh sách
        }








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
                Addmember userForm = new Addmember(this);
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
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một project!");
                return;
            }

            int selectedProjectID = int.Parse(comboBox1.SelectedItem.ToString().Split('-')[0].Trim());
            Project selectedProject = null;

            foreach (Project p in projects)
            {
                if (p.projectID == selectedProjectID)
                {
                    selectedProject = p;
                    break;
                }
            }

            if (selectedProject != null)
            {
                Addmember userForm = new Addmember(this);
                if (userForm.ShowDialog() == DialogResult.OK)
                {
                    string newMember = userForm.MemberName;
                    string role = userForm.SelectedRole.ToString();
                    string memberInfo = $"{newMember} \n({role})"; 

                    selectedProject.members.Add(memberInfo);

                    DisplayMembers(selectedProject);
                    SaveProjectsToFile();
                }
            }
        }

        private ProjectManager projectManager = new ProjectManager();
        private void UpdateComboBox()
        {
            comboBox1.Items.Clear();
            foreach (Project project in projectManager.Projects)
            {
                Console.WriteLine($"Project: {project.projectID} - {project.projectName}, AdminID: {project.AdminID}, Members: {string.Join(", ", project.members)}");
                if (project.AdminID == User.LoggedInUser.ID || project.members.Contains(User.LoggedInUser.Username))
                {
                    comboBox1.Items.Add($"{project.projectID} - {project.projectName}");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedProjectID == -1)
            {
                MessageBox.Show("Vui lòng chọn một project để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa project ID {selectedProjectID}?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (projectManager == null)
                    {
                        MessageBox.Show("Hệ thống chưa khởi tạo project manager!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xóa project theo ID
                    projectManager.DeleteProject(selectedProjectID);
                    projectManager.SaveProjectsToFile();
                    LoadProjectsFromFile();
                    UpdateComboBox();
                    // Xóa khỏi comboBox1
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString().StartsWith($"{selectedProjectID} -"))
                        {
                            comboBox1.Items.RemoveAt(i);
                            break;
                        }
                    }

                    selectedProjectID = -1; // Reset ID sau khi xóa
                    MessageBox.Show("Project đã được xóa!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void projectContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (projects.Count == 0)
            {
                MessageBox.Show("Danh sách dự án trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            comboBox1.Items.Clear();

            foreach (Project project in projects)
            {
                comboBox1.Items.Add($"{project.projectID} - {project.projectName}");
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) // Kiểm tra nếu có project được chọn
            {
                string selectedProjectText = comboBox1.SelectedItem.ToString();

                if (int.TryParse(selectedProjectText.Split('-')[0].Trim(), out selectedProjectID)) // Gán ID vào biến toàn cục
                {
                    // Tìm project theo ID
                    Project selectedProject = null;
                    foreach (Project project in projects)
                    {
                        if (project.projectID == selectedProjectID)
                        {
                            selectedProject = project;
                            break; // Thoát vòng lặp khi tìm thấy project
                        }
                    }

                    if (selectedProject != null)
                    {
                        description.Text = selectedProject.projectDescription;
                        // Hiển thị mô tả của project
                        DisplayMembers(selectedProject);
                    }
                }
                else
                {
                    selectedProjectID = -1; // Nếu parse thất bại, reset ID
                }
            }
        }


        private void description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra nếu nhấn Enter
            {
                if (comboBox1.SelectedIndex != -1) // Đảm bảo có project được chọn
                {
                    string selectedProjectText = comboBox1.SelectedItem.ToString();
                    int selectedProjectID = int.Parse(selectedProjectText.Split('-')[0].Trim());

                    // Tìm project theo ID bằng vòng lặp
                    Project selectedProject = null;
                    foreach (Project project in projects)
                    {
                        if (project.projectID == selectedProjectID)
                        {
                            selectedProject = project;
                            break; // Thoát vòng lặp ngay khi tìm thấy
                        }
                    }

                    if (selectedProject != null)
                    {
                        selectedProject.projectDescription = description.Text; // Cập nhật mô tả

                        SaveProjectsToFile(); // Lưu vào file JSON
                        MessageBox.Show("Mô tả đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void DisplayMembers(Project project)
        {
            memberPanel.Controls.Clear(); // Xóa danh sách cũ để tránh trùng lặp
            List<string> members = project.members;
            MemberItem OwnerItem = new MemberItem(project.AdminName, true);
            OwnerItem.Dock = DockStyle.Left; // Stack Project from top to bottom
            memberPanel.Controls.Add(OwnerItem);

            foreach (string member in members)
            {
                    MemberItem memberItem = new MemberItem(member, false);
                    memberItem.Dock = DockStyle.Left; // Stack Project from top to bottom
                    memberPanel.Controls.Add(memberItem);
                   // ApplyMouseEvents(projectItem.ProjectPanel);
            }

        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void memberItem1_Load(object sender, EventArgs e)
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication(); // Gọi hàm chung để thoát
        }

        private void description_Enter(object sender, EventArgs e)
        {
            description.ForeColor = Color.Gray; // Giữ màu đúng khi nhập vào
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            description.ForeColor = Color.Gray; // Cập nhật màu khi nhập
        }
    }

}