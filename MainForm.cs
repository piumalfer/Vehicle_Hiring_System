using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyAssignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculation frm = new Calculation();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VType frm = new VType();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VehicleType frm = new VehicleType();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pakages frm = new Pakages();
            frm.Show();
        }
    }
}
