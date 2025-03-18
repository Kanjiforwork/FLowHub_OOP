using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AvatarForm : Form
    {
        private byte[] _avatarBytes;
        public AvatarForm()
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream(Properties.Resources.DefaultAvatar)) // Sử dụng DefaultAvatarBytes
            {
                pbAvatar.Image = Image.FromStream(ms);
                _avatarBytes = Properties.Resources.DefaultAvatar;
            }
        }

        private void AvatarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _avatarBytes = File.ReadAllBytes(openFileDialog.FileName);
                using (MemoryStream ms = new MemoryStream(_avatarBytes))
                {
                    pbAvatar.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public byte[] GetAvatarBytes()
        {
            return _avatarBytes;
        }
    }
}
