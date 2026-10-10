using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double costoCasa, ingresos;

            if (double.TryParse(TxtCostoCasa.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out costoCasa) &&
                double.TryParse(TxtIngresos.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out ingresos))
            {
                double cuotaInicial, resto;

                if (ingresos < 800000)
                {
                    cuotaInicial = costoCasa * 0.15;
                    resto = costoCasa - cuotaInicial;
                    LblResultado.Text = "Ingresos menores a $800,000 (Aplica 15% cuota inicial y 10 años de plazo).<br />" +
                                        "Cuota inicial: $" + cuotaInicial.ToString("F2", CultureInfo.InvariantCulture) + "<br />" +
                                        "Resto a financiar: $" + resto.ToString("F2", CultureInfo.InvariantCulture);
                }
                else
                {
                    cuotaInicial = costoCasa * 0.30;
                    resto = costoCasa - cuotaInicial;
                    LblResultado.Text = "Ingresos de $800,000 o más (Aplica 30% cuota inicial y 7 años de plazo).<br />" +
                                        "Cuota inicial: $" + cuotaInicial.ToString("F2", CultureInfo.InvariantCulture) + "<br />" +
                                        "Resto a financiar: $" + resto.ToString("F2", CultureInfo.InvariantCulture);
                }
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese valores numéricos válidos en los campos.";
            }
        }
    }
}