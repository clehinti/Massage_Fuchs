using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Massage_Fuchs.Forms;
using MySql.Data.MySqlClient;

namespace Massage_Fuchs.UserControls
{
    public partial class UC_Workinghoursoverview : UserControl
    {
        public MySqlConnection con = new MySqlConnection("server=eduweb20;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader reader;

        public UC_Workinghoursoverview()
        {
            InitializeComponent();
        }

        void loaddb()
        {
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Working";

            reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            con.Close();
            gridvw.DataSource = dt;
        }
        private void UC_whoverview_Load(object sender, EventArgs e)
        {
            loaddb();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT id, Working, date FROM Working";

            reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            con.Close();
            gridvw.DataSource = dt;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
