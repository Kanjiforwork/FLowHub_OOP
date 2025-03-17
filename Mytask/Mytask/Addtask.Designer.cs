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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbInputName
            // 
            this.lbInputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInputName.Location = new System.Drawing.Point(60, 82);
            this.lbInputName.Name = "lbInputName";
            this.lbInputName.Size = new System.Drawing.Size(119, 20);
            this.lbInputName.TabIndex = 0;
            this.lbInputName.Text = "Nhập tên nhiệm vụ";
            this.lbInputName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbInputNameTask
            // 
            this.txtbInputNameTask.Location = new System.Drawing.Point(217, 82);
            this.txtbInputNameTask.Name = "txtbInputNameTask";
            this.txtbInputNameTask.Size = new System.Drawing.Size(290, 20);
            this.txtbInputNameTask.TabIndex = 1;
            this.txtbInputNameTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbInputID
            // 
            this.lbInputID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInputID.Location = new System.Drawing.Point(60, 131);
            this.lbInputID.Name = "lbInputID";
            this.lbInputID.Size = new System.Drawing.Size(119, 20);
            this.lbInputID.TabIndex = 2;
            this.lbInputID.Text = "Nhập ID";
            this.lbInputID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbInputID
            // 
            this.txtbInputID.Location = new System.Drawing.Point(217, 132);
            this.txtbInputID.Name = "txtbInputID";
            this.txtbInputID.Size = new System.Drawing.Size(290, 20);
            this.txtbInputID.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStatus.Location = new System.Drawing.Point(60, 176);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(119, 20);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Trạng thái";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Hoàn thành",
            "Đang làm"});
            this.cbbStatus.Location = new System.Drawing.Point(217, 174);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(290, 21);
            this.cbbStatus.TabIndex = 5;
            // 
            // lbDeadline
            // 
            this.lbDeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDeadline.Location = new System.Drawing.Point(60, 218);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(119, 20);
            this.lbDeadline.TabIndex = 6;
            this.lbDeadline.Text = "Deadline";
            this.lbDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDeadline.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Addtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbDeadline);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtbInputID);
            this.Controls.Add(this.lbInputID);
            this.Controls.Add(this.txtbInputNameTask);
            this.Controls.Add(this.lbInputName);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}