using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double monto;

            if (double.TryParse(TxtMontoFianza.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out monto))
            {
                double cuota = monto * 0.05;
                LblResultado.Text = "La cuota a pagar por la fianza (5%) es: $" + cuota.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese un monto de fianza válido.";
            }
        }
    }
}