using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace OOP
{
    public partial class CommentForm : Form
    {
        private TextBox txtName;
        private TextBox txtComment;
        private Button btnSubmit;
        private ListBox lstComments;
        private List<string> comments;
        private string postId; // Định danh bài viết
        private string filePath = "comments.json"; // File lưu bình luận

        public CommentForm(string postId, List<string> existingComments)
        {
            this.postId = postId;
            this.comments = existingComments ?? new List<string>();

            this.Text = "Bình luận bài viết";
            this.Size = new System.Drawing.Size(350, 350);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Ô nhập tên
            Label lblName = new Label
            {
                Text = "Tên bạn:",
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(lblName);

            txtName = new TextBox
            {
                Size = new System.Drawing.Size(230, 30),
                Location = new System.Drawing.Point(70, 10)
            };
            this.Controls.Add(txtName);

            // Danh sách bình luận
            lstComments = new ListBox
            {
                Size = new System.Drawing.Size(320, 150),
                Location = new System.Drawing.Point(10, 50)
            };
            this.Controls.Add(lstComments);
            LoadComments(); // Load dữ liệu từ JSON

            // Ô nhập bình luận
            txtComment = new TextBox
            {
                Size = new System.Drawing.Size(230, 30),
                Location = new System.Drawing.Point(10, 210)
            };
            this.Controls.Add(txtComment);

            // Nút gửi bình luận
            btnSubmit = new Button
            {
                Text = "Gửi",
                Size = new System.Drawing.Size(70, 30),
                Location = new System.Drawing.Point(250, 210)
            };
            btnSubmit.Click += BtnSubmit_Click;
            this.Controls.Add(btnSubmit);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string comment = txtComment.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(comment))
            {
                MessageBox.Show("Bình luận không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formattedComment = $"{name}: {comment}";
            comments.Add(formattedComment);
            lstComments.Items.Add(formattedComment);
            txtComment.Clear();

            SaveComments(); // Lưu bình luận vào JSON
        }

        private void SaveComments()
        {
            Dictionary<string, List<string>> allComments = new Dictionary<string, List<string>>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                allComments = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
            }

            allComments[postId] = comments;

            string updatedJson = JsonSerializer.Serialize(allComments, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);
        }

        private void LoadComments()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var allComments = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);

                if (allComments.ContainsKey(postId))
                {
                    comments = allComments[postId];
                    lstComments.Items.AddRange(comments.ToArray());
                }
            }
        }
    }
}

