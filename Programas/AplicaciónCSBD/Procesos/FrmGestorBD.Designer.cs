namespace AplicaciónCSBD.Procesos {
  partial class FrmGestorBD {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestorBD));
            this.DtgGeneral = new System.Windows.Forms.DataGridView();
            this.aLUMCALIFSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new AplicaciónCSBD.DataSet3();
            this.cboAlum = new System.Windows.Forms.ComboBox();
            this.cboMater = new System.Windows.Forms.ComboBox();
            this.btnAltaCalif = new System.Windows.Forms.Button();
            this.btnBajaCalif = new System.Windows.Forms.Button();
            this.btnCambia = new System.Windows.Forms.Button();
            this.cboCalif = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataSet4 = new AplicaciónCSBD.DataSet4();
            this.hISTORIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hISTORIALTableAdapter = new AplicaciónCSBD.DataSet4TableAdapters.HISTORIALTableAdapter();
            this.dSAlumnos = new AplicaciónCSBD.DSAlumnos();
            this.dSAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMCALIFSTableAdapter = new AplicaciónCSBD.DataSet3TableAdapters.ALUMCALIFSTableAdapter();
            this.aLUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMTableAdapter = new AplicaciónCSBD.DSAlumnosTableAdapters.ALUMTableAdapter();
            this.btnRegistrarCambio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgGeneral
            // 
            this.DtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgGeneral.Location = new System.Drawing.Point(125, 24);
            this.DtgGeneral.Name = "DtgGeneral";
            this.DtgGeneral.Size = new System.Drawing.Size(481, 211);
            this.DtgGeneral.TabIndex = 0;
            this.DtgGeneral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgGeneral_CellContentClick);
            // 
            // aLUMCALIFSBindingSource
            // 
            this.aLUMCALIFSBindingSource.DataMember = "ALUMCALIFS";
            this.aLUMCALIFSBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboAlum
            // 
            this.cboAlum.FormattingEnabled = true;
            this.cboAlum.Location = new System.Drawing.Point(54, 254);
            this.cboAlum.Name = "cboAlum";
            this.cboAlum.Size = new System.Drawing.Size(159, 21);
            this.cboAlum.TabIndex = 1;
            this.cboAlum.Text = "Alumnos";
            this.cboAlum.SelectedIndexChanged += new System.EventHandler(this.cboAlum_SelectedIndexChanged);
            // 
            // cboMater
            // 
            this.cboMater.FormattingEnabled = true;
            this.cboMater.Location = new System.Drawing.Point(54, 364);
            this.cboMater.Name = "cboMater";
            this.cboMater.Size = new System.Drawing.Size(159, 21);
            this.cboMater.TabIndex = 2;
            this.cboMater.Text = "Materias";
            this.cboMater.Visible = false;
            // 
            // btnAltaCalif
            // 
            this.btnAltaCalif.Location = new System.Drawing.Point(54, 308);
            this.btnAltaCalif.Name = "btnAltaCalif";
            this.btnAltaCalif.Size = new System.Drawing.Size(159, 23);
            this.btnAltaCalif.TabIndex = 3;
            this.btnAltaCalif.Text = "Alta calificación";
            this.btnAltaCalif.UseVisualStyleBackColor = true;
            this.btnAltaCalif.Click += new System.EventHandler(this.btnAltaCalif_Click);
            // 
            // btnBajaCalif
            // 
            this.btnBajaCalif.Location = new System.Drawing.Point(256, 308);
            this.btnBajaCalif.Name = "btnBajaCalif";
            this.btnBajaCalif.Size = new System.Drawing.Size(159, 23);
            this.btnBajaCalif.TabIndex = 4;
            this.btnBajaCalif.Text = "Baja calificación";
            this.btnBajaCalif.UseVisualStyleBackColor = true;
            this.btnBajaCalif.Click += new System.EventHandler(this.btnBajaCalif_Click);
            // 
            // btnCambia
            // 
            this.btnCambia.Location = new System.Drawing.Point(465, 308);
            this.btnCambia.Name = "btnCambia";
            this.btnCambia.Size = new System.Drawing.Size(159, 23);
            this.btnCambia.TabIndex = 5;
            this.btnCambia.Text = "Cambiar calificación";
            this.btnCambia.UseVisualStyleBackColor = true;
            this.btnCambia.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // cboCalif
            // 
            this.cboCalif.FormattingEnabled = true;
            this.cboCalif.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5"});
            this.cboCalif.Location = new System.Drawing.Point(256, 365);
            this.cboCalif.Name = "cboCalif";
            this.cboCalif.Size = new System.Drawing.Size(159, 21);
            this.cboCalif.TabIndex = 6;
            this.cboCalif.Text = "Calificaciones";
            this.cboCalif.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(465, 364);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(256, 426);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(159, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar alta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hISTORIALBindingSource
            // 
            this.hISTORIALBindingSource.DataMember = "HISTORIAL";
            this.hISTORIALBindingSource.DataSource = this.dataSet4;
            // 
            // hISTORIALTableAdapter
            // 
            this.hISTORIALTableAdapter.ClearBeforeFill = true;
            // 
            // dSAlumnos
            // 
            this.dSAlumnos.DataSetName = "DSAlumnos";
            this.dSAlumnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSAlumnosBindingSource
            // 
            this.dSAlumnosBindingSource.DataSource = this.dSAlumnos;
            this.dSAlumnosBindingSource.Position = 0;
            // 
            // aLUMCALIFSTableAdapter
            // 
            this.aLUMCALIFSTableAdapter.ClearBeforeFill = true;
            // 
            // aLUMBindingSource
            // 
            this.aLUMBindingSource.DataMember = "ALUM";
            this.aLUMBindingSource.DataSource = this.dSAlumnos;
            // 
            // aLUMTableAdapter
            // 
            this.aLUMTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegistrarCambio
            // 
            this.btnRegistrarCambio.Location = new System.Drawing.Point(465, 426);
            this.btnRegistrarCambio.Name = "btnRegistrarCambio";
            this.btnRegistrarCambio.Size = new System.Drawing.Size(159, 23);
            this.btnRegistrarCambio.TabIndex = 9;
            this.btnRegistrarCambio.Text = "Registrar cambio";
            this.btnRegistrarCambio.UseVisualStyleBackColor = true;
            this.btnRegistrarCambio.Click += new System.EventHandler(this.btnRegistrarCambio_Click);
            // 
            // FrmGestorBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 492);
            this.Controls.Add(this.btnRegistrarCambio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboCalif);
            this.Controls.Add(this.btnCambia);
            this.Controls.Add(this.btnBajaCalif);
            this.Controls.Add(this.btnAltaCalif);
            this.Controls.Add(this.cboMater);
            this.Controls.Add(this.cboAlum);
            this.Controls.Add(this.DtgGeneral);
            this.Name = "FrmGestorBD";
            this.Text = "Uso de los métodos de la clase GestorBD";
            this.Load += new System.EventHandler(this.FrmGestorBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMBindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView DtgGeneral;
    private System.Windows.Forms.ComboBox cboAlum;
    private System.Windows.Forms.ComboBox cboMater;
    private System.Windows.Forms.Button btnAltaCalif;
    private System.Windows.Forms.Button btnBajaCalif;
    private System.Windows.Forms.Button btnCambia;
    private System.Windows.Forms.ComboBox cboCalif;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Button btnRegistrar;
    private DataSet4 dataSet4;
    private System.Windows.Forms.BindingSource hISTORIALBindingSource;
    private DataSet4TableAdapters.HISTORIALTableAdapter hISTORIALTableAdapter;
    private System.Windows.Forms.BindingSource dSAlumnosBindingSource;
    private DSAlumnos dSAlumnos;
    private DataSet3 dataSet3;
    private System.Windows.Forms.BindingSource aLUMCALIFSBindingSource;
    private DataSet3TableAdapters.ALUMCALIFSTableAdapter aLUMCALIFSTableAdapter;
    private System.Windows.Forms.BindingSource aLUMBindingSource;
    private DSAlumnosTableAdapters.ALUMTableAdapter aLUMTableAdapter;
        private System.Windows.Forms.Button btnRegistrarCambio;
    }
}