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
    public partial class UC_Workinghours : UserControl
    {
        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
        MySqlCommand cmd = new MySqlCommand();
        string sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader reader;

        int timeSec, timeMin, timeHr;
        bool isActive;
        public UC_Workinghours()
        {
            InitializeComponent();
            ResetTimer();
            isActive = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isActive = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isActive = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeSec++;
                if (timeSec >= 60)
                {
                    timeMin++;
                    timeSec = 0;
                    if (timeMin >= 60)
                    {
                        timeHr++;
                        timeMin = 0;
                        if (timeMin >= 60)
                        {
                            timeHr++;
                            timeMin = 0;
                        }

                    }

                }
            }
            DrowTime();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrowTime()
        {
            txtS.Text = String.Format("{0:00}", timeSec);
            txtmin.Text = String.Format("{0:00}", timeMin);
            txtH.Text = String.Format("{0:00}", timeHr);


        }

        private void UC_ManageExpense_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("yyyy-MM-dd");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        void db()
        {
            try
            {

                string Working = txtH.Text + ":" + txtmin.Text + ":" + txtS.Text;
                con.Open();
                sqlQuery = "insert into Working (Working,date,s,m,h)" +
                "values('" + Working + "', '" + labelTime.Text + "','" + txtS.Text + "','" + txtmin.Text + "','" + txtH.Text + "')";

                cmd = new MySqlCommand(sqlQuery, con);
                reader = cmd.ExecuteReader();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Student System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            db();
            isActive = false;
            ResetTimer();

        }

        private void ResetTimer()
        {
            timer1.Stop();
            timeSec = timeMin = timeHr = 0;
            txtS.Text = "00";
            txtmin.Text = "00";
            txtH.Text = "00";
        }
    }
}
