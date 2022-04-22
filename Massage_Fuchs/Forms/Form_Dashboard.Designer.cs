namespace Massage_Fuchs.Forms
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_calender = new System.Windows.Forms.Button();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_workinho = new System.Windows.Forms.Button();
            this.btn_workingh = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btn_calender);
            this.panelLeft.Controls.Add(this.btn_data);
            this.panelLeft.Controls.Add(this.btn_income);
            this.panelLeft.Controls.Add(this.btn_workinho);
            this.panelLeft.Controls.Add(this.btn_workingh);
            this.panelLeft.Controls.Add(this.btn_customers);
            this.panelLeft.Controls.Add(this.btn_home);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 142);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_move);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 140);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_minimize);
            this.panel4.Controls.Add(this.btn_close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 48);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label_time);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(215, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 92);
            this.panel2.TabIndex = 1;
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(876, 34);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(83, 19);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "HH:MM:SS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Massage Fuchs";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(215, 140);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(985, 580);
            this.panelControls.TabIndex = 2;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = global::Massage_Fuchs.Properties.Resources.minimize;
            this.btn_minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_minimize.Location = new System.Drawing.Point(839, 1);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(44, 45);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(941, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(44, 45);
            this.btn_close.TabIndex = 2;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_calender
            // 
            this.btn_calender.FlatAppearance.BorderSize = 0;
            this.btn_calender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calender.ForeColor = System.Drawing.Color.White;
            this.btn_calender.Image = global::Massage_Fuchs.Properties.Resources.add;
            this.btn_calender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calender.Location = new System.Drawing.Point(12, 530);
            this.btn_calender.Name = "btn_calender";
            this.btn_calender.Size = new System.Drawing.Size(203, 60);
            this.btn_calender.TabIndex = 2;
            this.btn_calender.Text = "       Kalender";
            this.btn_calender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_calender.UseVisualStyleBackColor = true;
            this.btn_calender.Click += new System.EventHandler(this.btn_calender_Click);
            // 
            // btn_data
            // 
            this.btn_data.FlatAppearance.BorderSize = 0;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data.ForeColor = System.Drawing.Color.White;
            this.btn_data.Image = global::Massage_Fuchs.Properties.Resources.invite;
            this.btn_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_data.Location = new System.Drawing.Point(12, 466);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(203, 60);
            this.btn_data.TabIndex = 2;
            this.btn_data.Text = "    Kundendaten";
            this.btn_data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btn_income
            // 
            this.btn_income.FlatAppearance.BorderSize = 0;
            this.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_income.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_income.ForeColor = System.Drawing.Color.White;
            this.btn_income.Image = global::Massage_Fuchs.Properties.Resources.payment_method;
            this.btn_income.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_income.Location = new System.Drawing.Point(12, 402);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(203, 60);
            this.btn_income.TabIndex = 2;
            this.btn_income.Text = "       Einkommen";
            this.btn_income.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_income.UseVisualStyleBackColor = true;
            this.btn_income.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btn_workinho
            // 
            this.btn_workinho.FlatAppearance.BorderSize = 0;
            this.btn_workinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_workinho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_workinho.ForeColor = System.Drawing.Color.White;
            this.btn_workinho.Image = global::Massage_Fuchs.Properties.Resources.update;
            this.btn_workinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_workinho.Location = new System.Drawing.Point(12, 336);
            this.btn_workinho.Name = "btn_workinho";
            this.btn_workinho.Size = new System.Drawing.Size(203, 60);
            this.btn_workinho.TabIndex = 2;
            this.btn_workinho.Text = "    Arbeitsstunden übersicht";
            this.btn_workinho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_workinho.UseVisualStyleBackColor = true;
            this.btn_workinho.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_workingh
            // 
            this.btn_workingh.FlatAppearance.BorderSize = 0;
            this.btn_workingh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_workingh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_workingh.ForeColor = System.Drawing.Color.White;
            this.btn_workingh.Image = global::Massage_Fuchs.Properties.Resources.report;
            this.btn_workingh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_workingh.Location = new System.Drawing.Point(12, 271);
            this.btn_workingh.Name = "btn_workingh";
            this.btn_workingh.Size = new System.Drawing.Size(203, 60);
            this.btn_workingh.TabIndex = 2;
            this.btn_workingh.Text = "    Arbeitsstunden";
            this.btn_workingh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_workingh.UseVisualStyleBackColor = true;
            this.btn_workingh.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.Image = global::Massage_Fuchs.Properties.Resources.man;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(12, 205);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(203, 60);
            this.btn_customers.TabIndex = 2;
            this.btn_customers.Text = "         Kunden";
            this.btn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btnSaleBooks_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = global::Massage_Fuchs.Properties.Resources.home256_24783__1_;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(11, 140);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(203, 60);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "           Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btn_move
            // 
            this.btn_move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_move.FlatAppearance.BorderSize = 0;
            this.btn_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_move.ForeColor = System.Drawing.Color.White;
            this.btn_move.Image = ((System.Drawing.Image)(resources.GetObject("btn_move.Image")));
            this.btn_move.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_move.Location = new System.Drawing.Point(173, 8);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(38, 29);
            this.btn_move.TabIndex = 2;
            this.btn_move.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Massage_Fuchs.Properties.Resources.businessman;
            this.pictureBox1.Location = new System.Drawing.Point(51, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_calender;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_workinho;
        private System.Windows.Forms.Button btn_workingh;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelControls;
        public System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button btn_minimize;
    }
}