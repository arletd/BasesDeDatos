using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónCSBD
{
  public partial class FrmMenú : Form
  {
    public FrmMenú()
    {
      InitializeComponent();
    }

    //Termina la aplicacion
    private void MnuSalir_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    //Abre la forma de alumnos
    private void MnuAlumnos_Click(object sender, EventArgs e) {
      Tablas.FrmAlumnos fa = new Tablas.FrmAlumnos();
      fa.Show();
    }

    private void materiasToolStripMenuItem_Click(object sender, EventArgs e) {
      Tablas.FrmMaters fa = new Tablas.FrmMaters();
      fa.Show();
    }

    //Abre la forma de la consulta
    private void MnuConsulta_Click(object sender, EventArgs e) {
      Procesos.FrmConsulta fa = new Procesos.FrmConsulta();
      fa.ShowDialog();
    }

    //Abre la forma para ejecutar programas almacenados
    private void MnuSubprogsAlm_Click(object sender, EventArgs e) {
      Procesos.FrmSubprogsAlm fa = new Procesos.FrmSubprogsAlm();
      fa.Show();
    }

    //Abre la forma para ejecutar el GestorBD
    private void gestorBDToolStripMenuItem_Click(object sender, EventArgs e) {
      Procesos.FrmGestorBD fa = new Procesos.FrmGestorBD();
      fa.Show();
    }
          //Forma que tiene el manejo de las transacciones
          private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Procesos.FrmTransac fa = new Procesos.FrmTransac();
               fa.Show();
          }

          private void articulosAccessToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Tablas.FrmArticulosAcces fa = new Tablas.FrmArticulosAcces();
               fa.Show();
          }
     }
}
