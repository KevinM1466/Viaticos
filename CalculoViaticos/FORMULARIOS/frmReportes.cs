using CalculoViaticos.Reportes.Formularios;
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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            frmReporte frm = new frmReporte();
            frm.Fecha = dtpFecha.Value;
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmReporteMasViajes frm = new frmReporteMasViajes();
            frm.Fecha = dtpFecha.Value;
            frm.ShowDialog();
        }
    }
}
