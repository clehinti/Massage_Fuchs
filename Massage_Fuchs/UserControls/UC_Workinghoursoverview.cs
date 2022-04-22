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
        public MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu;uid=c.hinterseer;pwd=MyDatabase053;database=c.hinterseer_clehinti");
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

        private void btnSearch_Click(object sender, EventArgs e) //execution
        {
            between();
            CalcTotalValueAdd();
        }

        public void between()
        {

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Working WHERE date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' "; //limitation of the date

            MySqlDataAdapter DtA = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();          
            DtA.Fill(table);
            gridvw.DataSource = table;

        }

        public void CalcTotalValueAdd() //calculate sum of working hours
        {
            double totals = 0;
            double totalm = 0;
            double totalH = 0;
            double day = 0;

            for (int i = 0; i < gridvw.Rows.Count; i++)
            {

                totals += Convert.ToDouble(gridvw.Rows[i].Cells[3].Value);
                totalm += Convert.ToDouble(gridvw.Rows[i].Cells[4].Value);
                totalH += Convert.ToDouble(gridvw.Rows[i].Cells[5].Value);
                if (totals >= 60)
                {
                    totals = totals - 60;
                    totalm = totalm + 1;
                    if (totalm >= 60)
                    {
                        totalm = totalm - 60;
                        totalH = totalH + 1;

                        if (totalH >= 23)
                        {
                            totalH = totalH - 24;
                            day = day + 1;

                        }

                    }

                }
                txtTotal.Text = day.ToString() + " Tage " + totalH.ToString() + " Std " + totalm.ToString() + " Min " + totals.ToString() + " Sek "; //show sum of working hours


            }

        }



    }
}
