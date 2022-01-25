namespace Massage_Fuchs.UserControls
{
    partial class UC_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_time = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_time.Location = new System.Drawing.Point(283, 209);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(339, 77);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "HH:MM:SS";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_time);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timerTime;
    }
}
