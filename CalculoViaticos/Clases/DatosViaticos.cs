using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoViaticos.Clases
{
    public class DatosViaticos
    {
        public int Idempleado { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int codigo { get; set; }
        public string fechaSalida { get; set; }
        public string fechaRegreso { get; set; }
        public float subTotalDesayuno { get; set; }
        public float subTotalAlmuerzo { get; set; }
        public float subTotalCena { get; set; }
        public float Total { get; set; }
        public int nodiasdesayuno { get; set; }
        public float asignaciondesayuno { get; set; }
        public int nodiasalmuerzo { get; set; }
        public float asignacionalmuerzo { get; set; }
        public int nodiascena { get; set; }
        public float asignacioncena { get; set; }
        public int nodiashosp { get; set; }
        public float asignacionxdiahosp { get; set; }
        public float ida { get; set; }
        public float regreso { get; set; }
        public int nodiasotros { get; set; }
    }
}
