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
    public partial class VType : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        ConnectionString cs = new ConnectionString();
        public VType()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string quciksave = "insert into Vtype(VtypeName) VALUES (@d1)";
                cmd = new SqlCommand(quciksave);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", Vehiclename.Text);
                cmd.ExecuteReader();
                MessageBox.Show("saved", "Type Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetType(); Vehiclename.Clear();
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

        private void VType_Load(object sender, EventArgs e)
        {
            GetType();
        }

        private void Gv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dataview = Gv.SelectedRows[0];
                id.Text = dataview.Cells[0].Value.ToString();
                Vehiclename.Text = dataview.Cells[1].Value.ToString();
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
                string cb = "Update Vtype set VtypeName ='" + Vehiclename.Text + "' Where TypeID='" + id.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                GetType(); Vehiclename.Clear();
                MessageBox.Show("Successfully updated", "Vtype", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                GetType(); Vehiclename.Clear();
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
