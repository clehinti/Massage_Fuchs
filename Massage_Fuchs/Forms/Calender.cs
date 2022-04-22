using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Massage_Fuchs.Forms
{
    public partial class Calender : Form
    {
        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        DataSet DS = new DataSet();
        DataTable dt = new DataTable();

        void loaddb()
        {
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "Select * FROM customer"; 

            reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            con.Close();
            dtgrd.DataSource = dt;
        }


        public Calender()
        {
            InitializeComponent();
            loaddb();
        }

        private void btn_update_Click(object sender, EventArgs e) //update the date
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Update customer set Appointment = @Appointment where email = @email";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Appointment", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            loaddb();
        }

        private void dtgrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmail.Text = dtgrd.CurrentRow.Cells[4].Value.ToString(); //so you can click on the email
        }
    }
}
