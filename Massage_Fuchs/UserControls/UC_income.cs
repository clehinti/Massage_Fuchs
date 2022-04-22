﻿using System;
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
    public partial class UC_income : UserControl
    {
        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        string sqlQuery;
        MySqlDataReader reader;
        public UC_income()
        {
            InitializeComponent();
            loaddb();
        }

        void loaddb()
        {
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "Select * FROM made"; //fill datagrid

            reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            con.Close();
            dtgrd.DataSource = dt;
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sqlQuery = "insert into made (made,date, time)" +
                "values('" + txtmade.Text + "', '" + labelTime.Text + "', '" + label_date.Text + "')"; //insert income
                cmd = new MySqlCommand(sqlQuery, con);
                reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Massage Fuchs", MessageBoxButtons.OK, MessageBoxIcon.Information); //error Message
            }
            finally
            {
                con.Close();
            }
            loaddb();
        }
        private void UC_PurchaseDetails_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("yyyy-MM-dd"); //date format
           
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Now.ToString("HH:mm:ss"); //time format
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
