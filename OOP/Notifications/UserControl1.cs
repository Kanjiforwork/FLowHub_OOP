using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void SetNotificationData(Image avatar, string senderName, DateTime sendDate, string content)
        {
            Avatar.Image = avatar;
            SenderName.Text = senderName;
            SendDate.Text = sendDate.ToString();
            Content.Text = content;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Avatar_Click(object sender, EventArgs e)
        {

        }

        private void Content_Click(object sender, EventArgs e)
        {

        }
    }
}
