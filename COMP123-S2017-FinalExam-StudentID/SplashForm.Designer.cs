namespace COMP123_S2017_FinalExam_StudentID
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WelcomeTextBox = new System.Windows.Forms.TextBox();
            this.GetReadyTextBox = new System.Windows.Forms.TextBox();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WelcomeTextBox
            // 
            this.WelcomeTextBox.BackColor = System.Drawing.Color.Black;
            this.WelcomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeTextBox.ForeColor = System.Drawing.Color.White;
            this.WelcomeTextBox.Location = new System.Drawing.Point(12, 73);
            this.WelcomeTextBox.Name = "WelcomeTextBox";
            this.WelcomeTextBox.Size = new System.Drawing.Size(576, 38);
            this.WelcomeTextBox.TabIndex = 0;
            this.WelcomeTextBox.Text = "Welcome, to Pick Highest Card!";
            this.WelcomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GetReadyTextBox
            // 
            this.GetReadyTextBox.BackColor = System.Drawing.Color.Black;
            this.GetReadyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GetReadyTextBox.ForeColor = System.Drawing.Color.White;
            this.GetReadyTextBox.Location = new System.Drawing.Point(12, 228);
            this.GetReadyTextBox.Name = "GetReadyTextBox";
            this.GetReadyTextBox.Size = new System.Drawing.Size(576, 38);
            this.GetReadyTextBox.TabIndex = 1;
            this.GetReadyTextBox.Text = "Get Ready to Start!";
            this.GetReadyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.GetReadyTextBox);
            this.Controls.Add(this.WelcomeTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WelcomeTextBox;
        private System.Windows.Forms.TextBox GetReadyTextBox;
        private System.Windows.Forms.Timer SplashFormTimer;
    }
}