namespace OOP
{
    partial class Addtask
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
        private void InitializeComponent()
        {
            this.lbInputName = new System.Windows.Forms.Label();
            this.txtbInputNameTask = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.lbDeadline = new System.Windows.Forms.Label();
            this.dtpNewTask = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddinProject = new System.Windows.Forms.Label();
            this.cbbSelectProject = new System.Windows.Forms.ComboBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.WelcomeName = new System.Windows.Forms.Label();
            this.cbbAssignedUser = new System.Windows.Forms.ComboBox();
            this.lblAssignUser = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInputName
            // 
            this.lbInputName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInputName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInputName.Location = new System.Drawing.Point(42, 51);
            this.lbInputName.Name = "lbInputName";
            this.lbInputName.Size = new System.Drawing.Size(128, 20);
            this.lbInputName.TabIndex = 0;
            this.lbInputName.Text = "Nhập tên nhiệm vụ";
            this.lbInputName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbInputNameTask
            // 
            this.txtbInputNameTask.Location = new System.Drawing.Point(199, 51);
            this.txtbInputNameTask.Name = "txtbInputNameTask";
            this.txtbInputNameTask.Size = new System.Drawing.Size(290, 20);
            this.txtbInputNameTask.TabIndex = 1;
            this.txtbInputNameTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStatus.Location = new System.Drawing.Point(42, 93);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(128, 20);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Trạng thái";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Hoàn thành"});
            this.cbbStatus.Location = new System.Drawing.Point(199, 91);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(290, 21);
            this.cbbStatus.TabIndex = 5;
            // 
            // lbDeadline
            // 
            this.lbDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDeadline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeadline.Location = new System.Drawing.Point(42, 134);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(128, 20);
            this.lbDeadline.TabIndex = 6;
            this.lbDeadline.Text = "Deadline";
            this.lbDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDeadline.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpNewTask
            // 
            this.dtpNewTask.Location = new System.Drawing.Point(199, 134);
            this.dtpNewTask.Name = "dtpNewTask";
            this.dtpNewTask.Size = new System.Drawing.Size(290, 20);
            this.dtpNewTask.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConfirm.Location = new System.Drawing.Point(115, 278);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(82, 38);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(359, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddinProject
            // 
            this.btnAddinProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddinProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddinProject.Location = new System.Drawing.Point(42, 178);
            this.btnAddinProject.Name = "btnAddinProject";
            this.btnAddinProject.Size = new System.Drawing.Size(128, 20);
            this.btnAddinProject.TabIndex = 10;
            this.btnAddinProject.Text = "Project";
            this.btnAddinProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbSelectProject
            // 
            this.cbbSelectProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectProject.FormattingEnabled = true;
            this.cbbSelectProject.Location = new System.Drawing.Point(199, 178);
            this.cbbSelectProject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbSelectProject.Name = "cbbSelectProject";
            this.cbbSelectProject.Size = new System.Drawing.Size(290, 21);
            this.cbbSelectProject.TabIndex = 11;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.nightControlBox1);
            this.TopPanel.Controls.Add(this.WelcomeName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(547, 36);
            this.TopPanel.TabIndex = 12;
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
            this.nightControlBox1.Location = new System.Drawing.Point(408, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // WelcomeName
            // 
            this.WelcomeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeName.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.WelcomeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.WelcomeName.Location = new System.Drawing.Point(208, -1);
            this.WelcomeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeName.Name = "WelcomeName";
            this.WelcomeName.Size = new System.Drawing.Size(130, 33);
            this.WelcomeName.TabIndex = 1;
            this.WelcomeName.Text = "Add task";
            this.WelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbAssignedUser
            // 
            this.cbbAssignedUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAssignedUser.FormattingEnabled = true;
            this.cbbAssignedUser.Location = new System.Drawing.Point(199, 220);
            this.cbbAssignedUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbAssignedUser.Name = "cbbAssignedUser";
            this.cbbAssignedUser.Size = new System.Drawing.Size(290, 21);
            this.cbbAssignedUser.TabIndex = 14;
            // 
            // lblAssignUser
            // 
            this.lblAssignUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAssignUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAssignUser.Location = new System.Drawing.Point(42, 220);
            this.lblAssignUser.Name = "lblAssignUser";
            this.lblAssignUser.Size = new System.Drawing.Size(128, 20);
            this.lblAssignUser.TabIndex = 13;
            this.lblAssignUser.Text = "Assign User";
            this.lblAssignUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Addtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(547, 356);
            this.Controls.Add(this.cbbAssignedUser);
            this.Controls.Add(this.lblAssignUser);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.cbbSelectProject);
            this.Controls.Add(this.btnAddinProject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtpNewTask);
            this.Controls.Add(this.lbDeadline);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtbInputNameTask);
            this.Controls.Add(this.lbInputName);
            this.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addtask";
            this.Text = "Addtask";
            this.Load += new System.EventHandler(this.Addtask_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInputName;
        private System.Windows.Forms.TextBox txtbInputNameTask;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label lbDeadline;
        private System.Windows.Forms.DateTimePicker dtpNewTask;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label btnAddinProject;
        private System.Windows.Forms.ComboBox cbbSelectProject;
        private System.Windows.Forms.Panel TopPanel;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label WelcomeName;
        private System.Windows.Forms.ComboBox cbbAssignedUser;
        private System.Windows.Forms.Label lblAssignUser;
    }
}