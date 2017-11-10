using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónCSBD.Procesos {
  public partial class FrmConsulta : Form {
    public FrmConsulta() {
      InitializeComponent();
    }

    private void FrmConsulta_Load(object sender, EventArgs e) {
      // TODO: esta línea de código carga datos en la tabla 'dataSet3.ALUMCALIFS' Puede moverla o quitarla según sea necesario.
      this.aLUMCALIFSTableAdapter.Fill(this.dataSet3.ALUMCALIFS);

    }


    /*
     * Ejemplo de procesamiento simple de una BD
     * 
     * **/
    private void btnEjemplo_Click(object sender, EventArgs e) {
      DataTable tabla;
      int calif, conta = 0;

      //Accede a la unica tabla del data set
      tabla = dataSet3.Tables[0];//En lugar del indice se puede poner el nombre de la vista "AlumnCalifs"

      //La recorre y la procesa
      foreach (DataRow fila in tabla.Rows) {
        calif = Convert.ToInt16(fila["Calif"]);
        if (calif >= 8)
          conta++;
      }
      MessageBox.Show("Cantidad de calificaciones mayores a 8 : "+conta);
    }
  }
}
