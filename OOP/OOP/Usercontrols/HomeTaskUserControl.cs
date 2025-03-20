using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Usercontrols
{
    public partial class HomeTaskUserControl : UserControl
    {
        private Task task;  // Tham chiếu đến Task gốc
        public event EventHandler<Task> OnTaskCompleted;

        public Panel TaskPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel9; } // panelContainer là tên Panel bên trong TaskControl
        }
        public HomeTaskUserControl(Task task)
        {
            InitializeComponent();
            this.task = task;
            UpdateUI();
        }

        private void UpdateUI()
        {
            taskContent.Text = task.taskName;
            taskDeadline.Text = $"{task.dealine:dd/MM}";
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (task.status == "Finished")
            {
                checkBox.Image = Properties.Resources.check;
            }
            else
            {
                checkBox.Image = Properties.Resources.checkUnfinished;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Click_1(object sender, EventArgs e)
        {
            if (task.status == "Finished")
            {
                task.status = "Unfinished"; // Cập nhật trạng thái Task gốc
                UpdateButtonState();
                OnTaskCompleted?.Invoke(this, task);
            }
            else
            {
                task.status = "Finished"; // Cập nhật trạng thái Task gốc
                UpdateButtonState();
                OnTaskCompleted?.Invoke(this, task);
            }

            
        }
    }
}
