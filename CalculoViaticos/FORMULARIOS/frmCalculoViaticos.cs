using CalculoViaticos.Clases;
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
    public partial class frmCalculoViaticos : Form
    {
        public List<DatosViaticos> datosViaticos = new List<DatosViaticos>();
        public frmCalculoViaticos()
        {
            InitializeComponent();
        }

        private void frmCalculoViaticos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", datosViaticos));
            this.reportViewer1.RefreshReport();
        }
    }
}
