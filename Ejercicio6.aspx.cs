using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double lunes, miercoles, viernes;

            if (double.TryParse(TxtLunes.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out lunes) &&
                double.TryParse(TxtMiercoles.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out miercoles) &&
                double.TryParse(TxtViernes.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out viernes))
            {
                double promedio = (lunes + miercoles + viernes) / 3.0;
                LblResultado.Text = "El tiempo promedio que toma la ruta es: " + promedio.ToString("F2", CultureInfo.InvariantCulture) + " minutos.";
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese valores numéricos válidos en todos los campos.";
            }
        }
    }
}