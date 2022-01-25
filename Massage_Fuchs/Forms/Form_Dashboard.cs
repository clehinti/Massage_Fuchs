using Massage_Fuchs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massage_Fuchs.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        UC_Workinghours ea = new UC_Workinghours();

        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 15;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 15;
                if (panelLeft.Width <= 65)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_customers);
            UC_Createcustomer us = new UC_Createcustomer();
            AddControlsToPanel(us);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_workingh);
            AddControlsToPanel(ea);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_workinho);
            UC_Workinghoursoverview up = new UC_Workinghoursoverview();
            AddControlsToPanel(up);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_income);
            UC_income um = new UC_income();
            AddControlsToPanel(um);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_data);
            UC_Customeroverview vs = new UC_Customeroverview();
            AddControlsToPanel(vs);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
