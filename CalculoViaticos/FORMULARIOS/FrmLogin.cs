using CalculoViaticos.ConexionSql;
using CalculoViaticos.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CalculoViaticos.FORMULARIOS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContrasenia.Text != "")
                {
                    InicioSesion user = new InicioSesion();
                    var validLogin = user.Login(txtUsuario.Text, txtContrasenia.Text);
                    if (validLogin == true)
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        frmPrincipal.Show();
                        frmPrincipal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Correo o Contraseña incorrectos");
                        txtUsuario.Focus();
                        txtContrasenia.Clear();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese su contraseña");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese su correo");
            }
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            this.Show();
            txtUsuario.Focus();
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperarContra = new frmRecuperarContra();
            recuperarContra.ShowDialog();
        }
    }
}
