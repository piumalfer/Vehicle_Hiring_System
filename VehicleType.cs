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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string quciksave = "insert into Vtype(VtypeName) VALUES (@d1)";
                cmd = new SqlCommand(quciksave);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", VtypeName.Text);
                cmd.ExecuteReader();
                MessageBox.Show("saved", "VType", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetType(); VtypeName.Clear();
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


        private void VehicleType_Load(object sender, EventArgs e)
        {
            GetType();
        }


        public void GetType()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(TypeID),RTRIM(VtypeName) from Vtype ", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Gv.Rows.Clear();
                while (rdr.Read() == true)
                {
                    Gv.Rows.Add(rdr[0], rdr[1]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dfe4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dataview = Gv.SelectedRows[0];
                id.Text = dataview.Cells[0].Value.ToString();
                VtypeName.Text = dataview.Cells[1].Value.ToString();
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
                string cb = "Update Vtype set VtypeName ='" + VtypeName.Text + "' Where TypeID='" + id.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                GetType(); VtypeName.Clear();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
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
                string cq = "delete from Vtype where TypeID=" + id.Text + "";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                GetType(); VtypeName.Clear();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Vtype", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
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


    }
}
