using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using OOP.Services;

namespace OOP.Usercontrols
{
    public partial class MilestoneUserControl : UserControl
    {
        private Milestone milestone;  // Tham chiếu đến Milestone gốc
        public event EventHandler<Milestone> OnTaskFinished;

        public Panel TaskPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel9; } // panelContainer là tên Panel bên trong TaskControl
        }

        public MilestoneUserControl(Milestone milestone)
        {
            InitializeComponent();
            this.milestone = milestone;
            UpdateUI();
        }

        private void UpdateUI()
        {
            taskContent.Text = milestone.taskName;
            taskDeadline.Text = $"{milestone.deadline:dd/MM/yyyy}";
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (milestone.status == "Finished")
            {
                checkBox.Image = Properties.Resources.check;
            }
            else
            {
                checkBox.Image = Properties.Resources.checkUnfinished;
            }
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (milestone.status == "Finished")
            {
                milestone.status = "UnFinished"; // Cập nhật trạng thái Milestone gốc
                UpdateButtonState();
                OnTaskFinished?.Invoke(this, milestone);
                TaskManager.GetInstance().UpdateTask(milestone);
            }
            else
            {
                milestone.status = "Finished"; // Cập nhật trạng thái Milestone gốc
                UpdateButtonState();
                OnTaskFinished?.Invoke(this, milestone);
                TaskManager.GetInstance().UpdateTask(milestone);
            }
        }
    }
}
