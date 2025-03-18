namespace Mytask
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
            this.lbInputID = new System.Windows.Forms.Label();
            this.txtbInputID = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.lbDeadline = new System.Windows.Forms.Label();
            this.dtpNewTask = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddinProject = new System.Windows.Forms.Label();
            this.cbbSelectProject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbInputName
            // 
            this.lbInputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInputName.Location = new System.Drawing.Point(80, 101);
            this.lbInputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInputName.Name = "lbInputName";
            this.lbInputName.Size = new System.Drawing.Size(158, 24);
            this.lbInputName.TabIndex = 0;
            this.lbInputName.Text = "Nhập tên nhiệm vụ";
            this.lbInputName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbInputNameTask
            // 
            this.txtbInputNameTask.Location = new System.Drawing.Point(289, 101);
            this.txtbInputNameTask.Margin = new System.Windows.Forms.Padding(4);
            this.txtbInputNameTask.Name = "txtbInputNameTask";
            this.txtbInputNameTask.Size = new System.Drawing.Size(385, 22);
            this.txtbInputNameTask.TabIndex = 1;
            this.txtbInputNameTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbInputID
            // 
            this.lbInputID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInputID.Location = new System.Drawing.Point(80, 161);
            this.lbInputID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInputID.Name = "lbInputID";
            this.lbInputID.Size = new System.Drawing.Size(158, 24);
            this.lbInputID.TabIndex = 2;
            this.lbInputID.Text = "Nhập ID";
            this.lbInputID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbInputID
            // 
            this.txtbInputID.Location = new System.Drawing.Point(289, 162);
            this.txtbInputID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbInputID.Name = "txtbInputID";
            this.txtbInputID.Size = new System.Drawing.Size(385, 22);
            this.txtbInputID.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStatus.Location = new System.Drawing.Point(80, 217);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(158, 24);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Trạng thái";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Hoàn thành"});
            this.cbbStatus.Location = new System.Drawing.Point(289, 214);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(385, 24);
            this.cbbStatus.TabIndex = 5;
            // 
            // lbDeadline
            // 
            this.lbDeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDeadline.Location = new System.Drawing.Point(80, 268);
            this.lbDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(158, 24);
            this.lbDeadline.TabIndex = 6;
            this.lbDeadline.Text = "Deadline";
            this.lbDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDeadline.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpNewTask
            // 
            this.dtpNewTask.Location = new System.Drawing.Point(289, 267);
            this.dtpNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNewTask.Name = "dtpNewTask";
            this.dtpNewTask.Size = new System.Drawing.Size(385, 22);
            this.dtpNewTask.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(200, 366);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 47);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(518, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 47);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddinProject
            // 
            this.btnAddinProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAddinProject.Location = new System.Drawing.Point(80, 322);
            this.btnAddinProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAddinProject.Name = "btnAddinProject";
            this.btnAddinProject.Size = new System.Drawing.Size(158, 24);
            this.btnAddinProject.TabIndex = 10;
            this.btnAddinProject.Text = "Project";
            this.btnAddinProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSelectProject
            // 
            this.cbbSelectProject.FormattingEnabled = true;
            this.cbbSelectProject.Location = new System.Drawing.Point(289, 322);
            this.cbbSelectProject.Name = "cbbSelectProject";
            this.cbbSelectProject.Size = new System.Drawing.Size(385, 24);
            this.cbbSelectProject.TabIndex = 11;
            // 
            // Addtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbbSelectProject);
            this.Controls.Add(this.btnAddinProject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtpNewTask);
            this.Controls.Add(this.lbDeadline);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtbInputID);
            this.Controls.Add(this.lbInputID);
            this.Controls.Add(this.txtbInputNameTask);
            this.Controls.Add(this.lbInputName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Addtask";
            this.Text = "Addtask";
            this.Load += new System.EventHandler(this.Addtask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInputName;
        private System.Windows.Forms.TextBox txtbInputNameTask;
        private System.Windows.Forms.Label lbInputID;
        private System.Windows.Forms.TextBox txtbInputID;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label lbDeadline;
        private System.Windows.Forms.DateTimePicker dtpNewTask;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label btnAddinProject;
        private System.Windows.Forms.ComboBox cbbSelectProject;

        
    }
}