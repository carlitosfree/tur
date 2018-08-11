using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Aplicaciones_En_Ambientes_Porpietarios
{
    class ValidarSoloLetrasSoloNumeros
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false; // escribe

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; // no la escribe
                    MessageBox.Show("No se admite datos numéricos");
                }

            }
            catch (Exception)
            {
            }
        }


        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false; // escribe

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; // no la escribe
                    MessageBox.Show("Solo se admite datos numéricos");
                }

            }
            catch (Exception)
            {

            }

        }

        public void NumerosDecimal(KeyPressEventArgs V)
        {
            try
            {
                if (Char.IsDigit(V.KeyChar) || Char.IsPunctuation(V.KeyChar))
                {
                    V.Handled = false; // escribe

                }
                else if (Char.IsSeparator(V.KeyChar))
                {
                    V.Handled = false;
                }
                else if (Char.IsControl(V.KeyChar))
                {
                    V.Handled = false;
                }
                else
                {
                    V.Handled = true;// no la escribe
                    MessageBox.Show("Solo se admite enteros y decimales");
                }

            }
            catch (Exception)
            {

            }

        }

        public bool VerificarCedula(string ced)
        {

            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;
            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                                    Convert.ToInt32(ced[k] + string.Empty);

                        total = valor >= 10 ? total + (valor - 9) : total + valor;

                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;

                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }

            }

            return false;

        }
        public bool verificarRuc(string ruc)
        {
            return true;
        }

        public bool validarEmail(string email)

        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }

    }
}
