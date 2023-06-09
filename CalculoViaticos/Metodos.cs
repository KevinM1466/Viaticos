using CalculoViaticos.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace CalculoViaticos
{
    public class Metodos
    {
        public void MostrarEmpleados(DataGridView dgEmpleados)
        {
            Empleados empleados = new Empleados();
            dgEmpleados.DataSource = empleados.Mostrar();
            dgEmpleados.Columns[0].Visible = false;
        }
        public void MostrarViaticos(DataGridView dgEmpleados)
        {
            Reporte reporte = new Reporte();
            dgEmpleados.DataSource = reporte.MostrarViaticos();
            //dgEmpleados.Columns[0].Visible = false;
            //dgEmpleados.Columns[3].Visible = false;
            //dgEmpleados.Columns[6].Visible = false;
            //dgEmpleados.Columns[7].Visible = false;
            //dgEmpleados.Columns[8].Visible = false;
        }

        public void ListarPuestos(ComboBox cmbPuesto)
        {
            Puestos objeto = new Puestos();
            cmbPuesto.DataSource = objeto.ListarPuestos();
            cmbPuesto.DisplayMember = "Puesto";
            cmbPuesto.ValueMember = "ID";
        }

        public void ListarEmpleados(ComboBox cmbEmpleados)
        {
            Puestos objeto = new Puestos();
            cmbEmpleados.DataSource = objeto.ListarEmpleados();
            cmbEmpleados.DisplayMember = "Nombre Completo";
            cmbEmpleados.ValueMember = "Codigo";
        }

        public void ListarTipoTransporte(ComboBox cmbEmpleados)
        {
            Puestos objeto = new Puestos();
            cmbEmpleados.DataSource = objeto.ListarTipoTransporte();
            cmbEmpleados.DisplayMember = "tipoTransporte";
            cmbEmpleados.ValueMember = "idTipoTransporte";
        }

        public void ListarAlimentacion(ComboBox cmbEmpleados)
        {
            ListarViaticos objeto = new ListarViaticos();
            cmbEmpleados.DataSource = objeto.ListarAlimentacion();
            cmbEmpleados.DisplayMember = "IdAlimentacion";
            cmbEmpleados.ValueMember = "IdAlimentacion";
        }

        public void ListarTransporte(ComboBox cmbEmpleados)
        {
            ListarViaticos objeto = new ListarViaticos();
            cmbEmpleados.DataSource = objeto.ListarTransporte();
            cmbEmpleados.DisplayMember = "IdTransporte";
            cmbEmpleados.ValueMember = "IdTransporte";
        }

        public void ListarHospedaje(ComboBox cmbEmpleados)
        {
            ListarViaticos objeto = new ListarViaticos();
            cmbEmpleados.DataSource = objeto.ListarHospedaje();
            cmbEmpleados.DisplayMember = "IdHospedaje";
            cmbEmpleados.ValueMember = "IdHospedaje";
        }

        public void ListarOtros(ComboBox cmbEmpleados)
        {
            ListarViaticos objeto = new ListarViaticos();
            cmbEmpleados.DataSource = objeto.ListarOtros();
            cmbEmpleados.DisplayMember = "IdOtros";
            cmbEmpleados.ValueMember = "IdOtros";
        }
    }
}
