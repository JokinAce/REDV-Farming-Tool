using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using System.Net;

namespace REDV_Farming_Tool {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            KeySender.RunWorkerAsync();

            WebClient security = new() { Proxy = null };
            try {
                string d = security.DownloadString("https://api.alpha-wolf.xyz/photos/i/v5nlilgo.txt");
                if (d != "d") {
                    Application.Exit();
                }
            } catch (Exception) {
                Application.Exit();
            }
        }
        private static bool Send = false;

        private async void StartBtn_Click(object sender, EventArgs e) {
            await Task.Delay(2000).ConfigureAwait(false);
            Send = !Send;
            StartBtn.Text = Send ? "Stop" : "Start";
        }

        private void KeySender_DoWork(object sender, DoWorkEventArgs e) {
            while (true) {
                if (Send) {
                    Simulate.Events().Click("e").Invoke();
                }
                Thread.Sleep((int)DelayNumericBox.Value);
            }
        }

        //private static class NativeMethods {
        //    [DllImport("user32.dll", SetLastError = true)]
        //    public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        //    [return: MarshalAs(UnmanagedType.Bool)]
        //    [DllImport("user32.dll", SetLastError = true)]
        //    public static extern bool PostMessage(IntPtr hWnd, int Msg, Keys wParam, IntPtr lParam);
        //}
    }
}
