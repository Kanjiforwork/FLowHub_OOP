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
    // Attach MouseMove & MouseLeave only to the **Panel itself** but still track child elements
    protected void ApplyMouseEvents(Panel panel)
    {
        panel.MouseMove += (s, e) => Panel_MouseMove(panel);
        panel.MouseLeave += (s, e) => Panel_MouseLeave(panel);

        foreach (Control child in panel.Controls)
        {
            child.MouseMove += (s, e) => Panel_MouseMove(panel); // Redirect child hover event to panel
            child.MouseLeave += (s, e) => Panel_MouseLeave(panel); // Redirect child leave event to panel
        }
    }

    // Change border style when hovering over the panel (but not its children directly)
    private void Panel_MouseMove(Panel panel)
    {
        panel.BorderStyle = BorderStyle.Fixed3D;
    }

    // Reset border when leaving the **entire** panel
    private void Panel_MouseLeave(Panel panel)
    {
        // Check if the mouse is still inside the panel
        if (!panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
        {
            panel.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
