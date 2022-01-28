using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Massage_Fuchs.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
                
        private void UC_Home_Load(object sender, EventArgs e)
        {
            timerTime.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }


    }
}
