using CalculoViaticos.Clases;
using CalculoViaticos.ConexionSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoViaticos.FORMULARIOS
{
    public partial class frmViaticos : Form
    {
        public frmViaticos()
        {
            InitializeComponent();
        }
        Metodos metodos = new Metodos();

        private void frmViaticos_Load(object sender, EventArgs e)
        {
            metodos.MostrarViaticos(dgViaticos);
        }

        private void dgViaticos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgViaticos.SelectedRows.Count > 0)
            {
                string correo = dgViaticos.CurrentRow.Cells[2].Value.ToString();

                InicioSesion user = new InicioSesion();
                user.MensajeViaticos(correo);

                frmCalculoViaticos frm = new frmCalculoViaticos();
                DatosViaticos datos = new DatosViaticos();
                datos.Idempleado = int.Parse(dgViaticos.CurrentRow.Cells[0].Value.ToString());
                datos.nombre = dgViaticos.CurrentRow.Cells[1].Value.ToString();
                datos.correo = dgViaticos.CurrentRow.Cells[2].Value.ToString();
                datos.codigo = int.Parse(dgViaticos.CurrentRow.Cells[3].Value.ToString());
                datos.fechaSalida = dgViaticos.CurrentRow.Cells[4].Value.ToString();
                datos.fechaRegreso = dgViaticos.CurrentRow.Cells[5].Value.ToString();
                datos.subTotalDesayuno = float.Parse(dgViaticos.CurrentRow.Cells[6].Value.ToString());
                datos.subTotalAlmuerzo = float.Parse(dgViaticos.CurrentRow.Cells[7].Value.ToString());
                datos.subTotalCena = float.Parse(dgViaticos.CurrentRow.Cells[8].Value.ToString());
                datos.Total = float.Parse(dgViaticos.CurrentRow.Cells[9].Value.ToString());
                datos.nodiasdesayuno = int.Parse(dgViaticos.CurrentRow.Cells[10].Value.ToString());
                datos.asignaciondesayuno = float.Parse(dgViaticos.CurrentRow.Cells[11].Value.ToString());
                datos.nodiasalmuerzo = int.Parse(dgViaticos.CurrentRow.Cells[12].Value.ToString());
                datos.asignacionalmuerzo = float.Parse(dgViaticos.CurrentRow.Cells[13].Value.ToString());
                datos.nodiascena = int.Parse(dgViaticos.CurrentRow.Cells[14].Value.ToString());
                datos.asignacioncena = float.Parse(dgViaticos.CurrentRow.Cells[15].Value.ToString());
                datos.nodiashosp = int.Parse(dgViaticos.CurrentRow.Cells[16].Value.ToString());
                datos.asignacionxdiahosp = int.Parse(dgViaticos.CurrentRow.Cells[17].Value.ToString());
                datos.ida = int.Parse(dgViaticos.CurrentRow.Cells[18].Value.ToString());
                datos.regreso = int.Parse(dgViaticos.CurrentRow.Cells[19].Value.ToString());
                datos.nodiasotros = int.Parse(dgViaticos.CurrentRow.Cells[20].Value.ToString());
                datos.asignacionxdia = float.Parse(dgViaticos.CurrentRow.Cells[21].Value.ToString());
                datos.descripcionotros = dgViaticos.CurrentRow.Cells[22].Value.ToString();
                frm.datosViaticos.Add(datos);
                frm.Show();
            }
            else MessageBox.Show("Por favor seleccione una fila");
        }
    }
}
