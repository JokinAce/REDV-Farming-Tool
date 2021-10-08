using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace REDV_Farming_Tool {

    public partial class Form1 : Form {

        public Form1() {
            this.InitializeComponent();
            this.KeySender.RunWorkerAsync();
        }

        private static bool Send = false;

        private void StartBtn_Click(object sender, EventArgs e) {
            Send = !Send;
            this.StartBtn.Text = Send ? "Stop" : "Start";
        }

        private void KeySender_DoWork(object sender, DoWorkEventArgs e) {
            while (true) {
                if (Send) {
                    Simulate.Events().Hold(WindowsInput.Events.KeyCode.E)
                        .Wait(10)
                        .Release(WindowsInput.Events.KeyCode.E)
                        .Invoke();
                }
                Thread.Sleep((int)this.DelayNumericBox.Value);
            }
        }
    }
}