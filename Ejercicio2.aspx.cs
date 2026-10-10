using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double edad;

            if (double.TryParse(TxtEdad.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out edad))
            {
                double pulsaciones = (220 - edad) / 10.0;
                LblResultado.Text = "Número de pulsaciones por cada 10 segundos: " + pulsaciones.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese una edad válida.";
            }
        }
    }
}