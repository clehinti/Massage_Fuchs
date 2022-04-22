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

    public partial class UC_Customeroverview : UserControl
    {
        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        MySqlDataReader reader;


        public UC_Customeroverview()
        {
            InitializeComponent();
            loaddb();
        }
        void loaddb()
        {
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "Select * FROM customer";

            reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            con.Close();
            gridcst.DataSource = dt;
            
        }
    }
}
