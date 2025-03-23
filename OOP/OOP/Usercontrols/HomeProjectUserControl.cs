using OOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP.Usercontrols
{
    public partial class HomeProjectUserControl : UserControl
    {
        public string MemberName { get; private set; }
        private Project project;
        public HomeProjectUserControl(Project project)
        {
            InitializeComponent(); 
            this.project = project;
            UpdateUI();
            
          
        }
        
        private void UpdateUI()
        {
            projectName.Text = project.projectName;
            projectPic.Image = Properties.Resources.defaultProjectPic;
        }

        private void projectName_Click(object sender, EventArgs e)
        {

        }

        private void projectPic_Click(object sender, EventArgs e)
        {

        }
    }
}

