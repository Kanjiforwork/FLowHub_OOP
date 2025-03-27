namespace OOP.Forms
{
    partial class AddMeeting
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
            this.lblMeetingName = new System.Windows.Forms.Label();
            this.txtbMeetingName = new System.Windows.Forms.TextBox();
            this.lblMeetingTime = new System.Windows.Forms.Label();
            this.dtpMeetingTime = new System.Windows.Forms.DateTimePicker();
            this.lblMeetingLocation = new System.Windows.Forms.Label();
            this.txtbMeetingLocation = new System.Windows.Forms.TextBox();
            this.btnChooseMembers = new System.Windows.Forms.Button();
            this.clbMeetingMembers = new System.Windows.Forms.CheckedListBox();
            this.btnMeetingConfirm = new System.Windows.Forms.Button();
            this.btnMeetingCancel = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.WelcomeName = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMeetingName
            // 
            this.lblMeetingName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeetingName.Location = new System.Drawing.Point(75, 87);
            this.lblMeetingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingName.Name = "lblMeetingName";
            this.lblMeetingName.Size = new System.Drawing.Size(133, 28);
            this.lblMeetingName.TabIndex = 0;
            this.lblMeetingName.Text = "Nhập tên cuộc hẹn";
            // 
            // txtbMeetingName
            // 
            this.txtbMeetingName.Location = new System.Drawing.Point(254, 87);
            this.txtbMeetingName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbMeetingName.Name = "txtbMeetingName";
            this.txtbMeetingName.Size = new System.Drawing.Size(272, 22);
            this.txtbMeetingName.TabIndex = 1;
            // 
            // lblMeetingTime
            // 
            this.lblMeetingTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeetingTime.Location = new System.Drawing.Point(75, 180);
            this.lblMeetingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingTime.Name = "lblMeetingTime";
            this.lblMeetingTime.Size = new System.Drawing.Size(133, 28);
            this.lblMeetingTime.TabIndex = 2;
            this.lblMeetingTime.Text = "Nhập thời gian";
            // 
            // dtpMeetingTime
            // 
            this.dtpMeetingTime.Location = new System.Drawing.Point(254, 180);
            this.dtpMeetingTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMeetingTime.Name = "dtpMeetingTime";
            this.dtpMeetingTime.Size = new System.Drawing.Size(272, 22);
            this.dtpMeetingTime.TabIndex = 3;
            // 
            // lblMeetingLocation
            // 
            this.lblMeetingLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeetingLocation.Location = new System.Drawing.Point(75, 266);
            this.lblMeetingLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingLocation.Name = "lblMeetingLocation";
            this.lblMeetingLocation.Size = new System.Drawing.Size(133, 28);
            this.lblMeetingLocation.TabIndex = 4;
            this.lblMeetingLocation.Text = "Nhập địa điểm";
            // 
            // txtbMeetingLocation
            // 
            this.txtbMeetingLocation.Location = new System.Drawing.Point(254, 262);
            this.txtbMeetingLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbMeetingLocation.Name = "txtbMeetingLocation";
            this.txtbMeetingLocation.Size = new System.Drawing.Size(272, 22);
            this.txtbMeetingLocation.TabIndex = 5;
            // 
            // btnChooseMembers
            // 
            this.btnChooseMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnChooseMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseMembers.Location = new System.Drawing.Point(78, 346);
            this.btnChooseMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseMembers.Name = "btnChooseMembers";
            this.btnChooseMembers.Size = new System.Drawing.Size(187, 28);
            this.btnChooseMembers.TabIndex = 6;
            this.btnChooseMembers.Text = "Chọn thành viên";
            this.btnChooseMembers.UseVisualStyleBackColor = true;
            this.btnChooseMembers.Click += new System.EventHandler(this.btnChooseMembers_Click);
            // 
            // clbMeetingMembers
            // 
            this.clbMeetingMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.clbMeetingMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clbMeetingMembers.FormattingEnabled = true;
            this.clbMeetingMembers.Location = new System.Drawing.Point(330, 328);
            this.clbMeetingMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbMeetingMembers.Name = "clbMeetingMembers";
            this.clbMeetingMembers.Size = new System.Drawing.Size(196, 70);
            this.clbMeetingMembers.TabIndex = 7;
            this.clbMeetingMembers.Visible = false;
            // 
            // btnMeetingConfirm
            // 
            this.btnMeetingConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMeetingConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeetingConfirm.Location = new System.Drawing.Point(100, 426);
            this.btnMeetingConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMeetingConfirm.Name = "btnMeetingConfirm";
            this.btnMeetingConfirm.Size = new System.Drawing.Size(149, 28);
            this.btnMeetingConfirm.TabIndex = 8;
            this.btnMeetingConfirm.Text = "OK";
            this.btnMeetingConfirm.UseVisualStyleBackColor = true;
            this.btnMeetingConfirm.Click += new System.EventHandler(this.btnMeetingConfirm_Click);
            // 
            // btnMeetingCancel
            // 
            this.btnMeetingCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMeetingCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeetingCancel.Location = new System.Drawing.Point(330, 426);
            this.btnMeetingCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMeetingCancel.Name = "btnMeetingCancel";
            this.btnMeetingCancel.Size = new System.Drawing.Size(149, 28);
            this.btnMeetingCancel.TabIndex = 9;
            this.btnMeetingCancel.Text = "Cancel";
            this.btnMeetingCancel.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.WelcomeName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(584, 59);
            this.TopPanel.TabIndex = 16;
            // 
            // WelcomeName
            // 
            this.WelcomeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeName.Location = new System.Drawing.Point(117, 6);
            this.WelcomeName.Name = "WelcomeName";
            this.WelcomeName.Size = new System.Drawing.Size(342, 41);
            this.WelcomeName.TabIndex = 19;
            this.WelcomeName.Text = "Add meeting";
            this.WelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(584, 487);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.btnMeetingCancel);
            this.Controls.Add(this.btnMeetingConfirm);
            this.Controls.Add(this.clbMeetingMembers);
            this.Controls.Add(this.btnChooseMembers);
            this.Controls.Add(this.txtbMeetingLocation);
            this.Controls.Add(this.lblMeetingLocation);
            this.Controls.Add(this.dtpMeetingTime);
            this.Controls.Add(this.lblMeetingTime);
            this.Controls.Add(this.txtbMeetingName);
            this.Controls.Add(this.lblMeetingName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMeeting";
            this.Text = "AddMeeting";
            this.Load += new System.EventHandler(this.AddMeeting_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeetingName;
        private System.Windows.Forms.TextBox txtbMeetingName;
        private System.Windows.Forms.Label lblMeetingTime;
        private System.Windows.Forms.DateTimePicker dtpMeetingTime;
        private System.Windows.Forms.Label lblMeetingLocation;
        private System.Windows.Forms.TextBox txtbMeetingLocation;
        private System.Windows.Forms.Button btnChooseMembers;
        private System.Windows.Forms.CheckedListBox clbMeetingMembers;
        private System.Windows.Forms.Button btnMeetingConfirm;
        private System.Windows.Forms.Button btnMeetingCancel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label WelcomeName;
    }
}