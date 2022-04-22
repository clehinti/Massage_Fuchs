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

namespace Massage_Fuchs.UserControls
{
    public partial class UC_Createcustomer : UserControl
    {
        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
        MySqlCommand cmd = new MySqlCommand();
        string sqlQuery;
        MySqlDataReader reader;
        DataSet DS = new DataSet();


        public UC_Createcustomer()
        {
            InitializeComponent();
            dpCreate.Format = DateTimePickerFormat.Custom;
            dpCreate.CustomFormat = "yyyy-MM-dd"; //custom format for Datetimepicker
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sqlQuery = "insert into customer (name,address, Postleitzahl, email,problems, Appointment, time)" +
                "values('" + txtName.Text + "', '" + txtAdresse.Text + "','" + txtPostleitzahl.Text + "', '" + txtEmail.Text + "', '" +
                txtproblem.Text + "','" + dpCreate.Text + "', '" + dtpTime.Text + "')"; //create customer

                cmd = new MySqlCommand(sqlQuery, con);
                reader = cmd.ExecuteReader();

                con.Close();
                MessageBox.Show("Added successfully"); //message when created succesfully

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Massage Fuchs", MessageBoxButtons.OK, MessageBoxIcon.Information); //error Message
            }
            finally
            {
                con.Close();
            }
            // upLoadData();
            clear();
        }

        void clear() //clear txt boxes
        {
            txtAdresse.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtproblem.Clear();
            txtPostleitzahl.Clear();
            
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
