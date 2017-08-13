namespace Assignment05_300924228
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
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashFormPicture = new System.Windows.Forms.PictureBox();
            this.SplashFormNameLabel = new System.Windows.Forms.Label();
            this.LabelSlogan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashFormPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // SplashFormPicture
            // 
            this.SplashFormPicture.BackgroundImage = global::Assignment05_300924228.Properties.Resources.background;
            this.SplashFormPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplashFormPicture.Image = global::Assignment05_300924228.Properties.Resources.background;
            this.SplashFormPicture.Location = new System.Drawing.Point(4, 64);
            this.SplashFormPicture.Name = "SplashFormPicture";
            this.SplashFormPicture.Size = new System.Drawing.Size(296, 368);
            this.SplashFormPicture.TabIndex = 0;
            this.SplashFormPicture.TabStop = false;
            // 
            // SplashFormNameLabel
            // 
            this.SplashFormNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SplashFormNameLabel.AutoSize = true;
            this.SplashFormNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashFormNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.SplashFormNameLabel.Location = new System.Drawing.Point(6, 13);
            this.SplashFormNameLabel.Name = "SplashFormNameLabel";
            this.SplashFormNameLabel.Size = new System.Drawing.Size(294, 48);
            this.SplashFormNameLabel.TabIndex = 1;
            this.SplashFormNameLabel.Text = "Greetings! \r\nWelcome to my BMI Calculator";
            this.SplashFormNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelSlogan
            // 
            this.LabelSlogan.AutoSize = true;
            this.LabelSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSlogan.ForeColor = System.Drawing.Color.Maroon;
            this.LabelSlogan.Location = new System.Drawing.Point(24, 435);
            this.LabelSlogan.Name = "LabelSlogan";
            this.LabelSlogan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelSlogan.Size = new System.Drawing.Size(246, 27);
            this.LabelSlogan.TabIndex = 2;
            this.LabelSlogan.Text = "Your Health is Your Wealth";
            this.LabelSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSlogan.UseCompatibleTextRendering = true;
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 491);
            this.Controls.Add(this.LabelSlogan);
            this.Controls.Add(this.SplashFormNameLabel);
            this.Controls.Add(this.SplashFormPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.SplashFormPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashFormTimer;
        private System.Windows.Forms.PictureBox SplashFormPicture;
        private System.Windows.Forms.Label SplashFormNameLabel;
        private System.Windows.Forms.Label LabelSlogan;
    }
}