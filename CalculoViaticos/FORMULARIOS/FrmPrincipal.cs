using CalculoViaticos.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoViaticos
{
    public partial class FrmPrincipal : Form
    {
        private bool dragging = false;
        private Form currentChildForm;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            Cursor.Current = Cursors.Hand;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Left + e.X, this.Top + e.Y);
            }
        }

        private void panelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            Cursor.Current = Cursors.Default;
        }

        private void panelBarraTitulo2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            Cursor.Current = Cursors.Hand;
        }

        private void panelBarraTitulo2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Left + e.X, this.Top + e.Y);
            }
        }

        private void panelBarraTitulo2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            Cursor.Current = Cursors.Default;
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; // Restaurar el formulario si está maximizado
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; // Maximizar el formulario si no está maximizado
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizar el formulario
        }

        private void panelBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = currentBtn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGeneral());
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEmpleados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportes());
        }

        private void btnViaticos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViaticos());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
        }
    }
}
