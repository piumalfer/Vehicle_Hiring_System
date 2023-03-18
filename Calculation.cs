using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyAssignment
{
    public partial class Calculation : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        public Calculation()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myAssignmentDataSet.Pakages' table. You can move, or remove it, as needed.
            this.pakagesTableAdapter.Fill(this.myAssignmentDataSet.Pakages);
            // TODO: This line of code loads data into the 'myAssignmentDataSet.Vtype' table. You can move, or remove it, as needed.
            this.vtypeTableAdapter.Fill(this.myAssignmentDataSet.Vtype);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT maxhourlimit,srate,maximumkm,waitingcharge,overnightrate,parkrate,OverLimitRate from Pakages WHERE PakageName = '" + comboBox2.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Maxhrs.Text = rdr.GetValue(0).ToString().Trim();
                    StandardRate.Text = rdr.GetValue(1).ToString().Trim();
                    MaximumKm.Text = rdr.GetValue(2).ToString().Trim();
                    waitingcharge.Text = rdr.GetValue(3).ToString().Trim();
                    OverNigthcharge.Text = rdr.GetValue(4).ToString().Trim();
                    ParkCharge.Text = rdr.GetValue(5).ToString().Trim();
                    ExtraKmCharge.Text = rdr.GetValue(6).ToString().Trim();

                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value;
            DateTime b = dateTimePicker2.Value;
            TimeSpan duration = b - a;
            travelledhrs.Text = duration.TotalHours.ToString();

            // get extra hrs  
            int val1 = Int32.Parse(Maxhrs.Text);
            int val2 = Int32.Parse(travelledhrs.Text);
            int result = val2 - val1; 
            Extrahrs.Text = result.ToString(); 



        }

        private void txtstart_km_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txtend_km_TextChanged(object sender, EventArgs e)
        {
           //  get Total km  
            int val1 = Int32.Parse(txtend_km.Text);
            int val2 = Int32.Parse(txtstart_km.Text);
            int result = val1 - val2;
            TotalKm.Text = result.ToString();

            // get extra km  
            int val3 = Int32.Parse(MaximumKm.Text);
            int val4 = Int32.Parse(TotalKm.Text);
            int result2 = val4 - val3;
            ExtraKm.Text = result2.ToString();


        }

        private void Extratravelled_km_Charge_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // get Travelled km  
            int val5 = Int32.Parse(Maxhrs.Text);
            int val6 = Int32.Parse(StandardRate.Text);
            int result3 = val5 * val6;
            Travelled_Charge1.Text = result3.ToString();


            // get Extra Travelled km  
            int val7 = Int32.Parse(ExtraKmCharge.Text);
            int val8 = Int32.Parse(ExtraKm.Text);
            int result4 = val7 * val8;
            ExtratravelledCharge.Text = result4.ToString();

            // get waiting charge Rate
            int val9 = Int32.Parse(Travelled_Charge1.Text);
            int val10 = Int32.Parse(ExtratravelledCharge.Text);
            int result5 = val7 * val8;
            waitingchrg.Text = result5.ToString();
 

           // checked for days [if 2 or more days add night charge , parking charge]
           int travelledhrs = 0;  
           if ( travelledhrs > 48 )
           {
               // get Final Rate
               int val11 = Int32.Parse(Travelled_Charge1.Text);
               int val12 = Int32.Parse(ExtratravelledCharge.Text);
               int val13 = Int32.Parse(waitingchrg.Text);
               int val14 = Int32.Parse(OverNigthcharge.Text);
               int val15 = Int32.Parse(ParkCharge.Text);
               int result6 = val11 + val12 + val13 + val14 + val15;
               TOTAL.Text = result6.ToString();
           }
           else
           {
               // get Final Rate
               int val11 = Int32.Parse(Travelled_Charge1.Text);
               int val12 = Int32.Parse(ExtratravelledCharge.Text);
               int val13 = Int32.Parse(waitingchrg.Text);
               int result6 = val11 + val12 + val13;
               TOTAL.Text = result6.ToString();
           }



        }
    }
}
