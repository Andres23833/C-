using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double inv1, inv2, inv3;

            if (double.TryParse(TxtInversion1.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out inv1) &&
                double.TryParse(TxtInversion2.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out inv2) &&
                double.TryParse(TxtInversion3.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out inv3))
            {
                double total = inv1 + inv2 + inv3;
                if (total == 0)
                {
                    LblResultado.Text = "La inversión total no puede ser cero.";
                    return;
                }

                double p1 = (inv1 / total) * 100;
                double p2 = (inv2 / total) * 100;
                double p3 = (inv3 / total) * 100;

                LblResultado.Text = "Porcentajes de inversión:<br />" +
                                    "Persona 1: " + p1.ToString("F2", CultureInfo.InvariantCulture) + "%<br />" +
                                    "Persona 2: " + p2.ToString("F2", CultureInfo.InvariantCulture) + "%<br />" +
                                    "Persona 3: " + p3.ToString("F2", CultureInfo.InvariantCulture) + "%";
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese valores numéricos válidos en todas las inversiones.";
            }
        }
    }
}