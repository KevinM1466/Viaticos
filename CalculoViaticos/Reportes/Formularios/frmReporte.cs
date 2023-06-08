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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }
        public DateTime Fecha { get; set; }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            this.reporte_Empleado_Mas_GastosTableAdapter.Fill(this.dataSet1.Reporte_Empleado_Mas_Gastos, Fecha);
            this.reportViewer1.RefreshReport();
        }
    }
}
