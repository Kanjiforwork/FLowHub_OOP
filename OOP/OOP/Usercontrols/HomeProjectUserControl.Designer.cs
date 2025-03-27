namespace OOP.Usercontrols
{
    partial class HomeProjectUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeProjectUserControl));
            this.panel12 = new System.Windows.Forms.Panel();
            this.projectPic = new System.Windows.Forms.PictureBox();
            this.projectName = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.projectPic);
            this.panel12.Controls.Add(this.projectName);
            this.panel12.Location = new System.Drawing.Point(3, 15);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(382, 68);
            this.panel12.TabIndex = 7;
            // 
            // projectPic
            // 
            this.projectPic.Image = ((System.Drawing.Image)(resources.GetObject("projectPic.Image")));
            this.projectPic.Location = new System.Drawing.Point(17, 0);
            this.projectPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projectPic.Name = "projectPic";
            this.projectPic.Size = new System.Drawing.Size(56, 62);
            this.projectPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.projectPic.TabIndex = 3;
            this.projectPic.TabStop = false;
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.projectName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.projectName.Location = new System.Drawing.Point(91, 10);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(76, 38);
            this.projectName.TabIndex = 4;
            this.projectName.Text = "OOP";
            // 
            // HomeProjectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel12);
            this.Name = "HomeProjectUserControl";
            this.Size = new System.Drawing.Size(392, 96);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox projectPic;
        private System.Windows.Forms.Label projectName;
    }
}
