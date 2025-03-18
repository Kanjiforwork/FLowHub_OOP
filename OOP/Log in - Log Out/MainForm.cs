using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private User _user;
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            lblUsername.Text = _user.Username;
            lblEmail.Text = _user.Email;
            if (_user.Avatar != null && _user.Avatar.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_user.Avatar))
                {
                    try
                    {
                        pbUserAvatar.Image = Image.FromStream(ms);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi hiển thị ảnh đại diện: {ex.Message}");
                    }
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void pbUserAvatar_Click(object sender, EventArgs e)
        {
            AvatarForm avatarForm = new AvatarForm();
            if (avatarForm.ShowDialog() == DialogResult.OK)
            {
                _user.Avatar = avatarForm.GetAvatarBytes();

                // Cập nhật ảnh đại diện trên MainForm
                if (_user.Avatar != null && _user.Avatar.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(_user.Avatar))
                    {
                        try
                        {
                            pbUserAvatar.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi hiển thị ảnh đại diện: {ex.Message}");
                        }
                    }
                }

                // Cập nhật thông tin người dùng trong file users.json
                List<User> users = UserService.LoadUsers();
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].ID == _user.ID)
                    {
                        users[i] = _user;
                        break;
                    }
                }
                UserService.SaveUsers(users);
            }
        }
    }
}
