using System;
using System.Windows.Forms;




public class BaseForm : Form
{
    public class ExitHandler
    {
        public bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                                  "Exit Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
    public delegate bool ExitEventHandler();
    public event ExitEventHandler OnExitRequested;

    private ExitHandler exitHandler = new ExitHandler();
    private bool isExiting = false;

    public BaseForm()
    {
        if (OnExitRequested == null)
        {
            OnExitRequested += exitHandler.ConfirmExit;
        }

        // Đảm bảo không đăng ký trùng sự kiện FormClosing
        this.FormClosing -= BaseForm_FormClosing;
        this.FormClosing += BaseForm_FormClosing;
    }

    private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Chỉ form đầu tiên xử lý sự kiện thoát
        if (Application.OpenForms.Count > 1)
            return;

        if (!isExiting && OnExitRequested?.Invoke() == false)
        {
            e.Cancel = true;
        }
        else
        {
            isExiting = true;
        }
    }


    protected void ExitApplication()
    {
        if (!isExiting && OnExitRequested?.Invoke() == true)
        {
            isExiting = true;
            Application.Exit();
        }
    }
}
