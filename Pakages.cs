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
    public partial class Pakages : Form
    {   SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        ConnectionString cs = new ConnectionString();
        public Pakages()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pakages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myAssignmentDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.myAssignmentDataSet.Vehicle);
            Pakage();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string quciksave = "insert into Pakages(PakageName,VehicleNo,maximumkm,maxhourlimit,waitingcharge,overnightrate,parkrate,srate,OverLimitRate) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)";
                cmd = new SqlCommand(quciksave);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", PakageName.Text);
                cmd.Parameters.AddWithValue("@d2", VehicleNo.Text);
                cmd.Parameters.AddWithValue("@d3", Mkm.Text);
                cmd.Parameters.AddWithValue("@d4", Mhl.Text);
                cmd.Parameters.AddWithValue("@d5", wrate.Text);
                cmd.Parameters.AddWithValue("@d6", NigthR.Text);
                cmd.Parameters.AddWithValue("@d7", PakingRate.Text);
                cmd.Parameters.AddWithValue("@d8", srate.Text);
                cmd.Parameters.AddWithValue("@d9", olr.Text);
                cmd.ExecuteReader();
                MessageBox.Show("saved", "Pakage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pakage();  
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
              
        }


        public void Pakage()
        {
            try
            {
                
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(PakageID),RTRIM(PakageName),RTRIM(VehicleNo),RTRIM(srate),RTRIM(maximumkm),RTRIM(maxhourlimit),RTRIM(waitingcharge),RTRIM(overnightrate),RTRIM(parkrate),RTRIM(OverLimitRate) from Pakages  ", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Gv.Rows.Clear();
                while (rdr.Read() == true)
                {
                    Gv.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dataview = Gv.SelectedRows[0];
                id.Text = dataview.Cells[0].Value.ToString();
                PakageName.Text = dataview.Cells[1].Value.ToString();
                VehicleNo.Text = dataview.Cells[2].Value.ToString();
                srate.Text = dataview.Cells[3].Value.ToString();
                Mkm.Text = dataview.Cells[4].Value.ToString();
                Mhl.Text = dataview.Cells[5].Value.ToString();
                wrate.Text = dataview.Cells[6].Value.ToString();
                NigthR.Text = dataview.Cells[7].Value.ToString();
                PakingRate.Text = dataview.Cells[8].Value.ToString();
                OverLimitRate.Text = dataview.Cells[9].Value.ToString();


                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from Pakages where PakageID=" + id.Text + "";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                Pakage();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Pakage", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                String cb = "update Pakages set PakageName='" + PakageName.Text + "',VehicleNo='" + VehicleNo.Text + "',srate='" + srate.Text + "',maximumkm='" + Mkm.Text + "',maxhourlimit='" + Mhl.Text + "',waitingcharge='" + wrate.Text + "',overnightrate='" + NigthR.Text + "',parkrate='" + PakingRate.Text + "',OverLimitRate='" + OverLimitRate.Text + "' where PakageID=" + id.Text + ""; 
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                Pakage();
                MessageBox.Show("Successfully updated", "Pakage", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
