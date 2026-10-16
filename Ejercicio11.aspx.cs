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

                if (ingresos <= 8000)
                {
                    cuotaInicial = costoCasa * 0.15;
                    resto = costoCasa - cuotaInicial;
                    LblResultado.Text = "Ingresos menores a $8000 (se aplica 15% cuota inicial y 10 años de plazo).<br />" +
                                        "Cuota inicial: $" + cuotaInicial.ToString( CultureInfo.InvariantCulture) + "<br />" +
                                        "Resto a financiar: $" + resto.ToString( CultureInfo.InvariantCulture);
                }
                else
                {
                    cuotaInicial = costoCasa * 0.30;
                    resto = costoCasa - cuotaInicial;
                    LblResultado.Text = "Ingresos de $8000 o más (se aplica 30% cuota inicial y 7 años de plazo).<br />" +
                                        "Cuota inicial: $" + cuotaInicial.ToString( CultureInfo.InvariantCulture) + "<br />" +
                                        "Resto a financiar: $" + resto.ToString( CultureInfo.InvariantCulture);
                }
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese valores numéricos válidos en los campos.";
            }
        }
    }
}