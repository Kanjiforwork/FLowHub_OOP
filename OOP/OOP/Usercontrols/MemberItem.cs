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
using OOP;

namespace OOP.Usercontrols
{
    public partial class MemberItem : UserControl
    {
        private List<string> members = new List<string>();
        public string MemberName { get; private set; }
        private System.Windows.Forms.Panel panel2;
        public MemberItem()
        {
            InitializeComponent();
        }
        public MemberItem(string memberName, string role)
        {
            InitializeComponent();
            lblMemberName.Text = $"{memberName}\n({role})";
            //lblMemberName.TextAlign = ContentAlignment.MiddleCenter;
            lblMemberName.AutoSize = false;
            lblMemberName.Height = 40; // Đảm bảo hiển thị đúng
        }

        private void AddMember(string memberName, string role)
        {
            string newMember = $"{memberName} ({role})";

            // Kiểm tra tránh trùng lặp
            if (!members.Contains(newMember))
            {
                members.Add(newMember);

                // Hiển thị thêm vào danh sách mà không xóa cái cũ
                string[] info = newMember.Split('(');
                string name = info[0].Trim();
                string roleText = info.Length > 1 ? info[1].Replace(")", "").Trim() : "Member";

                MemberItem memberItem = new MemberItem(name, roleText);
                memberItem.Margin = new Padding(5);

                panel2.Controls.Add(memberItem);

                UpdateMemberDisplay();
            }
        }
        private void UpdateMemberDisplay()
        {
            //panel2.Controls.Clear(); // Xóa danh sách cũ

            //int xOffset = 0; // Tọa độ X để sắp xếp ngang
            foreach (string member in members)
            {
                string[] info = member.Split('('); // Giả sử dữ liệu là "UserName (Role)"
                string name = info[0].Trim();
                string role = info.Length > 1 ? info[1].Replace(")", "").Trim() : "Member";

                MemberItem memberItem = new MemberItem(name, role);
                memberItem.Margin = new Padding(5);
                //memberItem.Size = new Size(120, 50); // Định kích thước cố định
                //memberItem.Location = new Point(xOffset, 0); // Đặt vị trí ngang
                panel2.Controls.Add(memberItem);


                //  xOffset += memberItem.Width + 10; // Dịch vị trí sang phải
            }
        }


        private void MemberItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

