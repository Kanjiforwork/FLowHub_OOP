using static ReaLTaiizor.Drawing.Poison.PoisonPaint;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP
{
    partial class NotiUserControl
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
            Avatar = new PictureBox();
            SenderName = new Label();
            SendDate = new Label();
            Content = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Avatar
            // 
            Avatar.BackColor = Color.Transparent;
            Avatar.BackgroundImageLayout = ImageLayout.None;
            Avatar.ErrorImage = null;
            Avatar.InitialImage = null;
            Avatar.Location = new Point(33, 30);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(39, 39);
            Avatar.SizeMode = PictureBoxSizeMode.Zoom;
            Avatar.TabIndex = 0;
            Avatar.TabStop = false;
            Avatar.Click += Avatar_Click;
            // 
            // SenderName
            // 
            SenderName.AutoSize = true;
            SenderName.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SenderName.Location = new Point(104, 37);
            SenderName.Name = "SenderName";
            SenderName.Size = new Size(51, 19);
            SenderName.TabIndex = 2;
            SenderName.Text = "label1";
            // 
            // SendDate
            // 
            SendDate.AutoSize = true;
            SendDate.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendDate.Location = new Point(203, 37);
            SendDate.Name = "SendDate";
            SendDate.Size = new Size(51, 19);
            SendDate.TabIndex = 3;
            SendDate.Text = "label2";
            // 
            // Content
            // 
            Content.AutoSize = true;
            Content.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Content.ForeColor = SystemColors.Desktop;
            Content.Location = new Point(14, 20);
            Content.Name = "Content";
            Content.Size = new Size(60, 22);
            Content.TabIndex = 4;
            Content.Text = "label1";
            Content.Click += Content_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Content);
            panel1.Location = new Point(81, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 126);
            panel1.TabIndex = 5;
            // 
            // NotiUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(panel1);
            Controls.Add(SendDate);
            Controls.Add(SenderName);
            Controls.Add(Avatar);
            ForeColor = SystemColors.ControlText;
            Name = "NotiUserControl";
            Size = new Size(559, 264);
            Load += NotiUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Avatar;
        private Label SenderName;
        private Label SendDate;
        private Label Content;
        private Panel panel1;
    }
}