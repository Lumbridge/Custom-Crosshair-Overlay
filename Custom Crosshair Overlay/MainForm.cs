using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace Custom_Crosshair_Overlay
{
    public partial class MainForm : Form
    {
        Form1 f1 = new Form1();

        Process[] processList = Process.GetProcesses();
        List<Process> processesWithWindow = new List<Process>();

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        // Hotkey controls
        const int MOD_CONTROL = 0x0002;
        const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;

        bool overlayEnabled;
        IntPtr windowToOverlay;
        Process processToOverlay;

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        protected override void WndProc(ref Message m)
        {
            // Hotkey Detection Method
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
            {
                // CTRL+SHIFT+K Hotkey Pressed
                if (!this.ContainsFocus)
                {
                    this.Activate();
                }
                else
                {
                    
                }
            }
            else if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
            {
                int openForms = Application.OpenForms.Count;

                // CTRL+SHIFT+X Hotkey Pressed (Show/Hide Config Window)
                if (overlayEnabled == true)
                {
                    Application.OpenForms[0].Opacity = 0;
                    overlayEnabled = false;
                }
                else
                {
                    Application.OpenForms[0].Opacity = 100;
                    overlayEnabled = true;
                }
            }
            base.WndProc(ref m);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                UnregisterHotKey(this.Handle, 1);
                UnregisterHotKey(this.Handle, 2);

                Application.Exit();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public MainForm(Form1 frm)
        {
            InitializeComponent();

            f1 = frm;

            RegisterHotKey(this.Handle, 1, MOD_CONTROL + MOD_SHIFT, (int)Keys.X);
            RegisterHotKey(this.Handle, 2, MOD_CONTROL + MOD_SHIFT, (int)Keys.K);
        }

        private void processesWithWindowComboBox_DropDown(object sender, EventArgs e)
        {
            processesWithWindowComboBox.Items.Clear();
            processesWithWindow.Clear();
            processList = Process.GetProcesses();

            foreach (Process theProcess in processList)
            {
                try
                {
                    if (!theProcess.HasExited && theProcess.MainWindowHandle != IntPtr.Zero)
                    {
                        processesWithWindow.Add(theProcess);
                    }
                }
                catch
                {
                    // Ignore any exceptions for denied access to permissions
                }
            }
            
            foreach (Process windowedProcess in processesWithWindow)
            {
                Console.WriteLine("Process Name: {0} Process ID: {1}", windowedProcess.ProcessName, windowedProcess.Id);
                processesWithWindowComboBox.Items.Add(windowedProcess.ToString());
            }
        }

        private void addCrosshairByURLButton_Click(object sender, EventArgs e)
        {
            browseFileButton.Enabled = false;

            addCrosshairByURLButton.Enabled = false;
            useLocalImageButton.Enabled = true;

            crosshairURLTextBox.Enabled = true;
            crosshairFileLocationTextBox.Enabled = false;
        }

        private void useLocalImageButton_Click(object sender, EventArgs e)
        {
            browseFileButton.Enabled = true;

            useLocalImageButton.Enabled = false;
            addCrosshairByURLButton.Enabled = true;

            crosshairFileLocationTextBox.Enabled = true;
            crosshairURLTextBox.Enabled = false;
        }

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        Rectangle window = new Rectangle();

        private async void drawCrosshair()
        {
            while (!processToOverlay.HasExited)
            {
                GetWindowRect(windowToOverlay, out window);
                f1.Location = new Point(
                    ((window.Right/2) - (f1.crossHairPictureBox.Size.Width/2) + Decimal.ToInt32(adjustXspinner.Value))
                    , ((window.Bottom/2) - (f1.crossHairPictureBox.Size.Height/2) + Decimal.ToInt32(adjustYspinner.Value))
                    );

                if (GetForegroundWindow() != windowToOverlay && !this.ContainsFocus)
                {
                    f1.crossHairPictureBox.Visible = false;
                }
                else
                {
                    f1.crossHairPictureBox.Visible = true;
                }
                await Task.Delay(1);
            }
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            if (crosshairFileLocationTextBox.Enabled == false && crosshairURLTextBox.Text.Length > 0)
            {
                f1.crossHairPictureBox.Load(crosshairURLTextBox.Text);
                drawCrosshair();
            }
            else if (crosshairURLTextBox.Enabled == false && crosshairFileLocationTextBox.Text.Length > 0)
            {
                f1.crossHairPictureBox.Image = Image.FromFile(crosshairFileLocationTextBox.Text);
                drawCrosshair();
            }
            else
            {
                MessageBox.Show("Error, missing URL or image file location.");
            }
        }

        private void crosshairSizeSpinner_ValueChanged(object sender, EventArgs e)
        {
            f1.Size = new System.Drawing.Size(Decimal.ToInt32(crosshairSizeSpinner.Value), Decimal.ToInt32(crosshairSizeSpinner.Value));
            f1.crossHairPictureBox.Size = new System.Drawing.Size(Decimal.ToInt32(crosshairSizeSpinner.Value), Decimal.ToInt32(crosshairSizeSpinner.Value));
            f1.Location = new Point((window.Right / 2) - (f1.crossHairPictureBox.Size.Width / 2), (window.Bottom / 2) - (f1.crossHairPictureBox.Size.Height / 2));

            //f1.Location = new Point(Decimal.ToInt32(adjustXspinner.Value), Decimal.ToInt32(adjustYspinner.Value));
        }

        private void adjustXspinner_ValueChanged(object sender, EventArgs e)
        {
            f1.Location = new Point(Decimal.ToInt32(adjustXspinner.Value), Decimal.ToInt32(adjustYspinner.Value));
        }

        private void adjustYspinner_ValueChanged(object sender, EventArgs e)
        {
            f1.Location = new Point(Decimal.ToInt32(adjustXspinner.Value), Decimal.ToInt32(adjustYspinner.Value));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            f1.Location = new Point(960-f1.Size.Width, 540-f1.Size.Height);
        }

        private void processesWithWindowComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                processToOverlay = processesWithWindow[processesWithWindowComboBox.SelectedIndex];
                windowToOverlay = processesWithWindow[processesWithWindowComboBox.SelectedIndex].MainWindowHandle;
                Console.WriteLine("Window to overlay set to {0} and process to {1}", windowToOverlay, processToOverlay);
            }
            catch
            {
                // Catch process created while combo box open
            }
        }

        #region Invoke DLLs
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
        #endregion

        private void browseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();

            if(dr == DialogResult.OK)
            {
                crosshairFileLocationTextBox.Text = ofd.FileName;
            }
        }
    }
}
