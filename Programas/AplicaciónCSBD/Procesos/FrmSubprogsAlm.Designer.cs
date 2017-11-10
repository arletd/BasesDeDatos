namespace AplicaciónCSBD.Procesos {
  partial class FrmSubprogsAlm {
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
      this.btnProgsAlm = new System.Windows.Forms.Button();
      this.btnFuncAlm = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnProgsAlm
      // 
      this.btnProgsAlm.Location = new System.Drawing.Point(45, 160);
      this.btnProgsAlm.Name = "btnProgsAlm";
      this.btnProgsAlm.Size = new System.Drawing.Size(202, 23);
      this.btnProgsAlm.TabIndex = 0;
      this.btnProgsAlm.Text = "Ejecutar procedimiento almacenado";
      this.btnProgsAlm.UseVisualStyleBackColor = true;
      this.btnProgsAlm.Click += new System.EventHandler(this.btnProgsAlm_Click);
      // 
      // btnFuncAlm
      // 
      this.btnFuncAlm.Location = new System.Drawing.Point(45, 199);
      this.btnFuncAlm.Name = "btnFuncAlm";
      this.btnFuncAlm.Size = new System.Drawing.Size(202, 23);
      this.btnFuncAlm.TabIndex = 1;
      this.btnFuncAlm.Text = "Ejecutar funcion almacenada";
      this.btnFuncAlm.UseVisualStyleBackColor = true;
      this.btnFuncAlm.Click += new System.EventHandler(this.btnFuncAlm_Click);
      // 
      // FrmSubprogsAlm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MediumPurple;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnFuncAlm);
      this.Controls.Add(this.btnProgsAlm);
      this.Name = "FrmSubprogsAlm";
      this.Text = "Ejecución de subprogramas almacenados";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnProgsAlm;
    private System.Windows.Forms.Button btnFuncAlm;
  }
}