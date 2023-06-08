using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalculoViaticos.Clases
{
    public class Validaciones
    {
        public bool vacio = true;
        public bool resultado = true;
        public void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ValidarCamposVacios(Form formulario)
        {

            foreach (Control controles in formulario.Controls) //Busco el control
            {
                if (controles is TextBox & controles.Text == String.Empty) //Si esta vacio
                {
                    vacio = false;
                    resultado = false;
                    //error.SetError(controles, "Por favor debe de llenar este campo");
                    MessageBox.Show("no se puede");
                }
                else if (controles is TextBox & controles.Text != String.Empty) //Si no esta vacio
                {
                    vacio = true;
                    resultado = true;
                    //error.SetError(controles, "");
                    MessageBox.Show("no se puede");
                }
            }

            return resultado;
        }
    }
}
