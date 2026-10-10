using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double temperatura, volumen, presion;

            if (double.TryParse(TxtTemperatura.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out temperatura) &&
                double.TryParse(TxtVolumen.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out volumen) &&
                double.TryParse(TxtPresion.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out presion))
            {
                double denominador = 0.37 * (temperatura + 460);
                if (denominador == 0)
                {
                    LblResultado.Text = "Error: El denominador no puede ser cero.";
                    return;
                }

                double masa = (presion * volumen) / denominador;
                LblResultado.Text = "Masa de aire calculada: " + masa.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }
    }
}