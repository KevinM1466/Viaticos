using CalculoViaticos.Clases;
using CalculoViaticos.ConexionSql;
using CalculoViaticos.CRUD;
using CalculoViaticos.FORMULARIOS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculoViaticos
{
    public partial class FrmGeneral : Form
    {
        Reporte reporte = new Reporte();
        Validaciones validaciones = new Validaciones();
        public bool vacio = true;
        public bool resultado = true;

        private Form currentChildForm;
        int diasDesayuno = 0;
        float asignacionDesayuno = 0;
        int diasAlmuerzo = 0;
        float asignacionAlmuerzo = 0;
        int diasCena = 0;
        float asignacionCena = 0;
        int diashosp = 0;
        float asignacionHosp = 0;
        int ida = 0;
        int venida = 0;
        int diasOtro = 0;
        float asignacionOtro = 0;
        float totaldesayuno = 0;
        float totalalmuerzo = 0;
        float totalcena = 0;

        int alimentacion;
        int hospedaje;
        int transporte;
        int otros;

        DateTime fechaSalida;
        DateTime fechaRegreso;
        int diasViaticos;

        public FrmGeneral()
        {
            InitializeComponent();
        }

        private void FrmGeneral_Load(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            metodos.ListarEmpleados(cmbEmpleado);
            metodos.ListarTipoTransporte(cmbtipotrans);

            seleccionador();
        }


        private void btSiguiente_Click(object sender, EventArgs e)
        {
            fechaSalida = dtpFechaSalida.Value.Date;
            fechaRegreso = dtpFechaRegreso.Value.Date;

            TimeSpan dias = fechaRegreso - fechaSalida;

            if (dias.Days == 0)
            {
                diasViaticos = 1;
            }
            else
            {
                diasViaticos = dias.Days + 1;
            }

            if (txtnodiasdesayuno.Text == "" || txtnodiasalmuerzo.Text == "" || txtnodiascena.Text == "" || txtasignaciondesayuno.Text == "" || txtasignacionalmuerzo.Text == "" || txtasignacioncena.Text == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            } else
            {
                if (dtpFechaSalida.Value > dtpFechaRegreso.Value)
                {
                    MessageBox.Show("Lo siento la fecha de salida no \n puede ser menor a la fecha de regreso", "Soporte Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tcGeneral.SelectedIndex += 1;

                    if (tcGeneral.SelectedIndex == 0)
                    {
                        btAtras.Visible = false;
                    }
                    else
                    {
                        btAtras.Visible = true;
                    }

                    if (tcGeneral.SelectedIndex == 3)
                    {
                        btSiguiente.Visible = false;
                        btnGuardar.Visible = true;
                    }
                    else
                    {
                        btSiguiente.Visible = true;
                        btnGuardar.Visible = false;
                    }
                }
            }

            
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            tcGeneral.SelectedIndex -= 1;

            if (tcGeneral.SelectedIndex == 0)
            {
                btAtras.Visible = false;
            }
            else
            {
                btSiguiente.Visible = true;
            }
        }



        private void txtnodiasdesayuno_TextChanged(object sender, EventArgs e)
        {
            fechaSalida = dtpFechaSalida.Value.Date;
            fechaRegreso = dtpFechaRegreso.Value.Date;

            TimeSpan dias = fechaRegreso - fechaSalida;

            if (dias.Days == 0)
            {
                diasViaticos = 1;
            }
            else
            {
                diasViaticos = dias.Days + 1;
            }
            try
            {
                if (txtnodiasdesayuno.Text == "")
                {
                    txtnodiasdesayuno.Text = "0";
                    txtnodiasdesayuno.SelectAll();
                }
                else
                {
                    if (int.Parse(txtnodiasdesayuno.Text) > diasViaticos || int.Parse(txtnodiasalmuerzo.Text) > diasViaticos || int.Parse(txtnodiascena.Text) > diasViaticos)
                    {
                        MessageBox.Show("Lo siento no puede asignar mas tiempos de alimento\n porque exeden el tiempo de viaje", "Soporte Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnodiasdesayuno.Text = "0";
                        txtnodiasdesayuno.SelectAll();
                    } else
                    {
                        diasDesayuno = int.Parse(txtnodiasdesayuno.Text);
                        float subTotal = diasDesayuno * asignacionDesayuno;
                        txtsubdesayuno.Text = subTotal.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingreso demasiados digitos");
            }
        }

        private void txtasignaciondesayuno_TextChanged(object sender, EventArgs e)
        {
            if (txtasignaciondesayuno.Text == "")
            {
                txtasignaciondesayuno.Text = "0";
                txtasignaciondesayuno.SelectAll();
            }
            else
            {
                asignacionDesayuno = float.Parse(txtasignaciondesayuno.Text);
                float subTotal = diasDesayuno * asignacionDesayuno;
                txtsubdesayuno.Text = subTotal.ToString();
            }

        }

        private void txtsubdesayuno_TextChanged(object sender, EventArgs e)
        {
            if (txtsubdesayuno.Text == "")
            {
                txtsubdesayuno.Text = "0";
                txtsubdesayuno.SelectAll();
            }
            else
            {
                totaldesayuno = float.Parse(txtsubdesayuno.Text);
                float subTotal = totaldesayuno + totalalmuerzo + totalcena;
                txttotalali.Text = subTotal.ToString();
            }

        }

        private void txtsubalmuerzo_TextChanged(object sender, EventArgs e)
        {
            if (txtnodiasalmuerzo.Text == "")
            {
                txtnodiasalmuerzo.Text = "0";
                txtnodiasalmuerzo.SelectAll();
            }
            else
            {
                totalalmuerzo = float.Parse(txtsubalmuerzo.Text);
                float subTotal = totaldesayuno + totalalmuerzo + totalcena;
                txttotalali.Text = subTotal.ToString();
            }

        }

        private void txtsubcena_TextChanged(object sender, EventArgs e)
        {
            if (txtsubcena.Text == "")
            {
                txtsubcena.Text = "0";
                txtsubcena.SelectAll();
            }
            else
            {
                totalcena = float.Parse(txtsubcena.Text);
                float subTotal = totaldesayuno + totalalmuerzo + totalcena;
                txttotalali.Text = subTotal.ToString();
            }

        }

        private void txtnodiasalmuerzo_TextChanged(object sender, EventArgs e)
        {
            fechaSalida = dtpFechaSalida.Value.Date;
            fechaRegreso = dtpFechaRegreso.Value.Date;

            TimeSpan dias = fechaRegreso - fechaSalida;

            if (dias.Days == 0)
            {
                diasViaticos = 1;
            }
            else
            {
                diasViaticos = dias.Days + 1;
            }

            if (txtnodiasalmuerzo.Text == "")
            {
                txtnodiasalmuerzo.Text = "0";
                txtnodiasalmuerzo.SelectAll();
            }
            else
            {
                if (int.Parse(txtnodiasdesayuno.Text) > diasViaticos || int.Parse(txtnodiasalmuerzo.Text) > diasViaticos || int.Parse(txtnodiascena.Text) > diasViaticos)
                {
                    MessageBox.Show("Lo siento no puede asignar mas tiempos de alimento\n porque exeden el tiempo de viaje", "Soporte Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnodiasalmuerzo.Text = "0";
                    txtnodiasalmuerzo.SelectAll();
                }
                else
                {
                    diasAlmuerzo = int.Parse(txtnodiasalmuerzo.Text);
                    float subTotal = diasAlmuerzo * asignacionAlmuerzo;
                    txtsubalmuerzo.Text = subTotal.ToString();
                }
            }

        }

        private void txtasignacionalmuerzo_TextChanged(object sender, EventArgs e)
        {
            if (txtasignacionalmuerzo.Text == "")
            {
                txtasignacionalmuerzo.Text = "0";
                txtasignacionalmuerzo.SelectAll();
            }
            else
            {
                asignacionAlmuerzo = float.Parse(txtasignacionalmuerzo.Text);
                float subTotal = diasAlmuerzo * asignacionAlmuerzo;
                txtsubalmuerzo.Text = subTotal.ToString();
            }

        }

        private void txtnodiascena_TextChanged(object sender, EventArgs e)
        {
            fechaSalida = dtpFechaSalida.Value.Date;
            fechaRegreso = dtpFechaRegreso.Value.Date;

            TimeSpan dias = fechaRegreso - fechaSalida;

            if (dias.Days == 0)
            {
                diasViaticos = 1;
            }
            else
            {
                diasViaticos = dias.Days + 1;
            }

            if (txtnodiascena.Text == "")
            {
                txtnodiascena.Text = "0";
                txtnodiascena.SelectAll();
            }
            else
            {
                if (int.Parse(txtnodiasdesayuno.Text) > diasViaticos || int.Parse(txtnodiasalmuerzo.Text) > diasViaticos || int.Parse(txtnodiascena.Text) > diasViaticos)
                {
                    MessageBox.Show("Lo siento no puede asignar mas tiempos de alimento\n porque exeden el tiempo de viaje", "Soporte Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnodiascena.Text = "0";
                    txtnodiascena.SelectAll();
                }
                else
                {
                    diasCena = int.Parse(txtnodiascena.Text);
                    float subTotal = diasCena * asignacionCena;
                    txtsubcena.Text = subTotal.ToString();
                }
            }

        }

        private void txtasignacioncena_TextChanged(object sender, EventArgs e)
        {
            if (txtasignacioncena.Text == "")
            {
                txtasignacioncena.Text = "0";
                txtasignacioncena.SelectAll();
            }
            else
            {
                asignacionCena = float.Parse(txtasignacioncena.Text);
                float subTotal = diasCena * asignacionCena;
                txtsubcena.Text = subTotal.ToString();
            }

        }

        private void txttotalali_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnodiashosp_TextChanged(object sender, EventArgs e)
        {
            fechaSalida = dtpFechaSalida.Value.Date;
            fechaRegreso = dtpFechaRegreso.Value.Date;

            TimeSpan dias = fechaRegreso - fechaSalida;

            if (dias.Days == 0)
            {
                diasViaticos = 1;
            }
            else
            {
                diasViaticos = dias.Days + 1;
            }

            if (txtnodiashosp.Text == "")
            {
                txtnodiashosp.Text = "0";
                txtnodiashosp.SelectAll();
            }
            else
            {
                if (int.Parse(txtnodiashosp.Text) > diasViaticos)
                {
                    MessageBox.Show("Lo siento no puede asignar mas tiempos de alimento\n porque exeden el tiempo de viaje", "Soporte Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnodiashosp.Text = "0";
                    txtnodiashosp.SelectAll();
                }
                else
                {
                    diashosp = int.Parse(txtnodiashosp.Text);
                    float subTotal = diashosp * asignacionHosp;
                    txttotalhosp.Text = subTotal.ToString();
                }
                
            }
        }

        private void txtasignacionxdiahosp_TextChanged(object sender, EventArgs e)
        {
            if (txtasignacionxdiahosp.Text == "")
            {
                txtasignacionxdiahosp.Text = "0";
                txtasignacionxdiahosp.SelectAll();
            }
            else
            {
                asignacionHosp = float.Parse(txtasignacionxdiahosp.Text);
                float subTotal = diashosp * asignacionHosp;
                txttotalhosp.Text = subTotal.ToString();
            }
        }

        private void txtida_TextChanged(object sender, EventArgs e)
        {
            if (txtida.Text == "")
            {
                txtida.Text = "0";
                txtida.SelectAll();
            }
            else
            {
                ida = int.Parse(txtida.Text);
                float subTotal = ida + venida;
                txttotaltrans.Text = subTotal.ToString();
            }
        }

        private void txtvenida_TextChanged(object sender, EventArgs e)
        {
            if (txtvenida.Text == "")
            {
                txtvenida.Text = "0";
                txtvenida.SelectAll();
            }
            else
            {
                venida = int.Parse(txtvenida.Text);
                float subTotal = venida + ida;
                txttotaltrans.Text = subTotal.ToString();
            }
        }

        private void txtNodiasotro_TextChanged(object sender, EventArgs e)
        {
            if (txtNodiasotro.Text == "")
            {
                txtNodiasotro.Text = "0";
                txtNodiasotro.SelectAll();
            }
            else
            {
                diasOtro = int.Parse(txtNodiasotro.Text);
                float subTotal = diasOtro * asignacionOtro;
                txtTotalOtros.Text = subTotal.ToString();
            }
        }

        private void txtXdiaotros_TextChanged(object sender, EventArgs e)
        {
            if (txtXdiaotros.Text == "")
            {
                txtXdiaotros.Text = "0";
                txtXdiaotros.SelectAll();
            }
            else
            {
                asignacionOtro = float.Parse(txtXdiaotros.Text);
                float subTotal = diasOtro * asignacionOtro;
                txtTotalOtros.Text = subTotal.ToString();
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                const string message = "¿Esta seguro de guardar? \n Si lo hace no podra editar el registro";
                const string caption = "Tecnasa Honduras";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (txtnodiasdesayuno.Text == "0" & txtnodiasalmuerzo.Text == "0" & txtnodiascena.Text == "0" & txtasignaciondesayuno.Text == "0" & txtasignacionalmuerzo.Text == "0" & txtasignacioncena.Text == "0")
                    {
                        MessageBox.Show("Lo siento no puede guardar el registro \n con los campos de alimentacion vacios", "Soporte Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    } else {
                        reporte.InsertarAlimentacion(int.Parse(txtnodiasdesayuno.Text), float.Parse(txtasignaciondesayuno.Text), int.Parse(txtnodiasalmuerzo.Text), float.Parse(txtasignacionalmuerzo.Text), int.Parse(txtnodiascena.Text), float.Parse(txtasignacioncena.Text), int.Parse(txtsubdesayuno.Text), int.Parse(txtsubalmuerzo.Text), int.Parse(txtsubcena.Text),
                        int.Parse(cmbEmpleado.SelectedValue.ToString()));

                        reporte.InsertarHospedaje(int.Parse(txtnodiashosp.Text), float.Parse(txtasignacionxdiahosp.Text), int.Parse(cmbEmpleado.SelectedValue.ToString()));
                        reporte.InsertarTransporte(int.Parse(cmbtipotrans.SelectedValue.ToString()), float.Parse(txtida.Text), float.Parse(txtvenida.Text), int.Parse(cmbEmpleado.SelectedValue.ToString()));
                        reporte.InsertarOtros(int.Parse(txtNodiasotro.Text), float.Parse(txtXdiaotros.Text), rtbDescripcionOtros.Text, int.Parse(cmbEmpleado.SelectedValue.ToString()));
                        seleccionador();
                        MessageBox.Show("Datos guardados con exito");



                        reporte.InsertarViaticos(dtpFechaSalida.Value, dtpFechaRegreso.Value, int.Parse(cmbTransporte.SelectedValue.ToString()), int.Parse(cmbAlimentacion.SelectedValue.ToString()), int.Parse(cmbHospedaje.SelectedValue.ToString()), int.Parse(cmbOtros.SelectedValue.ToString()), int.Parse(cmbEmpleado.SelectedValue.ToString()));


                        btnGuardar.Visible = false;
                        btSiguiente.Visible = false;
                        btAtras.Visible = false;
                        this.Close();
                        frmViaticos frm = new frmViaticos();
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo siento error al guardar los datos");
            }
        }


        private void seleccionador()
        {
            Metodos metodos = new Metodos();
            metodos.ListarAlimentacion(cmbAlimentacion);
            metodos.ListarHospedaje(cmbHospedaje);
            metodos.ListarTransporte(cmbTransporte);
            metodos.ListarOtros(cmbOtros);
            alimentacion = cmbAlimentacion.Items.Count - 1;
            hospedaje = cmbHospedaje.Items.Count - 1;
            transporte = cmbTransporte.Items.Count - 1;
            otros = cmbOtros.Items.Count - 1;
            cmbAlimentacion.SelectedIndex = alimentacion;
            cmbHospedaje.SelectedIndex = hospedaje;
            cmbTransporte.SelectedIndex = transporte;
            cmbOtros.SelectedIndex = otros;
        }

        private void txtasignacioncena_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }
    }
}
