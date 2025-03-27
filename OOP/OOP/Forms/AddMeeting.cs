using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using OOP.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using User = OOP.Models.User;

namespace OOP.Forms
{
    public partial class AddMeeting : Form
    {
        public Meeting newMeeting { get; set; }
        public List<User> users { get; set; }

        public List<Meeting> meetings { get; set; }
        public AddMeeting(List<User> users)
        {
            InitializeComponent();
            this.users = users;
            foreach (User user in users)
            {
                clbMeetingMembers.Items.Add(user.Username);
            }
        }



        private void AddMeeting_Load(object sender, EventArgs e)
        {


        }

        private void btnChooseMembers_Click(object sender, EventArgs e)
        {
            clbMeetingMembers.Visible = !clbMeetingMembers.Visible;
        }

        private void btnMeetingConfirm_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string tasknewID = (rnd.Next(1000, 9999)).ToString();
            List<string> ManageId = new List<string>();
            string location = txtbMeetingLocation.Text;
            List<User> members = new List<User>();

            while (ManageId.Contains(tasknewID))
            {
                tasknewID = (rnd.Next(1000, 9999)).ToString();
            }

            string taskName = txtbMeetingName.Text;
            string status = DateTime.Now.CompareTo(dtpMeetingTime.Value) < 0 ? "Completed" : "Incompleted";
            DateTime deadline = dtpMeetingTime.Value;
            newMeeting = new Meeting(tasknewID, taskName, status, deadline, location, members, User.LoggedInUser.ID);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}