namespace OOP.Usercontrols
{
    partial class HomeTaskUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTaskUserControl));
            this.panel9 = new System.Windows.Forms.Panel();
            this.taskContent = new System.Windows.Forms.Label();
            this.taskDeadline = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.PictureBox();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.taskContent);
            this.panel9.Controls.Add(this.taskDeadline);
            this.panel9.Controls.Add(this.checkBox);
            this.panel9.Location = new System.Drawing.Point(3, 9);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(386, 43);
            this.panel9.TabIndex = 2;
            // 
            // taskContent
            // 
            this.taskContent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskContent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taskContent.Location = new System.Drawing.Point(56, 0);
            this.taskContent.Name = "taskContent";
            this.taskContent.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.taskContent.Size = new System.Drawing.Size(273, 40);
            this.taskContent.TabIndex = 3;
            this.taskContent.Text = "Check bài nhóm";
            this.taskContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskContent.Click += new System.EventHandler(this.label5_Click);
            // 
            // taskDeadline
            // 
            this.taskDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskDeadline.ForeColor = System.Drawing.Color.DarkGray;
            this.taskDeadline.Location = new System.Drawing.Point(310, 0);
            this.taskDeadline.Name = "taskDeadline";
            this.taskDeadline.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.taskDeadline.Size = new System.Drawing.Size(75, 44);
            this.taskDeadline.TabIndex = 2;
            this.taskDeadline.Text = "29/3";
            this.taskDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox
            // 
            this.checkBox.ErrorImage = global::OOP.Properties.Resources.check;
            this.checkBox.Image = ((System.Drawing.Image)(resources.GetObject("checkBox.Image")));
            this.checkBox.InitialImage = null;
            this.checkBox.Location = new System.Drawing.Point(8, 6);
            this.checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(28, 31);
            this.checkBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkBox.TabIndex = 1;
            this.checkBox.TabStop = false;
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click_1);
            // 
            // HomeTaskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel9);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HomeTaskUserControl";
            this.Size = new System.Drawing.Size(391, 56);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label taskDeadline;
        private System.Windows.Forms.PictureBox checkBox;
        private System.Windows.Forms.Label taskContent;
    }
}
