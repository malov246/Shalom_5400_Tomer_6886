namespace test1
{
    partial class DataSource_Form
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
            this.oracleSelectCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleInsertCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleUpdateCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleDeleteCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleDataAdapter1 = new System.Data.OracleClient.OracleDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new test1.DataSet1();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByLocation1700ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByLocation1700ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new test1.DataSet1();
            this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new test1.DataSet1();
    //        this.devisionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet13 = new test1.DataSet1();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new test1.DataSet1TableAdapters.LectureTableAdapter();
            this.pINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
     //       this.dEVISIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByLocation1700ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.devisionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oracleDataAdapter1
            // 
            this.oracleDataAdapter1.DeleteCommand = this.oracleDeleteCommand1;
            this.oracleDataAdapter1.InsertCommand = this.oracleInsertCommand1;
            this.oracleDataAdapter1.SelectCommand = this.oracleSelectCommand1;
            this.oracleDataAdapter1.UpdateCommand = this.oracleUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1000, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByLocation1700ToolStrip
            // 
            this.fillByLocation1700ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByLocation1700ToolStripButton});
            this.fillByLocation1700ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByLocation1700ToolStrip.Name = "fillByLocation1700ToolStrip";
            this.fillByLocation1700ToolStrip.Size = new System.Drawing.Size(1000, 25);
            this.fillByLocation1700ToolStrip.TabIndex = 2;
            this.fillByLocation1700ToolStrip.Text = "fillByLocation1700ToolStrip";
            // 
            // fillByLocation1700ToolStripButton
            // 
            this.fillByLocation1700ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByLocation1700ToolStripButton.Name = "fillByLocation1700ToolStripButton";
            this.fillByLocation1700ToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.fillByLocation1700ToolStripButton.Text = "FillByLocation1700";
            this.fillByLocation1700ToolStripButton.Click += new System.EventHandler(this.fillByLocation1700ToolStripButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pINDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.fNAMEDataGridViewTextBoxColumn,
      //      this.dEVISIONDataGridViewTextBoxColumn,
            this.bIRTHDATEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lectureBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(537, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 173);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11BindingSource
            // 
            this.dataSet11BindingSource.DataSource = this.dataSet11;
            this.dataSet11BindingSource.Position = 0;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devisionBindingSource2
            // 
        //    this.devisionBindingSource2.DataMember = "Devision";
       //     this.devisionBindingSource2.DataSource = this.dataSet12;
            // 
            // dataSet12BindingSource
            // 
            this.dataSet12BindingSource.DataSource = this.dataSet12;
            this.dataSet12BindingSource.Position = 0;
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet1";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "Lecture";
            this.lectureBindingSource.DataSource = this.dataSet1;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // pINDataGridViewTextBoxColumn
            // 
            this.pINDataGridViewTextBoxColumn.DataPropertyName = "PIN";
            this.pINDataGridViewTextBoxColumn.HeaderText = "PIN";
            this.pINDataGridViewTextBoxColumn.Name = "pINDataGridViewTextBoxColumn";
            this.pINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            this.lNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            this.fNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEVISIONDataGridViewTextBoxColumn
            // 
         //   this.dEVISIONDataGridViewTextBoxColumn.DataPropertyName = "DEVISION";
       //     this.dEVISIONDataGridViewTextBoxColumn.HeaderText = "DEVISION";
        //    this.dEVISIONDataGridViewTextBoxColumn.Name = "dEVISIONDataGridViewTextBoxColumn";
        //    this.dEVISIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bIRTHDATEDataGridViewTextBoxColumn
            // 
            this.bIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.HeaderText = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.Name = "bIRTHDATEDataGridViewTextBoxColumn";
            this.bIRTHDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataSource_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 262);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.fillByLocation1700ToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataSource_Form";
            this.Text = "DataSource_Form";
            this.Load += new System.EventHandler(this.DataSource_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByLocation1700ToolStrip.ResumeLayout(false);
            this.fillByLocation1700ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
      //      ((System.ComponentModel.ISupportInitialize)(this.devisionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OracleClient.OracleCommand oracleSelectCommand1;
        private System.Data.OracleClient.OracleCommand oracleInsertCommand1;
        private System.Data.OracleClient.OracleCommand oracleUpdateCommand1;
        private System.Data.OracleClient.OracleCommand oracleDeleteCommand1;
        private System.Data.OracleClient.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByLocation1700ToolStrip;
        private System.Windows.Forms.ToolStripButton fillByLocation1700ToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dataSet11BindingSource;
        private DataSet1 dataSet11;
        //private DataSet1TableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private DataSet1 dataSet12;
      //  private System.Windows.Forms.BindingSource devisionBindingSource2;
        private System.Windows.Forms.BindingSource dataSet12BindingSource;
        private DataSet1 dataSet13;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private DataSet1TableAdapters.LectureTableAdapter lectureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
     //   private System.Windows.Forms.DataGridViewTextBoxColumn dEVISIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDATEDataGridViewTextBoxColumn;
    }
}