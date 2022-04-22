using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Massage_Fuchs.UserControls
{
    public partial class UC_Home : UserControl
    {
        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        MySqlDataReader reader;

        public UC_Home()
        {
            InitializeComponent();
            loaddb();
        }
                
        private void UC_Home_Load(object sender, EventArgs e)
        {
            timerTime.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        void loaddb()
        {
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "Select name,problems, Appointment,time FROM customer ORDER BY Appointment desc"; //fill datagrid

            reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            con.Close();
            dtgrd.DataSource = dt;
        }


    }
}
