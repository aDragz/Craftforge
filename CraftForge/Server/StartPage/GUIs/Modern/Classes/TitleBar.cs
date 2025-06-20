using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class TitleBar : Form
{
    // Win32 API imports
    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HTCAPTION = 0x2;

    protected Panel titleBarPanel; // Panel for the custom title bar
    

    private Label titleLabel; // Label for the title text
    private Panel border; // Black line for the bottom of the title bar (Separator)

    private bool _titleCloseButtonEnabled = true;
    private bool _titleMinimizeButtonEnabled = true;
    private bool _titleMaximizeButtonEnabled = true;

    //Window Management
    private Label closeButton;
    private Label minimizeButton;
    private Label maximizeButton;

    public TitleBar()
    {
        InitializeCustomTitleBar();
    }

    private void InitializeCustomTitleBar()
    {
        this.FormBorderStyle = FormBorderStyle.None;

        this.Resize += (s, e) => this.Invalidate(); // Redraw the resize Triangle when resized

        // Create your custom title bar panel

        titleBarPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 75,
            BackColor = Color.FromArgb(30, 30, 46),
            BorderStyle = BorderStyle.None,
            AutoSize = false,
        };

        border = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 1,
            BackColor = Color.Black,
            BorderStyle = BorderStyle.None
        };

        titleLabel = new Label
        {
            ForeColor = Color.FromArgb(240, 240, 240),
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Arial", 26.25f, FontStyle.Bold),
            BorderStyle = BorderStyle.None
        };

        int buttonWidth = 30;
        int buttonHeight = titleBarPanel.Width - 10;

        closeButton = new Label
        {
            Text = "X",
            ForeColor = Color.Red,
            Width = 40,
            TextAlign = ContentAlignment.MiddleCenter,
            Cursor = Cursors.Hand,
            Font = new Font("Segoe UI", 14, FontStyle.Bold)
        };

        minimizeButton = new Label
        {
            Text = "-",
            ForeColor = Color.Gray,
            Width = 40,
            TextAlign = ContentAlignment.MiddleCenter,
            Cursor = Cursors.Hand,
            Font = new Font("Segoe UI", 14, FontStyle.Bold)
        };

        maximizeButton = new Label
        {
            Text = "[]",
            ForeColor = Color.Gray,
            Width = 40,
            TextAlign = ContentAlignment.MiddleCenter,
            Cursor = Cursors.Hand,
            Font = new Font("Segoe UI", 12, FontStyle.Bold)
        };

        if (TitleCloseButtonEnabled)
        {
            closeButton.MouseEnter += (s, e) =>
            {
                closeButton.ForeColor = Color.DarkRed;
                closeButton.BackColor = Color.IndianRed;
            };
            closeButton.MouseLeave += (s, e) =>
            {
                closeButton.ForeColor = Color.Red;
                closeButton.BackColor = Color.Transparent;
            };

            closeButton.Click += (s, e) => this.Close();
        }

        if (TitleMinimizeButtonEnabled)
        {
            minimizeButton.MouseEnter += (s, e) =>
            {
                minimizeButton.ForeColor = Color.DarkGray;
                minimizeButton.BackColor = Color.LightGray;
            };
            minimizeButton.MouseLeave += (s, e) =>
            {
                minimizeButton.ForeColor = Color.Gray;
                minimizeButton.BackColor = Color.Transparent;
            };

            minimizeButton.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
        }

        if (TitleMaximizeButtonEnabled)
        {
            maximizeButton.MouseEnter += (s, e) =>
            {
                maximizeButton.ForeColor = Color.DarkGray;
                maximizeButton.BackColor = Color.LightGray;
            };

            maximizeButton.MouseLeave += (s, e) =>
            {
                maximizeButton.ForeColor = Color.Gray;
                maximizeButton.BackColor = Color.Transparent;
            };

            maximizeButton.Click += (s, e) =>
            {
                this.WindowState = this.WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
            };
        }

        closeButton.Location = new Point(titleBarPanel.Width - buttonWidth - 20, 5);
        maximizeButton.Location = new Point(titleBarPanel.Width - 2 * buttonWidth-40, 5);
        minimizeButton.Location = new Point(titleBarPanel.Width - 3 * buttonWidth-60, 5);

        this.Controls.Add(titleBarPanel);
        titleBarPanel.Controls.Add(border);

        titleBarPanel.Controls.Add(titleLabel);

        titleBarPanel.MouseDown += TitleBarPanel_MouseDown;
        titleLabel.MouseDown += TitleBarPanel_MouseDown;

        titleBarPanel.Controls.Add(minimizeButton);
        titleBarPanel.Controls.Add(maximizeButton);
        titleBarPanel.Controls.Add(closeButton);

        titleBarPanel.Resize += (s, e) =>
        {
            int right = titleBarPanel.Width;
            closeButton.Location = new Point(right - buttonWidth-10, 0);
            maximizeButton.Location = new Point(right - 2 * buttonWidth-20, 0);
            minimizeButton.Location = new Point(right - 3 * buttonWidth-30, 0);

            // Center the title label between left and the first button
            titleLabel.Width = right - 3 * buttonWidth-30;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Height = titleBarPanel.Height;
            closeButton.Height = maximizeButton.Height = minimizeButton.Height = titleBarPanel.Height;
        };
    }

    public string TitleText
    {
        get => titleLabel.Text;
        set => titleLabel.Text = value;
    }

    // Add public properties to control enabled state
    public bool TitleCloseButtonEnabled
    {
        get => _titleCloseButtonEnabled;
        set
        {
            _titleCloseButtonEnabled = value;
            closeButton.Enabled = value;
            closeButton.ForeColor = Color.Red;
        }
    }

    public bool TitleMinimizeButtonEnabled
    {
        get => _titleMinimizeButtonEnabled;
        set
        {
            _titleMinimizeButtonEnabled = value;
            minimizeButton.Enabled = value;
            minimizeButton.ForeColor = Color.Gray;
        }
    }

    public bool TitleMaximizeButtonEnabled
    {
        get => _titleMaximizeButtonEnabled;
        set
        {
            _titleMaximizeButtonEnabled = value;
            maximizeButton.Enabled = value;
            maximizeButton.ForeColor = Color.Gray;
        }
    }

    private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }

    private const int WM_NCHITTEST = 0x84;
    private const int HTBOTTOMRIGHT = 17;

    protected override void WndProc(ref Message m)
    {
        const int resizeHandleSize = 10;

        if (m.Msg == WM_NCHITTEST)
        {
            base.WndProc(ref m);

            if (TitleMaximizeButtonEnabled) //Check if I can maximize the window, then I can allow resizing

            {
                Point pos = PointToClient(new Point(m.LParam.ToInt32()));
                if (pos.X >= this.ClientSize.Width - resizeHandleSize &&
                    pos.Y >= this.ClientSize.Height - resizeHandleSize)
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                    return;
                }
            }

            return;
        }

        base.WndProc(ref m);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (!TitleMaximizeButtonEnabled)
            return;

        const int triangleSize = 12;

        Point bottomRight = new Point(ClientSize.Width, ClientSize.Height);

        using (Pen pen = new Pen(Color.Gray, 1))
        {
            for (int i = 0; i < 3; i++)
            {
                e.Graphics.DrawLine(
                    pen,
                    bottomRight.X - 1 - i * 4, bottomRight.Y,
                    bottomRight.X, bottomRight.Y - 1 - i * 4
                );
            }
        }
    }
}