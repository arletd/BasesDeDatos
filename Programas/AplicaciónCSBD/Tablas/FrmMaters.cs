using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónCSBD.Tablas {
  public partial class FrmMaters : Form {
    public FrmMaters() {
      InitializeComponent();
    }

    private void FrmMaters_Load(object sender, EventArgs e) {
      // TODO: esta línea de código carga datos en la tabla 'dataSet2.MATER' Puede moverla o quitarla según sea necesario.
      this.mATERTableAdapter.Fill(this.dataSet2.MATER);

    }

    private void BtnActualizarMat_Click(object sender, EventArgs e) {
      this.mATERTableAdapter.Update(this.dataSet2.MATER);
    }
  }
}
