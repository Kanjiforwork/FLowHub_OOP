using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP
{
    partial class Projects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectName = new System.Windows.Forms.Label();
            this.projectRole = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WelcomeName = new System.Windows.Forms.Label();
            this.projectPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.projectContainer = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new ReaLTaiizor.Controls.Panel();
            this.panel5 = new ReaLTaiizor.Controls.Panel();
            this.panel6 = new ReaLTaiizor.Controls.Panel();
            this.menu = new ReaLTaiizor.Controls.Panel();
            this.panel7 = new ReaLTaiizor.Controls.Panel();
            this.btnHome = new ReaLTaiizor.Controls.Button();
            this.btnTask = new ReaLTaiizor.Controls.Button();
            this.btnNoti = new ReaLTaiizor.Controls.Button();
            this.btnProject = new ReaLTaiizor.Controls.Button();
            this.btnUser = new ReaLTaiizor.Controls.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.btnAddMember = new ReaLTaiizor.Controls.Button();
            this.description = new OOP.PlaceholderTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.projectPanel.SuspendLayout();
            this.projectContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(243, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 486);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.description);
            this.panel3.Controls.Add(this.btnAddMember);
            this.panel3.Controls.Add(this.projectName);
            this.panel3.Controls.Add(this.projectRole);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 517);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(281, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 53);
            this.panel2.TabIndex = 6;
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.projectName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projectName.Location = new System.Drawing.Point(14, -8);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(247, 48);
            this.projectName.TabIndex = 1;
            this.projectName.Text = "Project Name";
            this.projectName.Click += new System.EventHandler(this.label1_Click);
            // 
            // projectRole
            // 
            this.projectRole.AutoSize = true;
            this.projectRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.projectRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projectRole.Location = new System.Drawing.Point(14, 337);
            this.projectRole.Name = "projectRole";
            this.projectRole.Size = new System.Drawing.Size(222, 48);
            this.projectRole.TabIndex = 2;
            this.projectRole.Text = "Project Role";
            this.projectRole.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 69);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xóa Project";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tạo Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.nightControlBox1);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.btnHam);
            this.TopPanel.Controls.Add(this.WelcomeName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 73);
            this.TopPanel.TabIndex = 10;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1061, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(76, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "FlowHub";
            // 
            // WelcomeName
            // 
            this.WelcomeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeName.Location = new System.Drawing.Point(212, 10);
            this.WelcomeName.Name = "WelcomeName";
            this.WelcomeName.Size = new System.Drawing.Size(983, 51);
            this.WelcomeName.TabIndex = 1;
            this.WelcomeName.Text = "Welcome back";
            this.WelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectPanel
            // 
            this.projectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectPanel.Controls.Add(this.label6);
            this.projectPanel.Controls.Add(this.projectContainer);
            this.projectPanel.Controls.Add(this.button3);
            this.projectPanel.Controls.Add(this.button2);
            this.projectPanel.Location = new System.Drawing.Point(257, 84);
            this.projectPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projectPanel.Name = "projectPanel";
            this.projectPanel.Size = new System.Drawing.Size(648, 116);
            this.projectPanel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 38);
            this.label6.TabIndex = 2;
            this.label6.Text = "My Projects";
            // 
            // projectContainer
            // 
            this.projectContainer.Controls.Add(this.panel11);
            this.projectContainer.Location = new System.Drawing.Point(180, -1);
            this.projectContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projectContainer.Name = "projectContainer";
            this.projectContainer.Size = new System.Drawing.Size(247, 111);
            this.projectContainer.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox5);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Location = new System.Drawing.Point(19, 29);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(215, 65);
            this.panel11.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(91, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 38);
            this.label7.TabIndex = 4;
            this.label7.Text = "School";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.menu);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 73);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(214, 691);
            this.sidebar.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.EdgeColor = System.Drawing.Color.Transparent;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.panel4.Size = new System.Drawing.Size(328, 68);
            this.panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel4.TabIndex = 4;
            this.panel4.Text = "Dashboard";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel5.Controls.Add(this.btnTask);
            this.panel5.EdgeColor = System.Drawing.Color.Transparent;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(3, 80);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.panel5.Size = new System.Drawing.Size(328, 68);
            this.panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel5.TabIndex = 4;
            this.panel5.Text = "Dashboard";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel6.Controls.Add(this.btnNoti);
            this.panel6.EdgeColor = System.Drawing.Color.Transparent;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(3, 156);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.panel6.Size = new System.Drawing.Size(328, 68);
            this.panel6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel6.TabIndex = 5;
            this.panel6.Text = "Dashboard";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.menu.Controls.Add(this.btnProject);
            this.menu.EdgeColor = System.Drawing.Color.Transparent;
            this.menu.ForeColor = System.Drawing.Color.Transparent;
            this.menu.Location = new System.Drawing.Point(0, 228);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.menu.Size = new System.Drawing.Size(328, 68);
            this.menu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.menu.TabIndex = 3;
            this.menu.Text = "Dashboard";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel7.Controls.Add(this.btnUser);
            this.panel7.EdgeColor = System.Drawing.Color.Transparent;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(3, 300);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.panel7.Size = new System.Drawing.Size(328, 68);
            this.panel7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel7.TabIndex = 6;
            this.panel7.Text = "Dashboard";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnHome.EnteredColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Image = global::OOP.Properties.Resources.Home__2_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.InactiveColor = System.Drawing.Color.Transparent;
            this.btnHome.Location = new System.Drawing.Point(17, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.btnHome.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnHome.PressedColor = System.Drawing.Color.Transparent;
            this.btnHome.Size = new System.Drawing.Size(305, 56);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "              Home";
            this.btnHome.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.Transparent;
            this.btnTask.BorderColor = System.Drawing.Color.Transparent;
            this.btnTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTask.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnTask.EnteredColor = System.Drawing.Color.Transparent;
            this.btnTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTask.Image = global::OOP.Properties.Resources.image__1___1_1;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.InactiveColor = System.Drawing.Color.Transparent;
            this.btnTask.Location = new System.Drawing.Point(17, 6);
            this.btnTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTask.Name = "btnTask";
            this.btnTask.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.btnTask.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnTask.PressedColor = System.Drawing.Color.Transparent;
            this.btnTask.Size = new System.Drawing.Size(305, 56);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "              Task";
            this.btnTask.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnNoti
            // 
            this.btnNoti.BackColor = System.Drawing.Color.Transparent;
            this.btnNoti.BorderColor = System.Drawing.Color.Transparent;
            this.btnNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoti.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnNoti.EnteredColor = System.Drawing.Color.Transparent;
            this.btnNoti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNoti.Image = global::OOP.Properties.Resources.noti;
            this.btnNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoti.InactiveColor = System.Drawing.Color.Transparent;
            this.btnNoti.Location = new System.Drawing.Point(17, 6);
            this.btnNoti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.btnNoti.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnNoti.PressedColor = System.Drawing.Color.Transparent;
            this.btnNoti.Size = new System.Drawing.Size(305, 56);
            this.btnNoti.TabIndex = 2;
            this.btnNoti.Text = "              Notification";
            this.btnNoti.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnNoti.Click += new System.EventHandler(this.btnNoti_Click);
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.Color.Transparent;
            this.btnProject.BorderColor = System.Drawing.Color.Transparent;
            this.btnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProject.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnProject.EnteredColor = System.Drawing.Color.Transparent;
            this.btnProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProject.Image = global::OOP.Properties.Resources.image;
            this.btnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.InactiveColor = System.Drawing.Color.Transparent;
            this.btnProject.Location = new System.Drawing.Point(17, 6);
            this.btnProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProject.Name = "btnProject";
            this.btnProject.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.btnProject.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnProject.PressedColor = System.Drawing.Color.Transparent;
            this.btnProject.Size = new System.Drawing.Size(305, 56);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "               Project";
            this.btnProject.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.BorderColor = System.Drawing.Color.Transparent;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUser.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnUser.EnteredColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUser.Image = global::OOP.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.InactiveColor = System.Drawing.Color.Transparent;
            this.btnUser.Location = new System.Drawing.Point(17, 6);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.btnUser.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnUser.PressedColor = System.Drawing.Color.Transparent;
            this.btnUser.Size = new System.Drawing.Size(305, 56);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "              User";
            this.btnUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(17, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // btnHam
            // 
            this.btnHam.Image = global::OOP.Properties.Resources.image__8_;
            this.btnHam.Location = new System.Drawing.Point(25, 19);
            this.btnHam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(45, 36);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.btnAddMember.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnAddMember.EnteredColor = System.Drawing.Color.Transparent;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddMember.Image = global::OOP.Properties.Resources.add_White;
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.InactiveColor = System.Drawing.Color.Transparent;
            this.btnAddMember.Location = new System.Drawing.Point(22, 406);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.btnAddMember.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnAddMember.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddMember.Size = new System.Drawing.Size(195, 56);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "           Add Member";
            this.btnAddMember.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnAddMember.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.description.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.description.ForeColor = System.Drawing.Color.Gray;
            this.description.Location = new System.Drawing.Point(22, 52);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.PlaceholderText = "What\'s this project about";
            this.description.Size = new System.Drawing.Size(838, 253);
            this.description.TabIndex = 5;
            this.description.Text = "What\'s this project about";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 764);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.projectPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.projectPanel.ResumeLayout(false);
            this.projectPanel.PerformLayout();
            this.projectContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel1;
        private Button button3;
        private Button button2;
        private Panel TopPanel;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label3;
        private PictureBox btnHam;
        private Label WelcomeName;
        private Panel panel3;
        private Label projectName;
        private Label projectRole;
        private Panel projectPanel;
        private Label label6;
        private Panel projectContainer;
        private Panel panel11;
        private PictureBox pictureBox5;
        private Label label7;
        private ReaLTaiizor.Controls.Button btnAddMember;
        private PlaceholderTextBox description;
        private Panel panel2;
        private FlowLayoutPanel sidebar;
        private ReaLTaiizor.Controls.Panel panel4;
        private ReaLTaiizor.Controls.Button btnHome;
        private ReaLTaiizor.Controls.Panel panel5;
        private ReaLTaiizor.Controls.Button btnTask;
        private ReaLTaiizor.Controls.Panel panel6;
        private ReaLTaiizor.Controls.Button btnNoti;
        private ReaLTaiizor.Controls.Panel menu;
        private ReaLTaiizor.Controls.Button btnProject;
        private ReaLTaiizor.Controls.Panel panel7;
        private ReaLTaiizor.Controls.Button btnUser;
    }
}