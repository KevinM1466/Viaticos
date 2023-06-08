using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoViaticos.Reportes.Formularios
{
    public partial class frmReporteMasViajes : Form
    {
        public frmReporteMasViajes()
        {
            InitializeComponent();
        }
        public DateTime Fecha { get; set; }

        private void frmReporteMasViajes_Load(object sender, EventArgs e)
        {
            this.reporte_Empleado_Mas_ViajesTableAdapter.Fill(this.dataSet1.Reporte_Empleado_Mas_Viajes, Fecha);
            this.reportViewer1.RefreshReport();
        }
    }
}
