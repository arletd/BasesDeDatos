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
  //Esta forma muestra el uso de la clase GestorBD y sus metodos de consuta, alta, baja y cambios
  public partial class FrmGestorBD : Form {
    public FrmGestorBD() {
      InitializeComponent();
    }

    //Variables de la clase
    GestorBD.GestorBD GestorBD;
    DataSet dsAlum = new DataSet(), dsMater = new DataSet(), dsCalifs = new DataSet();
    String cadSQL;
    Varios.Comunes comunes = new Varios.Comunes();
    const int OK = 1;

    //Acciones inciales
    private void FrmGestorBD_Load(object sender, EventArgs e) {
     
      //1. Hace la conexion a la BD (Solo crea el objeto conexion )
      GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "mencos", "oracle");

      //2. obtiene los datos de llos alumnos
      cadSQL = "select * from Alum";
      GestorBD.consBD(cadSQL, "Alumnos", dsAlum);
      DtgGeneral.DataSource = dsAlum.Tables["Alumnos"];
      comunes.cargaCombo(cboAlum, dsAlum, "Alumnos", "NomAl");

      //Llenar las materias
      cadSQL = "select * from Mater";
      GestorBD.consBD(cadSQL, "Materia", dsMater);
      //DtgGeneral.DataSource = dsMater.Tables["Materia"];
      comunes.cargaCombo(cboMater, dsMater, "Materia", "NomMat");
    }

    private void cboAlum_SelectedIndexChanged(object sender, EventArgs e) {
      cadSQL = "select NomAl, Folio, Calif, Fecha, NomMat " +
        "from Alum a, Historial h, Mater m " +
        "where NomAl = '" + cboAlum.Text + "' and a.CU = h.CU and h.ClaveM = m.ClaveM";
      GestorBD.consBD(cadSQL, "Califs", dsCalifs);
      DtgGeneral.DataSource = dsCalifs.Tables["Califs"];
     
    }


    //Agrega una nueva calificación: el alumno y la materia se seleccionan
    //de sus combo box, calificación y fecha de las cajas correspondientes.
    private void btnAltaCalif_Click(object sender, EventArgs e) {
      //Habilita/deshabilita controles (de esta manera se puede guiar lo que el usuario
      //debe hacer).
      cboMater.Visible = true; cboCalif.Visible = true; dtpFecha.Visible = true;
      btnRegistrar.Visible = true; btnAltaCalif.Enabled = false;
      btnBajaCalif.Enabled = false; btnCambia.Enabled = false;
    }



        //Prepara y envía la cadena de inserción de la nueva calificación.
        private void btnRegistrar_Click(object sender, EventArgs e) {
      DataRow[] filasAlum; DataRow[] filasMater; DataRow fila;
      DataSet dsTemp = new DataSet();
      int folioNuevo, calif, cu, clavem; String fecha, cadSql;

      //Obtiene el máximo folio de las calificaciones.
      cadSql = "select max(FOLIO) as maxFolio from Historial";
      GestorBD.consBD(cadSql, "Temp", dsTemp);
      folioNuevo = Convert.ToInt16(dsTemp.Tables["Temp"].Rows[0]["maxFolio"])+1;

      //Obtiene la calificacion
      calif = Convert.ToInt16(cboCalif.Text);

      //Obtener la fecha
      fecha = "date '" + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "'";

      //Obtiene la clave unica del alumno y la clave de la materia usando los datos que estan en
      //los data set respectivos
      filasAlum = dsAlum.Tables["Alumnos"].Select("NomAl = '" + cboAlum.Text + "'");
      filasMater = dsMater.Tables["Materia"].Select("NomMat='" + cboMater.Text + "'");
      cu = Convert.ToInt16(filasAlum[0]["CU"]);
      clavem = Convert.ToInt16(filasMater[0]["ClaveM"]);

      //Construye y ejecuta la cadena de inserción 
      cadSQL = "insert into Historial values (" + folioNuevo + "," + calif + "," + fecha + "," + cu + "," + clavem + ")";
      if (GestorBD.altaBD(cadSQL) == OK) {
        MessageBox.Show("Inserción correcta");
      }
      else {
        MessageBox.Show("Falló la inserción");
      }

   

      //Habilita/deshabilita controles.
      cboMater.Visible = false; cboMater.Text = "Materias:";
      cboCalif.Visible = false; cboCalif.Text = "Calificación:";
      dtpFecha.Visible = false;
      btnRegistrar.Visible = false; btnAltaCalif.Enabled = true;
      btnBajaCalif.Enabled = true; btnCambia.Enabled = true;
    }
       


        //Para obtener el valor de la celda seleccionada al darle clic en el DataGrid
        //existen tres maneras (necesariamente hay que dar clic en la celda elegida):
        //1) nombreDataGrid.CurrentCell.Value;
        //2) nombreDataGrid[ÍndiceColumna, ÍndiceFila].Value;
        //3) nombreDataGrid[NombreColumna, ÍndiceFila].Value
        private void DtgGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      //int fila, col; Object valor;

      ////Obtiene fila, columna y valor de la celda elegida.
      //fila = DtgGeneral.CurrentCell.RowIndex;
      //col = DtgGeneral.CurrentCell.ColumnIndex;
      //valor = DtgGeneral.CurrentCell.Value;
      //MessageBox.Show("Fila: " + fila + " Columna: " + col + " Valor: " + valor);

      ////Obtiene sólo el valor.
      //MessageBox.Show("Valor: " + DtgGeneral[col, fila].Value.ToString());// se obtiene el dato como si fuera un arreglo, primero la columna y luego la fila


    }

        

        //Realiza el proceso para eliminar una calificación de Historial.//
        private void btnBajaCalif_Click(object sender, EventArgs e){
            int folio; String cadSql;
            DialogResult botón;

            //Toma el folio de la calificación seleccionada en el data grid.
            folio = Convert.ToInt16(DtgGeneral["Folio", DtgGeneral.CurrentRow.Index].Value);
            botón = MessageBox.Show("¿Se elimina el registro con folio= " + folio.ToString(),
              "Eliminación", MessageBoxButtons.YesNo);

            //Si se selecciona el botón Yes, del MessageBox, elimina el registro asociado.
            if (botón == DialogResult.Yes)
            {
                //Construye la cadena de eliminación y la envía para su ejecución.
                cadSql = "delete from Historial where Folio = " + folio;
                if (GestorBD.bajaBD(cadSql) == OK)
                    MessageBox.Show("Se eliminó la calificación del folio " + folio + " exitosamente");
                else
                    MessageBox.Show("No se pudo eliminar la calificación");
            }
        }

        //Muestra un ejemplo de cambio en una tabla de la BD. En este caso se cambia la
        //calificación del folio elegido en el data grid. El cambio podría hacerse en cualquier
        //tabla cuyos datos se mostrarán en el data grid, especificando el código adecuado en
        //los métodos.
        private void btnCambia_Click(object sender, EventArgs e)
        {
            cboCalif.Visible = true; cboCalif.Text = "Calificación:";
            btnRegistrarCambio.Visible = true; btnAltaCalif.Enabled = false;
            btnBajaCalif.Enabled = false; cboAlum.Enabled = false;
        }

        private void btnRegistrarCambio_Click(object sender, EventArgs e)
        {
            int folio, nuevaCalif; String cadSql;

            //Toma el folio de la calificación seleccionada en el data grid.
            folio = Convert.ToInt16(DtgGeneral["Folio", DtgGeneral.CurrentRow.Index].Value);

            //Construye la cadena de cambio.
            DtgGeneral["Calif", DtgGeneral.CurrentRow.Index].Value = cboCalif.Text;
            nuevaCalif = Convert.ToInt16(cboCalif.Text);

            // y la envía para su ejecución.
            cadSql = "update Historial set Calif=" + nuevaCalif + " where Folio=" + folio;
            if (GestorBD.cambiaBD(cadSql) == OK)
                MessageBox.Show("Se actualizó Historial exitosamente");
            else
                MessageBox.Show("No se pudo actualizar Historial");
            cboCalif.Visible = false; cboCalif.Text = "Calificación:";
            btnRegistrarCambio.Visible = false; btnAltaCalif.Enabled = true;
            btnBajaCalif.Enabled = true; cboAlum.Enabled = true;
        }



    }
}
