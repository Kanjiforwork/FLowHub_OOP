using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mytask
{
    public partial class Addtask : Form
    {
        public Task NewTask { get; set; }
        public Addtask()
        {
            InitializeComponent();
        }

        private void Addtask_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string taskID = txtbInputID.Text;
            string taskName = txtbInputNameTask.Text;
            string status = cbbStatus.Text;
            DateTime deadline = dtpNewTask.Value;
            NewTask = new Task(taskID, taskName,status, deadline);
            DialogResult = DialogResult.OK;
            Close();
            
            
        }
    }
}
