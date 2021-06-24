
namespace REDV_Farming_Tool {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DelayLabel = new System.Windows.Forms.Label();
            this.MsLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.KeySender = new System.ComponentModel.BackgroundWorker();
            this.DelayNumericBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelayLabel.Location = new System.Drawing.Point(31, 48);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(60, 25);
            this.DelayLabel.TabIndex = 0;
            this.DelayLabel.Text = "Delay:";
            // 
            // MsLabel
            // 
            this.MsLabel.AutoSize = true;
            this.MsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsLabel.Location = new System.Drawing.Point(291, 53);
            this.MsLabel.Name = "MsLabel";
            this.MsLabel.Size = new System.Drawing.Size(28, 20);
            this.MsLabel.TabIndex = 2;
            this.MsLabel.Text = "ms";
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.AutoSize = true;
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.StartBtn.FlatAppearance.BorderSize = 2;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(159, 140);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 35);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // KeySender
            // 
            this.KeySender.DoWork += new System.ComponentModel.DoWorkEventHandler(this.KeySender_DoWork);
            // 
            // DelayNumericBox
            // 
            this.DelayNumericBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.DelayNumericBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DelayNumericBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelayNumericBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.DelayNumericBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DelayNumericBox.Location = new System.Drawing.Point(159, 51);
            this.DelayNumericBox.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.DelayNumericBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DelayNumericBox.Name = "DelayNumericBox";
            this.DelayNumericBox.Size = new System.Drawing.Size(126, 23);
            this.DelayNumericBox.TabIndex = 4;
            this.DelayNumericBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelayNumericBox.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(381, 215);
            this.Controls.Add(this.DelayNumericBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.MsLabel);
            this.Controls.Add(this.DelayLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RED-V.cc | Farming Tool";
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.Label MsLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.ComponentModel.BackgroundWorker KeySender;
        private System.Windows.Forms.NumericUpDown DelayNumericBox;
    }
}

