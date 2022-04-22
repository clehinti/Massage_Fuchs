using Massage_Fuchs.Forms;
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
namespace Massage_Fuchs
{
    public partial class Form1 : Form
    {

        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select name,password from users WHERE name ='" + txt_user.Text + "' AND password ='" + txt_pw.Text + "'";
                MySqlDataReader sqlRd;
                sqlRd = cmd.ExecuteReader();

                if (sqlRd.Read())
                {
                    Form_Dashboard fd = new Form_Dashboard();
                    this.Hide();
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("Name oder Passwort ist falsch!", "Massage Fuchs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Massage Fuchs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
