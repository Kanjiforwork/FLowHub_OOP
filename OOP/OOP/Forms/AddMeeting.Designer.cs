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
            this.SuspendLayout();
            // 
            // lblMeetingName
            // 
            this.lblMeetingName.Location = new System.Drawing.Point(56, 71);
            this.lblMeetingName.Name = "lblMeetingName";
            this.lblMeetingName.Size = new System.Drawing.Size(100, 23);
            this.lblMeetingName.TabIndex = 0;
            this.lblMeetingName.Text = "Nhập tên cuộc hẹn";
            // 
            // txtbMeetingName
            // 
            this.txtbMeetingName.Location = new System.Drawing.Point(215, 71);
            this.txtbMeetingName.Name = "txtbMeetingName";
            this.txtbMeetingName.Size = new System.Drawing.Size(342, 20);
            this.txtbMeetingName.TabIndex = 1;
            // 
            // lblMeetingTime
            // 
            this.lblMeetingTime.Location = new System.Drawing.Point(56, 146);
            this.lblMeetingTime.Name = "lblMeetingTime";
            this.lblMeetingTime.Size = new System.Drawing.Size(100, 23);
            this.lblMeetingTime.TabIndex = 2;
            this.lblMeetingTime.Text = "Nhập thời gian";
            // 
            // dtpMeetingTime
            // 
            this.dtpMeetingTime.Location = new System.Drawing.Point(215, 146);
            this.dtpMeetingTime.Name = "dtpMeetingTime";
            this.dtpMeetingTime.Size = new System.Drawing.Size(342, 20);
            this.dtpMeetingTime.TabIndex = 3;
            // 
            // lblMeetingLocation
            // 
            this.lblMeetingLocation.Location = new System.Drawing.Point(56, 216);
            this.lblMeetingLocation.Name = "lblMeetingLocation";
            this.lblMeetingLocation.Size = new System.Drawing.Size(100, 23);
            this.lblMeetingLocation.TabIndex = 4;
            this.lblMeetingLocation.Text = "Nhập địa điểm";
            // 
            // txtbMeetingLocation
            // 
            this.txtbMeetingLocation.Location = new System.Drawing.Point(215, 213);
            this.txtbMeetingLocation.Name = "txtbMeetingLocation";
            this.txtbMeetingLocation.Size = new System.Drawing.Size(342, 20);
            this.txtbMeetingLocation.TabIndex = 5;
            // 
            // btnChooseMembers
            // 
            this.btnChooseMembers.Location = new System.Drawing.Point(124, 288);
            this.btnChooseMembers.Name = "btnChooseMembers";
            this.btnChooseMembers.Size = new System.Drawing.Size(140, 23);
            this.btnChooseMembers.TabIndex = 6;
            this.btnChooseMembers.Text = "Chọn thành viên";
            this.btnChooseMembers.UseVisualStyleBackColor = true;
            this.btnChooseMembers.Click += new System.EventHandler(this.btnChooseMembers_Click);
            // 
            // clbMeetingMembers
            // 
            this.clbMeetingMembers.FormattingEnabled = true;
            this.clbMeetingMembers.Location = new System.Drawing.Point(299, 258);
            this.clbMeetingMembers.Name = "clbMeetingMembers";
            this.clbMeetingMembers.Size = new System.Drawing.Size(120, 94);
            this.clbMeetingMembers.TabIndex = 7;
            this.clbMeetingMembers.Visible = false;
            // 
            // btnMeetingConfirm
            // 
            this.btnMeetingConfirm.Location = new System.Drawing.Point(105, 377);
            this.btnMeetingConfirm.Name = "btnMeetingConfirm";
            this.btnMeetingConfirm.Size = new System.Drawing.Size(112, 23);
            this.btnMeetingConfirm.TabIndex = 8;
            this.btnMeetingConfirm.Text = "OK";
            this.btnMeetingConfirm.UseVisualStyleBackColor = true;
            this.btnMeetingConfirm.Click += new System.EventHandler(this.btnMeetingConfirm_Click);
            // 
            // btnMeetingCancel
            // 
            this.btnMeetingCancel.Location = new System.Drawing.Point(339, 377);
            this.btnMeetingCancel.Name = "btnMeetingCancel";
            this.btnMeetingCancel.Size = new System.Drawing.Size(112, 23);
            this.btnMeetingCancel.TabIndex = 9;
            this.btnMeetingCancel.Text = "Cancel";
            this.btnMeetingCancel.UseVisualStyleBackColor = true;
            // 
            // AddMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "AddMeeting";
            this.Text = "AddMeeting";
            this.Load += new System.EventHandler(this.AddMeeting_Load);
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
    }
}