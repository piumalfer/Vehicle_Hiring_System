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
    public partial class VehicleType : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        ConnectionString cs = new ConnectionString();
        public VehicleType()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from Vehicle where VehicleID=" + id.Text + "";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                Vehicle();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void VehicleType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myAssignmentDataSet1.Vtype' table. You can move, or remove it, as needed.
            this.vtypeTableAdapter.Fill(this.myAssignmentDataSet1.Vtype);
            Vehicle();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vtypeTableAdapter.FillBy(this.myAssignmentDataSet.Vtype);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string quciksave = "insert into Vehicle(VtypeID,VNumber,vModel) VALUES (@d1,@d2,@d3)";
                cmd = new SqlCommand(quciksave);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", typename.SelectedValue);
                cmd.Parameters.AddWithValue("@d2", VNumber.Text);
                cmd.Parameters.AddWithValue("@d3", vModel.Text);
                cmd.ExecuteReader();
                MessageBox.Show("saved", "Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vehicle(); VNumber.Clear(); vModel.Clear();
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



        public void Vehicle()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(VehicleID),RTRIM(VtypeName),RTRIM(VNumber),RTRIM(vModel) from Vehicle left join Vtype on Vehicle.VtypeID = Vtype.TypeID   ", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Gv.Rows.Clear();
                while (rdr.Read() == true)
                {
                    Gv.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
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
                typename.Text = dataview.Cells[1].Value.ToString();
                VNumber.Text = dataview.Cells[2].Value.ToString();
                vModel.Text = dataview.Cells[3].Value.ToString();
                
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
                String cb = "update Vehicle set VtypeID='" + typename.SelectedValue + "',vModel='" + vModel.Text + "' where VehicleID=" + id.Text + ""; 
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                Vehicle();  
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
