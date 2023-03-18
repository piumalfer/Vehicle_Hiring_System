namespace MyAssignment
{
    partial class VehicleType
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
            this.VNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.myAssignmentDataSet = new MyAssignment.MyAssignmentDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.vModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Gv = new System.Windows.Forms.DataGridView();
            this.vtypeTableAdapter = new MyAssignment.MyAssignmentDataSetTableAdapters.VtypeTableAdapter();
            this.vtypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typename = new System.Windows.Forms.ComboBox();
            this.myAssignmentDataSet1 = new MyAssignment.MyAssignmentDataSet();
            this.vtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VNumber
            // 
            this.VNumber.Location = new System.Drawing.Point(88, 58);
            this.VNumber.Multiline = true;
            this.VNumber.Name = "VNumber";
            this.VNumber.Size = new System.Drawing.Size(377, 29);
            this.VNumber.TabIndex = 186;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 189;
            this.label16.Text = "V.Type Name";
            // 
            // myAssignmentDataSet
            // 
            this.myAssignmentDataSet.DataSetName = "MyAssignmentDataSet";
            this.myAssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 189;
            this.label1.Text = "Vehicle No";
            // 
            // vModel
            // 
            this.vModel.Location = new System.Drawing.Point(88, 93);
            this.vModel.Multiline = true;
            this.vModel.Name = "vModel";
            this.vModel.Size = new System.Drawing.Size(377, 29);
            this.vModel.TabIndex = 186;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 189;
            this.label2.Text = "Vehicle Model";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 29);
            this.button2.TabIndex = 191;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 192;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 29);
            this.button4.TabIndex = 193;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.Column4});
            this.Gv.GridColor = System.Drawing.Color.Teal;
            this.Gv.Location = new System.Drawing.Point(89, 128);
            this.Gv.MultiSelect = false;
            this.Gv.Name = "Gv";
            this.Gv.ReadOnly = true;
            this.Gv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Gv.Size = new System.Drawing.Size(375, 186);
            this.Gv.TabIndex = 198;
            this.Gv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Gv_RowHeaderMouseClick);
            // 
            // vtypeTableAdapter
            // 
            this.vtypeTableAdapter.ClearBeforeFill = true;
            // 
            // vtypeBindingSource1
            // 
            this.vtypeBindingSource1.DataMember = "Vtype";
            this.vtypeBindingSource1.DataSource = this.myAssignmentDataSet;
            // 
            // typename
            // 
            this.typename.DataSource = this.vtypeBindingSource;
            this.typename.DisplayMember = "VtypeName";
            this.typename.FormattingEnabled = true;
            this.typename.Location = new System.Drawing.Point(88, 28);
            this.typename.Name = "typename";
            this.typename.Size = new System.Drawing.Size(377, 21);
            this.typename.TabIndex = 199;
            this.typename.ValueMember = "TypeID";
            // 
            // myAssignmentDataSet1
            // 
            this.myAssignmentDataSet1.DataSetName = "MyAssignmentDataSet";
            this.myAssignmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vtypeBindingSource
            // 
            this.vtypeBindingSource.DataMember = "Vtype";
            this.vtypeBindingSource.DataSource = this.myAssignmentDataSet1;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(622, 42);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(51, 29);
            this.id.TabIndex = 200;
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
            this.Column2.HeaderText = "Type";
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
            this.Column4.HeaderText = "Model";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(485, 369);
            this.Controls.Add(this.id);
            this.Controls.Add(this.typename);
            this.Controls.Add(this.Gv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.vModel);
            this.Controls.Add(this.VNumber);
            this.Name = "VehicleType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.VehicleType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAssignmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView Gv;
        private MyAssignmentDataSet myAssignmentDataSet;
        private MyAssignmentDataSetTableAdapters.VtypeTableAdapter vtypeTableAdapter;
        private System.Windows.Forms.BindingSource vtypeBindingSource1;
        private System.Windows.Forms.ComboBox typename;
        private MyAssignmentDataSet myAssignmentDataSet1;
        private System.Windows.Forms.BindingSource vtypeBindingSource;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}