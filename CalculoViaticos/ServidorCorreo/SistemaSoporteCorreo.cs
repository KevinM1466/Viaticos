using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoViaticos.ServidorCorreo
{
    class SistemaSoporteCorreo:ServidorCorreoM
    {
        public SistemaSoporteCorreo()
        {
            senderMail = "soportetecnasa7@gmail.com";
            password = "iuoptpladavsbyfm";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
