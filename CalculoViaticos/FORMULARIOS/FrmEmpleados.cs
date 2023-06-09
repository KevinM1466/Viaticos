using CalculoViaticos.Clases;
using CalculoViaticos.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoViaticos.FORMULARIOS
{
    public partial class FrmEmpleados : Form
    {

        Metodos metodos = new Metodos();
        Empleados empleados = new Empleados();
        Validaciones validaciones = new Validaciones();

        string correo;

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            metodos.MostrarEmpleados(dgEmpleados);
            metodos.ListarPuestos(cmbPuesto);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtCorreo.Text == "" || txtDireccion.Text == "")
                {
                    MessageBox.Show("No puede dejar los campos vacios");
                }
                else
                {
                    if (validaciones.ValidarEmail(txtCorreo.Text))
                    {

                        if (txtDni.TextLength < 13)
                        {
                            MessageBox.Show("El DNI debe tener 13 numeros");
                        }
                        else
                        {
                            correo = txtCorreo.Text;

                            empleados.guardar(txtNombre.Text, txtApellido.Text, int.Parse(cmbPuesto.SelectedValue.ToString()), txtDni.Text, correo, txtDireccion.Text);
                            MessageBox.Show("Empleado guardado exitosamente");
                            limpiar();
                            metodos.MostrarEmpleados(dgEmpleados);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un correo electronico valido");
                    }

                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString().Replace(ex.ToString(), "Este empleado o correo ya estan registrados"));
                //MessageBox.Show(ex.Class.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtCorreo.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("No puede dejar los campos vacios");
            }
            else
            {
                if (validaciones.ValidarEmail(txtCorreo.Text))
                {
                    if (txtDni.TextLength < 13)
                    {
                        MessageBox.Show("El DNI debe tener 13 numeros");
                    }
                    else
                    {
                        correo = txtCorreo.Text;

                        empleados.actualizar(int.Parse(txtCodigo.Text), txtNombre.Text, txtApellido.Text, int.Parse(cmbPuesto.SelectedValue.ToString()), txtDni.Text, correo, txtDireccion.Text);
                        MessageBox.Show("Empleado actualizado correctamente");
                        limpiar();
                        metodos.MostrarEmpleados(dgEmpleados);
                    }

                }
            }

        }

        private void dgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtDni.Text = dgEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgEmpleados.CurrentRow.Cells[5].Value.ToString();
            cmbPuesto.Text = dgEmpleados.CurrentRow.Cells[6].Value.ToString();
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDni.Clear();
            cmbPuesto.Text = dgEmpleados.CurrentRow.Cells[6].Value.ToString();
            lblMensaje.Visible = false;
            lblMsjDni.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = int.Parse(dgEmpleados.CurrentRow.Cells[0].Value.ToString());
                empleados.borrar(Codigo);
                MessageBox.Show("Empleado eliminado correctamente");
                limpiar();
                metodos.MostrarEmpleados(dgEmpleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos");
            }
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.ValidarEmail(txtCorreo.Text) == false)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Correo Electrónico invalido";
                lblMensaje.ForeColor = Color.Red;
            }
            else
            {
                lblMensaje.Text = "Correo Electrónico válido";
                lblMensaje.ForeColor = Color.Green;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.TextLength < 13)
            {
                lblMsjDni.Visible = true;
                lblMsjDni.Text = "El DNI debe tener 13 numeros";
                lblMsjDni.ForeColor = Color.Red;
            }
            else
            {
                lblMsjDni.Text = "DNI Válido";
                lblMsjDni.ForeColor = Color.Green;
            }
        }
    }
}
