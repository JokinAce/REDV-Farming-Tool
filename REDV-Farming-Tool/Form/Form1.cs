using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace REDV_Farming_Tool {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            KeySender.RunWorkerAsync();
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
                    Simulate.Events().Hold(WindowsInput.Events.KeyCode.W)
                        .Wait((int)DelayNumericBox.Value)
                        .Release(WindowsInput.Events.KeyCode.E)
                        .Invoke();
                }
                Thread.Sleep(500);
            }
        }
    }
}
