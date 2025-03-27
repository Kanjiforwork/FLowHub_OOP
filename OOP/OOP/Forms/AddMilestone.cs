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
using OOP.Models;
namespace OOP.Forms
{
    public partial class AddMilestone : Form
    {
        public Milestone milestone {  get; set; }
        public List<Milestone> milestones = new List<Milestone>();
        public AddMilestone()
        {
            InitializeComponent();
        }

        public AddMilestone(List<Milestone> list)
        {
            this.milestones = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddMilestone_Load(object sender, EventArgs e)
        {

        }

        private void btnMilestoneConfirm_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            string tasknewID = (rnd.Next(1000, 9999)).ToString();
            List<string> ManageId = new List<string>();
            foreach (Milestone task in milestones)
            {
                ManageId.Add(task.taskID);
            }

            while (ManageId.Contains(tasknewID))
            {
                tasknewID = (rnd.Next(1000, 9999)).ToString();
            }

            string taskName = txtbMilestoneName.Text;
            DateTime deadline = dtpMilestonedate.Value;
            milestone = new Milestone(tasknewID, taskName, "UnFinished", deadline, null, User.LoggedInUser.ID);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnMilestoneCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}