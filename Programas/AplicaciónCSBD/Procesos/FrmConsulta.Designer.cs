namespace AplicaciónCSBD.Procesos {
  partial class FrmConsulta {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataSet3 = new AplicaciónCSBD.DataSet3();
      this.aLUMCALIFSBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.aLUMCALIFSTableAdapter = new AplicaciónCSBD.DataSet3TableAdapters.ALUMCALIFSTableAdapter();
      this.nOMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cALIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnEjemplo = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMALDataGridViewTextBoxColumn,
            this.nOMMATDataGridViewTextBoxColumn,
            this.cALIFDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.aLUMCALIFSBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(445, 150);
      this.dataGridView1.TabIndex = 0;
      // 
      // dataSet3
      // 
      this.dataSet3.DataSetName = "DataSet3";
      this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // aLUMCALIFSBindingSource
      // 
      this.aLUMCALIFSBindingSource.DataMember = "ALUMCALIFS";
      this.aLUMCALIFSBindingSource.DataSource = this.dataSet3;
      // 
      // aLUMCALIFSTableAdapter
      // 
      this.aLUMCALIFSTableAdapter.ClearBeforeFill = true;
      // 
      // nOMALDataGridViewTextBoxColumn
      // 
      this.nOMALDataGridViewTextBoxColumn.DataPropertyName = "NOMAL";
      this.nOMALDataGridViewTextBoxColumn.HeaderText = "NOMAL";
      this.nOMALDataGridViewTextBoxColumn.Name = "nOMALDataGridViewTextBoxColumn";
      this.nOMALDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // nOMMATDataGridViewTextBoxColumn
      // 
      this.nOMMATDataGridViewTextBoxColumn.DataPropertyName = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.HeaderText = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.Name = "nOMMATDataGridViewTextBoxColumn";
      this.nOMMATDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // cALIFDataGridViewTextBoxColumn
      // 
      this.cALIFDataGridViewTextBoxColumn.DataPropertyName = "CALIF";
      this.cALIFDataGridViewTextBoxColumn.HeaderText = "CALIF";
      this.cALIFDataGridViewTextBoxColumn.Name = "cALIFDataGridViewTextBoxColumn";
      this.cALIFDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // fECHADataGridViewTextBoxColumn
      // 
      this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
      this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
      this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
      this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // btnEjemplo
      // 
      this.btnEjemplo.Location = new System.Drawing.Point(305, 210);
      this.btnEjemplo.Name = "btnEjemplo";
      this.btnEjemplo.Size = new System.Drawing.Size(150, 23);
      this.btnEjemplo.TabIndex = 1;
      this.btnEjemplo.Text = "Cantidad de califs>=8";
      this.btnEjemplo.UseVisualStyleBackColor = true;
      this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
      // 
      // FrmConsulta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(472, 251);
      this.Controls.Add(this.btnEjemplo);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmConsulta";
      this.Text = "Procesamiento simple de datos de una BD";
      this.Load += new System.EventHandler(this.FrmConsulta_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DataSet3 dataSet3;
    private System.Windows.Forms.BindingSource aLUMCALIFSBindingSource;
    private DataSet3TableAdapters.ALUMCALIFSTableAdapter aLUMCALIFSTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMALDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMMATDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cALIFDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnEjemplo;
  }
}