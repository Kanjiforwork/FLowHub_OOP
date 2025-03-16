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

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            //Mouse Hover
            ApplyMouseEvents(TopPanel);
            ApplyMouseEvents(projectPanel);
            ApplyMouseEvents(taskPanel);
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


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(Object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 72)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 150)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private Timer timer;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cập nhật thời gian ban đầu và người dùng
            UpdateDateTime();
            UpdateName();

            // Tạo và cấu hình Timer
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += (s, ev) => UpdateDateTime();
            timer.Start();
        }
        private void UpdateDateTime()
        {
            timeDetail.Text = DateTime.Now.ToString("dddd, 'ngày' dd 'tháng' M");
        }
        private void UpdateName()
        {
            WelcomeName.Text = "Welcome back, Kanji";
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }












        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void Completed_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
