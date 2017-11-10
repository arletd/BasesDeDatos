using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónCSBD.Tablas
{
     public partial class FrmArticulosAcces : Form
     {
          public FrmArticulosAcces()
          {
               InitializeComponent();
          }
          GestorBD.GestorBD GestorBD;
          DataSet dsArticulos = new DataSet();
          String CadSql;

          private void FrmArticulosAcces_Load(object sender, EventArgs e)
          {
               GestorBD = new GestorBD.GestorBD("Microsoft.ACE.OLEDB.12.0", "Admin", "", "C:/BD/Programas/ViajesCads2o121.accdb");
          }

          private void bt1_Click(object sender, EventArgs e)
          {
               CadSql = "select * from Articulo";
               GestorBD.consBD(CadSql, "DatosArticulos", dsArticulos);
               dataGridView1.DataSource=dsArticulos.Tables["DatosArticulos"];
          }

          //Inserta un nuevo artículo fijo
          private void button1_Click(object sender, EventArgs e)
          {
               String tipoArt = "Lavadora", marca = "Maytag";
               CadSql = "insert into Articulo values("+9+", '"+ tipoArt+"', '"+ marca+"')";
               if (GestorBD.altaBD(CadSql) == 1)
                    MessageBox.Show("Ins. correcta");
               else
                    MessageBox.Show("Ins. incorrecta");
          }
     }
}
