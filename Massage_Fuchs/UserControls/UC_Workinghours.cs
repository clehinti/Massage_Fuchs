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
        public MySqlConnection con = new MySqlConnection("server=eduweb20;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
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
            Time();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Time()
        {
            txt_sec.Text = String.Format("{0:00}", timeSec);
            txt_min.Text = String.Format("{0:00}", timeMin);
            txt_hours.Text = String.Format("{0:00}", timeHr);
        }

        private void UC_ManageExpense_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("yyyy-MM-dd");
        }

        void db()
        {
            try
            {
                string Working = txt_hours.Text + ":" + txt_min.Text + ":" + txt_sec.Text;
                con.Open();
                sqlQuery = "insert into Working (Working,date,s,m,h)" +
                "values('" + Working + "', '" + labelTime.Text + "','" + txt_sec.Text + "','" + txt_min.Text + "','" + txt_hours.Text + "')";

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
            txt_sec.Text = "00";
            txt_min.Text = "00";
            txt_hours.Text = "00";
        }
    }
}
