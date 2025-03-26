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
using OOP.Models;

namespace OOP
{
    public partial class Addmember: Form
    {
        public TextBox txtUsername;
        private Projects parentForm;

        public void Addmembercs(Projects parent)
        {
            if (parent == null)
            {
                MessageBox.Show("Error: Parent form is null!");
                return;
            }
            this.parentForm = parent;
            InitializeComponent();
        }
        public string MemberName
        {
            get { return txtUsername?.Text.Trim() ?? string.Empty; }
        }

        public RoleType SelectedRole
        {
            get
            {
                if (Enum.TryParse(comboBox1.SelectedItem?.ToString(), out RoleType role))
                {
                    return role;
                }
                return RoleType.Member; // Hoặc giá trị mặc định
            }
        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void panel1_Click(object sender, EventArgs e)
        {

        }




        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //add user nè
        public void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (parentForm == null)
            {
                MessageBox.Show("Error: Parent form is not set.");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string username = txtUsername.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (Enum.TryParse(comboBox1.SelectedItem?.ToString(), out RoleType selectedRole))
            {
                parentForm.AddMember(username, selectedRole);

                // Gán kết quả để lấy dữ liệu từ Projects
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a valid role.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeName_Click(object sender, EventArgs e)
        {

        }
    }
}