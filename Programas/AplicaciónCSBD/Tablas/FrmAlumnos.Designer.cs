namespace AplicaciónCSBD.Tablas {
  partial class FrmAlumnos {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlumnos));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.cUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cARRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.aLUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dSAlumnos = new AplicaciónCSBD.DSAlumnos();
      this.aLUMTableAdapter = new AplicaciónCSBD.DSAlumnosTableAdapters.ALUMTableAdapter();
      this.BtnActualizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aLUMBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dSAlumnos)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUDataGridViewTextBoxColumn,
            this.nOMALDataGridViewTextBoxColumn,
            this.cARRDataGridViewTextBoxColumn,
            this.pROMDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.aLUMBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(443, 143);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // cUDataGridViewTextBoxColumn
      // 
      this.cUDataGridViewTextBoxColumn.DataPropertyName = "CU";
      this.cUDataGridViewTextBoxColumn.HeaderText = "CU";
      this.cUDataGridViewTextBoxColumn.Name = "cUDataGridViewTextBoxColumn";
      // 
      // nOMALDataGridViewTextBoxColumn
      // 
      this.nOMALDataGridViewTextBoxColumn.DataPropertyName = "NOMAL";
      this.nOMALDataGridViewTextBoxColumn.HeaderText = "NOMAL";
      this.nOMALDataGridViewTextBoxColumn.Name = "nOMALDataGridViewTextBoxColumn";
      // 
      // cARRDataGridViewTextBoxColumn
      // 
      this.cARRDataGridViewTextBoxColumn.DataPropertyName = "CARR";
      this.cARRDataGridViewTextBoxColumn.HeaderText = "CARR";
      this.cARRDataGridViewTextBoxColumn.Name = "cARRDataGridViewTextBoxColumn";
      // 
      // pROMDataGridViewTextBoxColumn
      // 
      this.pROMDataGridViewTextBoxColumn.DataPropertyName = "PROM";
      this.pROMDataGridViewTextBoxColumn.HeaderText = "PROM";
      this.pROMDataGridViewTextBoxColumn.Name = "pROMDataGridViewTextBoxColumn";
      // 
      // aLUMBindingSource
      // 
      this.aLUMBindingSource.DataMember = "ALUM";
      this.aLUMBindingSource.DataSource = this.dSAlumnos;
      // 
      // dSAlumnos
      // 
      this.dSAlumnos.DataSetName = "DSAlumnos";
      this.dSAlumnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // aLUMTableAdapter
      // 
      this.aLUMTableAdapter.ClearBeforeFill = true;
      // 
      // BtnActualizar
      // 
      this.BtnActualizar.Location = new System.Drawing.Point(357, 212);
      this.BtnActualizar.Name = "BtnActualizar";
      this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
      this.BtnActualizar.TabIndex = 1;
      this.BtnActualizar.Text = "Actualizar";
      this.BtnActualizar.UseVisualStyleBackColor = true;
      this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
      // 
      // FrmAlumnos
      // 
      this.AcceptButton = this.BtnActualizar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(705, 481);
      this.Controls.Add(this.BtnActualizar);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmAlumnos";
      this.Text = "Actualizar";
      this.Load += new System.EventHandler(this.FrmAlumnos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aLUMBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dSAlumnos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DSAlumnos dSAlumnos;
    private System.Windows.Forms.BindingSource aLUMBindingSource;
    private DSAlumnosTableAdapters.ALUMTableAdapter aLUMTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn cUDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMALDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cARRDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn pROMDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button BtnActualizar;
  }
}