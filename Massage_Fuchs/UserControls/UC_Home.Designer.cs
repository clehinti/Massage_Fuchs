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
            this.dtgrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_time.Location = new System.Drawing.Point(329, 10);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(339, 77);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "HH:MM:SS";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // dtgrd
            // 
            this.dtgrd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd.Location = new System.Drawing.Point(42, 301);
            this.dtgrd.Name = "dtgrd";
            this.dtgrd.Size = new System.Drawing.Size(890, 445);
            this.dtgrd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nächster Kunde ";
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrd);
            this.Controls.Add(this.label_time);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.DataGridView dtgrd;
        private System.Windows.Forms.Label label1;
    }
}
