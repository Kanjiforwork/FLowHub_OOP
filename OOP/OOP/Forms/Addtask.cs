using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using Task = OOP.Models.Task;

namespace OOP
{
    public partial class Addtask : Form
    {
        public Task NewTask { get; set; }
        List<Project> projects;
        List<AbaseTask> tasks;
        List<User> users;


        public Addtask(List<Project> projects, List<AbaseTask> tasks, List<User> users)
        {
            InitializeComponent();
            this.projects = projects;
            this.tasks = tasks;
            this.users = users;
        }

        private void Addtask_Load(object sender, EventArgs e)
        {

            foreach (Project p in this.projects)
            {
                cbbSelectProject.Items.Add(p.projectName);
            }
            foreach (User u in users)
            {
                cbbAssignedUser.Items.Add(u.Username);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            string tasknewID = (rnd.Next(1000, 9999)).ToString();
            List<string> ManageId = new List<string>();
            foreach (Task task in tasks)
            {
                ManageId.Add(task.taskID);
            }

            while (ManageId.Contains(tasknewID))
            {
                tasknewID = (rnd.Next(1000, 9999)).ToString();
            }

            string taskName = txtbInputNameTask.Text;
            string status = cbbStatus.Text;
            DateTime deadline = dtpNewTask.Value;
            string projectName = cbbSelectProject.Text;

            NewTask = new Task(tasknewID, taskName, status, deadline, projectName, User.LoggedInUser.ID);
            DialogResult = DialogResult.OK;
            Close();


        }
    }
}