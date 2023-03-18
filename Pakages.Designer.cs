namespace MyAssignment
{
    partial class Pakages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.wcharge = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.srate = new System.Windows.Forms.TextBox();
            this.Mkm = new System.Windows.Forms.TextBox();
            this.Mhl = new System.Windows.Forms.TextBox();
            this.wrate = new System.Windows.Forms.TextBox();
            this.NigthR = new System.Windows.Forms.TextBox();
            this.PakingRate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleNo = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAssignmentDataSet = new MyAssignment.MyAssignmentDataSet();
            this.PakageName = new System.Windows.Forms.TextBox();
            this.vehicleTableAdapter = new MyAssignment.MyAssignmentDataSetTableAdapters.VehicleTableAdapter();
            this.Gv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.TextBox();
            this.OverLimitRate = new System.Windows.Forms.Label();
            this.olr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(506, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 13);
            this.label22.TabIndex = 172;
            this.label22.Text = "vehicle night park rate";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(357, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 13);
            this.label21.TabIndex = 173;
            this.label21.Text = "Driver overnight rate";
            // 
            // wcharge
            // 
            this.wcharge.AutoSize = true;
            this.wcharge.ForeColor = System.Drawing.Color.White;
            this.wcharge.Location = new System.Drawing.Point(180, 72);
            this.wcharge.Name = "wcharge";
            this.wcharge.Size = new System.Drawing.Size(146, 13);
            this.wcharge.TabIndex = 174;
            this.wcharge.Text = "waiting charge for extra hours";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(9, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 175;
            this.label19.Text = "max hour limit";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(631, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 176;
            this.label18.Text = "Maximum km ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(432, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 177;
            this.label17.Text = "Standard rate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(9, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 178;
            this.label16.Text = "Pakage Name";
            // 
            // srate
            // 
            this.srate.Location = new System.Drawing.Point(435, 30);
            this.srate.Multiline = true;
            this.srate.Name = "srate";
            this.srate.Size = new System.Drawing.Size(194, 29);
            this.srate.TabIndex = 181;
            this.srate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Mkm
            // 
            this.Mkm.Location = new System.Drawing.Point(635, 30);
            this.Mkm.Multiline = true;
            this.Mkm.Name = "Mkm";
            this.Mkm.Size = new System.Drawing.Size(299, 29);
            this.Mkm.TabIndex = 182;
            // 
            // Mhl
            // 
            this.Mhl.Location = new System.Drawing.Point(12, 88);
            this.Mhl.Multiline = true;
            this.Mhl.Name = "Mhl";
            this.Mhl.Size = new System.Drawing.Size(156, 29);
            this.Mhl.TabIndex = 183;
            // 
            // wrate
            // 
            this.wrate.Location = new System.Drawing.Point(183, 88);
            this.wrate.Multiline = true;
            this.wrate.Name = "wrate";
            this.wrate.Size = new System.Drawing.Size(165, 29);
            this.wrate.TabIndex = 184;
            // 
            // NigthR
            // 
            this.NigthR.Location = new System.Drawing.Point(360, 88);
            this.NigthR.Multiline = true;
            this.NigthR.Name = "NigthR";
            this.NigthR.Size = new System.Drawing.Size(143, 29);
            this.NigthR.TabIndex = 185;
            // 
            // PakingRate
            // 
            this.PakingRate.Location = new System.Drawing.Point(509, 88);
            this.PakingRate.Multiline = true;
            this.PakingRate.Name = "PakingRate";
            this.PakingRate.Size = new System.Drawing.Size(131, 29);
            this.PakingRate.TabIndex = 186;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(743, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 29);
            this.button4.TabIndex = 188;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 188;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 29);
            this.button2.TabIndex = 188;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 189;
            this.label1.Text = "Vehicle No";
            // 
            // VehicleNo
            // 
            this.VehicleNo.DataSource = this.vehicleBindingSource;
            this.VehicleNo.DisplayMember = "VNumber";
            this.VehicleNo.FormattingEnabled = true;
            this.VehicleNo.Location = new System.Drawing.Point(228, 30);
            this.VehicleNo.Name = "VehicleNo";
            this.VehicleNo.Size = new System.Drawing.Size(194, 21);
            this.VehicleNo.TabIndex = 190;
            this.VehicleNo.ValueMember = "VtypeID";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.myAssignmentDataSet;
            // 
            // myAssignmentDataSet
            // 
            this.myAssignmentDataSet.DataSetName = "MyAssignmentDataSet";
            this.myAssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PakageName
            // 
            this.PakageName.Location = new System.Drawing.Point(12, 30);
            this.PakageName.Multiline = true;
            this.PakageName.Name = "PakageName";
            this.PakageName.Size = new System.Drawing.Size(194, 29);
            this.PakageName.TabIndex = 191;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // Gv
            // 
            this.Gv.AllowUserToDeleteRows = false;
            this.Gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.Gv.GridColor = System.Drawing.Color.Teal;
            this.Gv.Location = new System.Drawing.Point(12, 158);
            this.Gv.MultiSelect = false;
            this.Gv.Name = "Gv";
            this.Gv.ReadOnly = true;
            this.Gv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Gv.Size = new System.Drawing.Size(922, 260);
            this.Gv.TabIndex = 199;
            this.Gv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Gv_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 149.2386F;
            this.Column2.HeaderText = "PakageName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vehicle No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "StandardRate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MaximumKm";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MaximumHour";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "WaitCharge";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "OverRightRate";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ParkRate";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "OverLimitRate";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(970, 39);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(54, 29);
            this.id.TabIndex = 200;
            // 
            // OverLimitRate
            // 
            this.OverLimitRate.AutoSize = true;
            this.OverLimitRate.ForeColor = System.Drawing.Color.White;
            this.OverLimitRate.Location = new System.Drawing.Point(646, 72);
            this.OverLimitRate.Name = "OverLimitRate";
            this.OverLimitRate.Size = new System.Drawing.Size(80, 13);
            this.OverLimitRate.TabIndex = 201;
            this.OverLimitRate.Text = "Over Limit Rate";
            // 
            // olr
            // 
            this.olr.Location = new System.Drawing.Point(646, 88);
            this.olr.Multiline = true;
            this.olr.Name = "olr";
            this.olr.Size = new System.Drawing.Size(288, 29);
            this.olr.TabIndex = 202;
            // 
            // Pakages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(952, 430);
            this.Controls.Add(this.olr);
            this.Controls.Add(this.OverLimitRate);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Gv);
            this.Controls.Add(this.PakageName);
            this.Controls.Add(this.VehicleNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PakingRate);
            this.Controls.Add(this.NigthR);
            this.Controls.Add(this.wrate);
            this.Controls.Add(this.Mhl);
            this.Controls.Add(this.Mkm);
            this.Controls.Add(this.srate);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.wcharge);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Name = "Pakages";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pakages";
            this.Load += new System.EventHandler(this.Pakages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label wcharge;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox srate;
        private System.Windows.Forms.TextBox Mkm;
        private System.Windows.Forms.TextBox Mhl;
        private System.Windows.Forms.TextBox wrate;
        private System.Windows.Forms.TextBox NigthR;
        private System.Windows.Forms.TextBox PakingRate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VehicleNo;
        private System.Windows.Forms.TextBox PakageName;
        private MyAssignmentDataSet myAssignmentDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private MyAssignmentDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        public System.Windows.Forms.DataGridView Gv;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label OverLimitRate;
        private System.Windows.Forms.TextBox olr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}