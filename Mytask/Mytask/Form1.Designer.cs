namespace Mytask
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmTask = new System.Windows.Forms.ToolStripMenuItem();
            this.ctnApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmMilestone = new System.Windows.Forms.ToolStripMenuItem();
            this.ctnSection = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.pnRecentAssigned = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExpand = new System.Windows.Forms.Button();
            this.txtbRecentlyAssigned = new System.Windows.Forms.TextBox();
            this.tblTask = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDoToday = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExpandDoToday = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tlpDoToday = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTaskContainer = new System.Windows.Forms.Panel();
            this.panelAddTask = new System.Windows.Forms.Panel();
            this.btnMore = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnRecentAssigned.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tblTask.SuspendLayout();
            this.pnDoToday.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tlpDoToday.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTaskContainer.SuspendLayout();
            this.panelAddTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmTask,
            this.ctnApproval,
            this.ctmMilestone,
            this.ctnSection});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 108);
            // 
            // ctmTask
            // 
            this.ctmTask.Image = ((System.Drawing.Image)(resources.GetObject("ctmTask.Image")));
            this.ctmTask.Name = "ctmTask";
            this.ctmTask.Size = new System.Drawing.Size(147, 26);
            this.ctmTask.Text = "Task";
            // 
            // ctnApproval
            // 
            this.ctnApproval.Image = ((System.Drawing.Image)(resources.GetObject("ctnApproval.Image")));
            this.ctnApproval.Name = "ctnApproval";
            this.ctnApproval.Size = new System.Drawing.Size(147, 26);
            this.ctnApproval.Text = "Approval";
            // 
            // ctmMilestone
            // 
            this.ctmMilestone.Image = ((System.Drawing.Image)(resources.GetObject("ctmMilestone.Image")));
            this.ctmMilestone.Name = "ctmMilestone";
            this.ctmMilestone.Size = new System.Drawing.Size(147, 26);
            this.ctmMilestone.Text = "Milestone";
            // 
            // ctnSection
            // 
            this.ctnSection.Image = ((System.Drawing.Image)(resources.GetObject("ctnSection.Image")));
            this.ctnSection.Name = "ctnSection";
            this.ctnSection.Size = new System.Drawing.Size(147, 26);
            this.ctnSection.Text = "Section";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrowdown.png");
            this.imageList1.Images.SetKeyName(1, "myworkspace.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 47);
            this.panel2.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(15, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(133, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "My tasks";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuList,
            this.mnuBoard,
            this.mnuCalendar,
            this.mnuDashboard,
            this.mnuFiles});
            this.menuStrip1.Location = new System.Drawing.Point(0, 47);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuList
            // 
            this.mnuList.BackColor = System.Drawing.SystemColors.Control;
            this.mnuList.Image = ((System.Drawing.Image)(resources.GetObject("mnuList.Image")));
            this.mnuList.Name = "mnuList";
            this.mnuList.Size = new System.Drawing.Size(65, 24);
            this.mnuList.Text = "List";
            // 
            // mnuBoard
            // 
            this.mnuBoard.Image = ((System.Drawing.Image)(resources.GetObject("mnuBoard.Image")));
            this.mnuBoard.Name = "mnuBoard";
            this.mnuBoard.Size = new System.Drawing.Size(83, 24);
            this.mnuBoard.Text = "Board";
            // 
            // mnuCalendar
            // 
            this.mnuCalendar.Image = ((System.Drawing.Image)(resources.GetObject("mnuCalendar.Image")));
            this.mnuCalendar.Name = "mnuCalendar";
            this.mnuCalendar.Size = new System.Drawing.Size(102, 24);
            this.mnuCalendar.Text = "Calendar";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Image = ((System.Drawing.Image)(resources.GetObject("mnuDashboard.Image")));
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(116, 24);
            this.mnuDashboard.Text = "Dashboard";
            // 
            // mnuFiles
            // 
            this.mnuFiles.Image = ((System.Drawing.Image)(resources.GetObject("mnuFiles.Image")));
            this.mnuFiles.Name = "mnuFiles";
            this.mnuFiles.Size = new System.Drawing.Size(72, 24);
            this.mnuFiles.Text = "Files";
            // 
            // pnRecentAssigned
            // 
            this.pnRecentAssigned.AutoSize = true;
            this.pnRecentAssigned.Controls.Add(this.panel4);
            this.pnRecentAssigned.Controls.Add(this.tblTask);
            this.pnRecentAssigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRecentAssigned.Location = new System.Drawing.Point(0, 0);
            this.pnRecentAssigned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnRecentAssigned.Name = "pnRecentAssigned";
            this.pnRecentAssigned.Size = new System.Drawing.Size(1149, 112);
            this.pnRecentAssigned.TabIndex = 10;
            this.pnRecentAssigned.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltask_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExpand);
            this.panel4.Controls.Add(this.txtbRecentlyAssigned);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1149, 43);
            this.panel4.TabIndex = 9;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExpand.ContextMenuStrip = this.contextMenuStrip1;
            this.btnExpand.ImageIndex = 0;
            this.btnExpand.ImageList = this.imageList1;
            this.btnExpand.Location = new System.Drawing.Point(19, 4);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(39, 34);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click_1);
            // 
            // txtbRecentlyAssigned
            // 
            this.txtbRecentlyAssigned.Location = new System.Drawing.Point(65, 10);
            this.txtbRecentlyAssigned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbRecentlyAssigned.Name = "txtbRecentlyAssigned";
            this.txtbRecentlyAssigned.Size = new System.Drawing.Size(136, 22);
            this.txtbRecentlyAssigned.TabIndex = 3;
            this.txtbRecentlyAssigned.Text = "Recently Assigned";
            // 
            // tblTask
            // 
            this.tblTask.AutoSize = true;
            this.tblTask.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tblTask.ColumnCount = 5;
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.69841F));
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.30159F));
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tblTask.Controls.Add(this.label2, 4, 1);
            this.tblTask.Controls.Add(this.checkBox1, 0, 0);
            this.tblTask.Controls.Add(this.checkBox2, 0, 1);
            this.tblTask.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tblTask.Controls.Add(this.dateTimePicker2, 1, 1);
            this.tblTask.Controls.Add(this.textBox1, 2, 0);
            this.tblTask.Controls.Add(this.textBox2, 2, 1);
            this.tblTask.Controls.Add(this.textBox3, 3, 0);
            this.tblTask.Controls.Add(this.textBox4, 3, 1);
            this.tblTask.Controls.Add(this.label1, 4, 0);
            this.tblTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblTask.Location = new System.Drawing.Point(0, 43);
            this.tblTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblTask.Name = "tblTask";
            this.tblTask.RowCount = 2;
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblTask.Size = new System.Drawing.Size(1149, 69);
            this.tblTask.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(916, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "My Workspace";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(7, 7);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(344, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Schedule kickoff meeting";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.Location = new System.Drawing.Point(7, 40);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(344, 22);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Draft project brief";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd dd - MM";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 7);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dddd dd - MM";
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(362, 40);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(574, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(574, 40);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(752, 7);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(752, 40);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(916, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "My Workspace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDoToday
            // 
            this.pnDoToday.AutoSize = true;
            this.pnDoToday.Controls.Add(this.panel5);
            this.pnDoToday.Controls.Add(this.tlpDoToday);
            this.pnDoToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDoToday.Location = new System.Drawing.Point(0, 112);
            this.pnDoToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnDoToday.Name = "pnDoToday";
            this.pnDoToday.Size = new System.Drawing.Size(1149, 117);
            this.pnDoToday.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExpandDoToday);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1149, 43);
            this.panel5.TabIndex = 9;
            // 
            // btnExpandDoToday
            // 
            this.btnExpandDoToday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExpandDoToday.ContextMenuStrip = this.contextMenuStrip1;
            this.btnExpandDoToday.ImageIndex = 0;
            this.btnExpandDoToday.ImageList = this.imageList1;
            this.btnExpandDoToday.Location = new System.Drawing.Point(19, 4);
            this.btnExpandDoToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpandDoToday.Name = "btnExpandDoToday";
            this.btnExpandDoToday.Size = new System.Drawing.Size(39, 34);
            this.btnExpandDoToday.TabIndex = 2;
            this.btnExpandDoToday.UseVisualStyleBackColor = false;
            this.btnExpandDoToday.Click += new System.EventHandler(this.btnExpandDoToday_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 10);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 22);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "Do today";
            // 
            // tlpDoToday
            // 
            this.tlpDoToday.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpDoToday.ColumnCount = 5;
            this.tlpDoToday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.69841F));
            this.tlpDoToday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.30159F));
            this.tlpDoToday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpDoToday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tlpDoToday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tlpDoToday.Controls.Add(this.label3, 4, 1);
            this.tlpDoToday.Controls.Add(this.checkBox3, 0, 0);
            this.tlpDoToday.Controls.Add(this.checkBox4, 0, 1);
            this.tlpDoToday.Controls.Add(this.dateTimePicker3, 1, 0);
            this.tlpDoToday.Controls.Add(this.dateTimePicker4, 1, 1);
            this.tlpDoToday.Controls.Add(this.textBox6, 2, 0);
            this.tlpDoToday.Controls.Add(this.textBox7, 2, 1);
            this.tlpDoToday.Controls.Add(this.textBox8, 3, 0);
            this.tlpDoToday.Controls.Add(this.textBox9, 3, 1);
            this.tlpDoToday.Controls.Add(this.label4, 4, 0);
            this.tlpDoToday.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpDoToday.Location = new System.Drawing.Point(0, 43);
            this.tlpDoToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpDoToday.Name = "tlpDoToday";
            this.tlpDoToday.RowCount = 2;
            this.tlpDoToday.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDoToday.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDoToday.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDoToday.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDoToday.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDoToday.Size = new System.Drawing.Size(1149, 74);
            this.tlpDoToday.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(916, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "My Workspace";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox3.Location = new System.Drawing.Point(7, 7);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(344, 24);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Schedule kickoff meeting";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox4.Location = new System.Drawing.Point(7, 42);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(344, 25);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "Draft project brief";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dddd dd - MM";
            this.dateTimePicker3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(362, 7);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "dddd dd - MM";
            this.dateTimePicker4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(362, 42);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker4.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(574, 7);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 22);
            this.textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(574, 42);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(167, 22);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(752, 7);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(153, 22);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(752, 42);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 22);
            this.textBox9.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(916, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "My Workspace";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelTaskContainer);
            this.panel1.Controls.Add(this.panelAddTask);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 586);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panelTaskContainer
            // 
            this.panelTaskContainer.AutoSize = true;
            this.panelTaskContainer.Controls.Add(this.pnDoToday);
            this.panelTaskContainer.Controls.Add(this.pnRecentAssigned);
            this.panelTaskContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskContainer.Location = new System.Drawing.Point(0, 123);
            this.panelTaskContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTaskContainer.Name = "panelTaskContainer";
            this.panelTaskContainer.Size = new System.Drawing.Size(1149, 229);
            this.panelTaskContainer.TabIndex = 13;
            // 
            // panelAddTask
            // 
            this.panelAddTask.Controls.Add(this.btnMore);
            this.panelAddTask.Controls.Add(this.button2);
            this.panelAddTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddTask.Location = new System.Drawing.Point(0, 75);
            this.panelAddTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAddTask.Name = "panelAddTask";
            this.panelAddTask.Size = new System.Drawing.Size(1149, 48);
            this.panelAddTask.TabIndex = 12;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMore.ContextMenuStrip = this.contextMenuStrip1;
            this.btnMore.ImageIndex = 0;
            this.btnMore.ImageList = this.imageList1;
            this.btnMore.Location = new System.Drawing.Point(129, 7);
            this.btnMore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(39, 34);
            this.btnMore.TabIndex = 1;
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(19, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add Task +";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1149, 586);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnRecentAssigned.ResumeLayout(false);
            this.pnRecentAssigned.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tblTask.ResumeLayout(false);
            this.tblTask.PerformLayout();
            this.pnDoToday.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tlpDoToday.ResumeLayout(false);
            this.tlpDoToday.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTaskContainer.ResumeLayout(false);
            this.panelTaskContainer.PerformLayout();
            this.panelAddTask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctmTask;
        private System.Windows.Forms.ToolStripMenuItem ctnApproval;
        private System.Windows.Forms.ToolStripMenuItem ctmMilestone;
        private System.Windows.Forms.ToolStripMenuItem ctnSection;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuList;
        private System.Windows.Forms.ToolStripMenuItem mnuBoard;
        private System.Windows.Forms.ToolStripMenuItem mnuCalendar;
        private System.Windows.Forms.ToolStripMenuItem mnuDashboard;
        private System.Windows.Forms.ToolStripMenuItem mnuFiles;
        private System.Windows.Forms.Panel panelAddTask;
        private System.Windows.Forms.Panel pnRecentAssigned;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.TextBox txtbRecentlyAssigned;
        private System.Windows.Forms.TableLayoutPanel tblTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnDoToday;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExpandDoToday;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TableLayoutPanel tlpDoToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTaskContainer;
    }
}

