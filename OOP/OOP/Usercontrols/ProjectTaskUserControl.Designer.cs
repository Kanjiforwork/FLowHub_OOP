namespace OOP.Usercontrols
{
    partial class ProjectTaskUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.taskContent = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.PictureBox();
            this.taskDeadline = new System.Windows.Forms.Label();
            this.taskProject = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.taskProject);
            this.panel9.Controls.Add(this.taskContent);
            this.panel9.Controls.Add(this.checkBox);
            this.panel9.Controls.Add(this.taskDeadline);
            this.panel9.Location = new System.Drawing.Point(8, 8);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(908, 52);
            this.panel9.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Milestone:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taskContent
            // 
            this.taskContent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskContent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.taskContent.Location = new System.Drawing.Point(175, 5);
            this.taskContent.Name = "taskContent";
            this.taskContent.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.taskContent.Size = new System.Drawing.Size(464, 40);
            this.taskContent.TabIndex = 3;
            this.taskContent.Text = "Check bài nhóm";
            this.taskContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox
            // 
            this.checkBox.ErrorImage = global::OOP.Properties.Resources.check;
            this.checkBox.InitialImage = null;
            this.checkBox.Location = new System.Drawing.Point(17, 9);
            this.checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(32, 31);
            this.checkBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkBox.TabIndex = 1;
            this.checkBox.TabStop = false;
            // 
            // taskDeadline
            // 
            this.taskDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskDeadline.ForeColor = System.Drawing.SystemColors.Highlight;
            this.taskDeadline.Location = new System.Drawing.Point(645, 5);
            this.taskDeadline.Name = "taskDeadline";
            this.taskDeadline.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.taskDeadline.Size = new System.Drawing.Size(120, 44);
            this.taskDeadline.TabIndex = 2;
            this.taskDeadline.Text = "29/03/2025";
            this.taskDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taskProject
            // 
            this.taskProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.taskProject.ForeColor = System.Drawing.SystemColors.Highlight;
            this.taskProject.Location = new System.Drawing.Point(771, 5);
            this.taskProject.Name = "taskProject";
            this.taskProject.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.taskProject.Size = new System.Drawing.Size(136, 44);
            this.taskProject.TabIndex = 4;
            this.taskProject.Text = "cho Bảo";
            this.taskProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectTaskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel9);
            this.Name = "ProjectTaskUserControl";
            this.Size = new System.Drawing.Size(928, 68);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label taskContent;
        private System.Windows.Forms.PictureBox checkBox;
        private System.Windows.Forms.Label taskDeadline;
        private System.Windows.Forms.Label taskProject;
    }
}
