namespace AplicaciónCSBD.Tablas {
  partial class FrmMaters {
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
      this.dataSet2 = new AplicaciónCSBD.DataSet2();
      this.mATERBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.mATERTableAdapter = new AplicaciónCSBD.DataSet2TableAdapters.MATERTableAdapter();
      this.cLAVEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cREDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BtnActualizarMat = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mATERBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLAVEMDataGridViewTextBoxColumn,
            this.nOMMATDataGridViewTextBoxColumn,
            this.cREDSDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.mATERBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(344, 150);
      this.dataGridView1.TabIndex = 0;
      // 
      // dataSet2
      // 
      this.dataSet2.DataSetName = "DataSet2";
      this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // mATERBindingSource
      // 
      this.mATERBindingSource.DataMember = "MATER";
      this.mATERBindingSource.DataSource = this.dataSet2;
      // 
      // mATERTableAdapter
      // 
      this.mATERTableAdapter.ClearBeforeFill = true;
      // 
      // cLAVEMDataGridViewTextBoxColumn
      // 
      this.cLAVEMDataGridViewTextBoxColumn.DataPropertyName = "CLAVEM";
      this.cLAVEMDataGridViewTextBoxColumn.HeaderText = "CLAVEM";
      this.cLAVEMDataGridViewTextBoxColumn.Name = "cLAVEMDataGridViewTextBoxColumn";
      // 
      // nOMMATDataGridViewTextBoxColumn
      // 
      this.nOMMATDataGridViewTextBoxColumn.DataPropertyName = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.HeaderText = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.Name = "nOMMATDataGridViewTextBoxColumn";
      // 
      // cREDSDataGridViewTextBoxColumn
      // 
      this.cREDSDataGridViewTextBoxColumn.DataPropertyName = "CREDS";
      this.cREDSDataGridViewTextBoxColumn.HeaderText = "CREDS";
      this.cREDSDataGridViewTextBoxColumn.Name = "cREDSDataGridViewTextBoxColumn";
      // 
      // BtnActualizarMat
      // 
      this.BtnActualizarMat.Location = new System.Drawing.Point(271, 201);
      this.BtnActualizarMat.Name = "BtnActualizarMat";
      this.BtnActualizarMat.Size = new System.Drawing.Size(75, 23);
      this.BtnActualizarMat.TabIndex = 1;
      this.BtnActualizarMat.Text = "Actualizar";
      this.BtnActualizarMat.UseVisualStyleBackColor = true;
      this.BtnActualizarMat.Click += new System.EventHandler(this.BtnActualizarMat_Click);
      // 
      // FrmMaters
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(370, 259);
      this.Controls.Add(this.BtnActualizarMat);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmMaters";
      this.Text = "FrmMaters";
      this.Load += new System.EventHandler(this.FrmMaters_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mATERBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DataSet2 dataSet2;
    private System.Windows.Forms.BindingSource mATERBindingSource;
    private DataSet2TableAdapters.MATERTableAdapter mATERTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn cLAVEMDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMMATDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cREDSDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button BtnActualizarMat;
  }
}