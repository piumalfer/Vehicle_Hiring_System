namespace MyAssignment
{
    partial class Calculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Extrahrs = new System.Windows.Forms.Label();
            this.travelledhrs = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Maxhrs = new System.Windows.Forms.Label();
            this.vtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAssignmentDataSet = new MyAssignment.MyAssignmentDataSet();
            this.Travelled_Charge = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.txttravelledkm = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtend_km = new System.Windows.Forms.TextBox();
            this.txtstart_km = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vtypeTableAdapter = new MyAssignment.MyAssignmentDataSetTableAdapters.VtypeTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pakagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pakagesTableAdapter = new MyAssignment.MyAssignmentDataSetTableAdapters.PakagesTableAdapter();
            this.StandardRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MaximumKm = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ExtraKm = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TotalKm = new System.Windows.Forms.Label();
            this.waitingcharge = new System.Windows.Forms.Label();
            this.OverNigthcharge = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ParkCharge = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Travelled_Charge1 = new System.Windows.Forms.Label();
            this.ExtratravelledCharge = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ExtraKmCharge = new System.Windows.Forms.Label();
            this.waitingchrg = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakagesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Extrahrs
            // 
            this.Extrahrs.AutoSize = true;
            this.Extrahrs.ForeColor = System.Drawing.Color.Red;
            this.Extrahrs.Location = new System.Drawing.Point(403, 202);
            this.Extrahrs.Name = "Extrahrs";
            this.Extrahrs.Size = new System.Drawing.Size(10, 13);
            this.Extrahrs.TabIndex = 192;
            this.Extrahrs.Text = "-";
            // 
            // travelledhrs
            // 
            this.travelledhrs.AutoSize = true;
            this.travelledhrs.ForeColor = System.Drawing.Color.Red;
            this.travelledhrs.Location = new System.Drawing.Point(193, 202);
            this.travelledhrs.Name = "travelledhrs";
            this.travelledhrs.Size = new System.Drawing.Size(10, 13);
            this.travelledhrs.TabIndex = 191;
            this.travelledhrs.Text = "-";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(92, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(359, 23);
            this.button5.TabIndex = 190;
            this.button5.Text = "Get Extra hours";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Maxhrs
            // 
            this.Maxhrs.AutoSize = true;
            this.Maxhrs.ForeColor = System.Drawing.Color.Red;
            this.Maxhrs.Location = new System.Drawing.Point(199, 62);
            this.Maxhrs.Name = "Maxhrs";
            this.Maxhrs.Size = new System.Drawing.Size(10, 13);
            this.Maxhrs.TabIndex = 188;
            this.Maxhrs.Text = "-";
            // 
            // vtypeBindingSource
            // 
            this.vtypeBindingSource.DataMember = "Vtype";
            this.vtypeBindingSource.DataSource = this.myAssignmentDataSet;
            // 
            // myAssignmentDataSet
            // 
            this.myAssignmentDataSet.DataSetName = "MyAssignmentDataSet";
            this.myAssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Travelled_Charge
            // 
            this.Travelled_Charge.AutoSize = true;
            this.Travelled_Charge.ForeColor = System.Drawing.Color.White;
            this.Travelled_Charge.Location = new System.Drawing.Point(11, 474);
            this.Travelled_Charge.Name = "Travelled_Charge";
            this.Travelled_Charge.Size = new System.Drawing.Size(98, 13);
            this.Travelled_Charge.TabIndex = 186;
            this.Travelled_Charge.Text = "T.Travelled Charge";
            this.Travelled_Charge.Click += new System.EventHandler(this.Extratravelled_km_Charge_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(92, 136);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(358, 20);
            this.dateTimePicker2.TabIndex = 185;
            this.dateTimePicker2.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(358, 20);
            this.dateTimePicker1.TabIndex = 184;
            this.dateTimePicker1.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(358, 29);
            this.button4.TabIndex = 183;
            this.button4.Text = "Calculate ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txttravelledkm
            // 
            this.txttravelledkm.AutoSize = true;
            this.txttravelledkm.ForeColor = System.Drawing.Color.White;
            this.txttravelledkm.Location = new System.Drawing.Point(174, 474);
            this.txttravelledkm.Name = "txttravelledkm";
            this.txttravelledkm.Size = new System.Drawing.Size(121, 13);
            this.txttravelledkm.TabIndex = 182;
            this.txttravelledkm.Text = "T.Extra travelled Charge";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(92, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 181;
            this.label12.Text = "waiting charge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 179;
            this.label10.Text = "end_km";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 178;
            this.label9.Text = "start_km";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 177;
            this.label8.Text = "end_time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 176;
            this.label7.Text = "start_time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 175;
            this.label6.Text = "package_type";
            // 
            // txtend_km
            // 
            this.txtend_km.Location = new System.Drawing.Point(92, 265);
            this.txtend_km.Multiline = true;
            this.txtend_km.Name = "txtend_km";
            this.txtend_km.Size = new System.Drawing.Size(359, 29);
            this.txtend_km.TabIndex = 172;
            this.txtend_km.TextChanged += new System.EventHandler(this.txtend_km_TextChanged);
            // 
            // txtstart_km
            // 
            this.txtstart_km.Location = new System.Drawing.Point(92, 230);
            this.txtstart_km.Multiline = true;
            this.txtstart_km.Name = "txtstart_km";
            this.txtstart_km.Size = new System.Drawing.Size(359, 29);
            this.txtstart_km.TabIndex = 171;
            this.txtstart_km.TextChanged += new System.EventHandler(this.txtstart_km_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 170;
            // 
            // vtypeTableAdapter
            // 
            this.vtypeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.pakagesBindingSource;
            this.comboBox2.DisplayMember = "PakageName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(359, 21);
            this.comboBox2.TabIndex = 193;
            this.comboBox2.ValueMember = "PakageID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pakagesBindingSource
            // 
            this.pakagesBindingSource.DataMember = "Pakages";
            this.pakagesBindingSource.DataSource = this.myAssignmentDataSet;
            // 
            // pakagesTableAdapter
            // 
            this.pakagesTableAdapter.ClearBeforeFill = true;
            // 
            // StandardRate
            // 
            this.StandardRate.AutoSize = true;
            this.StandardRate.ForeColor = System.Drawing.Color.Red;
            this.StandardRate.Location = new System.Drawing.Point(431, 62);
            this.StandardRate.Name = "StandardRate";
            this.StandardRate.Size = new System.Drawing.Size(10, 13);
            this.StandardRate.TabIndex = 194;
            this.StandardRate.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 195;
            this.label1.Text = "Maximum hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(332, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 196;
            this.label3.Text = "Standard Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 197;
            this.label4.Text = "Total  hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(304, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 198;
            this.label5.Text = "Extra hours";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(89, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 200;
            this.label13.Text = "Maximum Km";
            // 
            // MaximumKm
            // 
            this.MaximumKm.AutoSize = true;
            this.MaximumKm.ForeColor = System.Drawing.Color.Red;
            this.MaximumKm.Location = new System.Drawing.Point(188, 346);
            this.MaximumKm.Name = "MaximumKm";
            this.MaximumKm.Size = new System.Drawing.Size(10, 13);
            this.MaximumKm.TabIndex = 199;
            this.MaximumKm.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(278, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 202;
            this.label15.Text = "Extra Km";
            // 
            // ExtraKm
            // 
            this.ExtraKm.AutoSize = true;
            this.ExtraKm.ForeColor = System.Drawing.Color.Red;
            this.ExtraKm.Location = new System.Drawing.Point(403, 346);
            this.ExtraKm.Name = "ExtraKm";
            this.ExtraKm.Size = new System.Drawing.Size(10, 13);
            this.ExtraKm.TabIndex = 201;
            this.ExtraKm.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(91, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 204;
            this.label14.Text = "Total  Km";
            // 
            // TotalKm
            // 
            this.TotalKm.AutoSize = true;
            this.TotalKm.ForeColor = System.Drawing.Color.Red;
            this.TotalKm.Location = new System.Drawing.Point(193, 305);
            this.TotalKm.Name = "TotalKm";
            this.TotalKm.Size = new System.Drawing.Size(10, 13);
            this.TotalKm.TabIndex = 203;
            this.TotalKm.Text = "-";
            // 
            // waitingcharge
            // 
            this.waitingcharge.AutoSize = true;
            this.waitingcharge.ForeColor = System.Drawing.Color.Red;
            this.waitingcharge.Location = new System.Drawing.Point(174, 427);
            this.waitingcharge.Name = "waitingcharge";
            this.waitingcharge.Size = new System.Drawing.Size(10, 13);
            this.waitingcharge.TabIndex = 205;
            this.waitingcharge.Text = "-";
            // 
            // OverNigthcharge
            // 
            this.OverNigthcharge.AutoSize = true;
            this.OverNigthcharge.ForeColor = System.Drawing.Color.Red;
            this.OverNigthcharge.Location = new System.Drawing.Point(305, 427);
            this.OverNigthcharge.Name = "OverNigthcharge";
            this.OverNigthcharge.Size = new System.Drawing.Size(10, 13);
            this.OverNigthcharge.TabIndex = 207;
            this.OverNigthcharge.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(208, 427);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 206;
            this.label16.Text = "OverNigth charge";
            // 
            // ParkCharge
            // 
            this.ParkCharge.AutoSize = true;
            this.ParkCharge.ForeColor = System.Drawing.Color.Red;
            this.ParkCharge.Location = new System.Drawing.Point(421, 427);
            this.ParkCharge.Name = "ParkCharge";
            this.ParkCharge.Size = new System.Drawing.Size(10, 13);
            this.ParkCharge.TabIndex = 209;
            this.ParkCharge.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(332, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 208;
            this.label17.Text = "ParkCharge";
            // 
            // Travelled_Charge1
            // 
            this.Travelled_Charge1.AutoSize = true;
            this.Travelled_Charge1.ForeColor = System.Drawing.Color.Red;
            this.Travelled_Charge1.Location = new System.Drawing.Point(112, 474);
            this.Travelled_Charge1.Name = "Travelled_Charge1";
            this.Travelled_Charge1.Size = new System.Drawing.Size(10, 13);
            this.Travelled_Charge1.TabIndex = 210;
            this.Travelled_Charge1.Text = "-";
            // 
            // ExtratravelledCharge
            // 
            this.ExtratravelledCharge.AutoSize = true;
            this.ExtratravelledCharge.ForeColor = System.Drawing.Color.Red;
            this.ExtratravelledCharge.Location = new System.Drawing.Point(291, 474);
            this.ExtratravelledCharge.Name = "ExtratravelledCharge";
            this.ExtratravelledCharge.Size = new System.Drawing.Size(10, 13);
            this.ExtratravelledCharge.TabIndex = 211;
            this.ExtratravelledCharge.Text = "-";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.ForeColor = System.Drawing.Color.White;
            this.TOTAL.Location = new System.Drawing.Point(278, 11);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(14, 20);
            this.TOTAL.TabIndex = 213;
            this.TOTAL.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(177, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 212;
            this.label20.Text = "TOTAL : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.TOTAL);
            this.panel1.Location = new System.Drawing.Point(-3, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 43);
            this.panel1.TabIndex = 214;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(278, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 216;
            this.label11.Text = "Extra Km Charge";
            // 
            // ExtraKmCharge
            // 
            this.ExtraKmCharge.AutoSize = true;
            this.ExtraKmCharge.ForeColor = System.Drawing.Color.Red;
            this.ExtraKmCharge.Location = new System.Drawing.Point(404, 305);
            this.ExtraKmCharge.Name = "ExtraKmCharge";
            this.ExtraKmCharge.Size = new System.Drawing.Size(10, 13);
            this.ExtraKmCharge.TabIndex = 215;
            this.ExtraKmCharge.Text = "-";
            // 
            // waitingchrg
            // 
            this.waitingchrg.AutoSize = true;
            this.waitingchrg.ForeColor = System.Drawing.Color.Red;
            this.waitingchrg.Location = new System.Drawing.Point(431, 474);
            this.waitingchrg.Name = "waitingchrg";
            this.waitingchrg.Size = new System.Drawing.Size(10, 13);
            this.waitingchrg.TabIndex = 218;
            this.waitingchrg.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(330, 474);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 217;
            this.label19.Text = "T.Waiting Charge";
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(483, 553);
            this.Controls.Add(this.waitingchrg);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ExtraKmCharge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExtratravelledCharge);
            this.Controls.Add(this.Travelled_Charge1);
            this.Controls.Add(this.ParkCharge);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.OverNigthcharge);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.waitingcharge);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TotalKm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ExtraKm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MaximumKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StandardRate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Extrahrs);
            this.Controls.Add(this.travelledhrs);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Maxhrs);
            this.Controls.Add(this.Travelled_Charge);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txttravelledkm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtend_km);
            this.Controls.Add(this.txtstart_km);
            this.Controls.Add(this.label2);
            this.Name = "Calculation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation";
            this.Load += new System.EventHandler(this.Calculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakagesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Extrahrs;
        private System.Windows.Forms.Label travelledhrs;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Maxhrs;
        private System.Windows.Forms.Label Travelled_Charge;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txttravelledkm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtend_km;
        private System.Windows.Forms.TextBox txtstart_km;
        public System.Windows.Forms.Label label2;
        private MyAssignmentDataSet myAssignmentDataSet;
        private System.Windows.Forms.BindingSource vtypeBindingSource;
        private MyAssignmentDataSetTableAdapters.VtypeTableAdapter vtypeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource pakagesBindingSource;
        private MyAssignmentDataSetTableAdapters.PakagesTableAdapter pakagesTableAdapter;
        private System.Windows.Forms.Label StandardRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label MaximumKm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label ExtraKm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label TotalKm;
        private System.Windows.Forms.Label waitingcharge;
        private System.Windows.Forms.Label OverNigthcharge;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label ParkCharge;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Travelled_Charge1;
        private System.Windows.Forms.Label ExtratravelledCharge;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ExtraKmCharge;
        private System.Windows.Forms.Label waitingchrg;
        private System.Windows.Forms.Label label19;
    }
}