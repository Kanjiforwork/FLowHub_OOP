using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class NotiUserControl : UserControl
    {
        public NotiUserControl()
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
        private void NotiUserControl_Load(object sender, EventArgs e)
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