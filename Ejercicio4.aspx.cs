using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double presupuesto;

            if (double.TryParse(TxtPresupuesto.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out presupuesto))
            {
                double ginecologia = presupuesto * 0.40;
                double traumatologia = presupuesto * 0.30;
                double pediatria = presupuesto * 0.30;

                LblResultado.Text = "Ginecología (40%): $" + ginecologia.ToString("F2", CultureInfo.InvariantCulture) +
                                    "<br />Traumatología (30%): $" + traumatologia.ToString("F2", CultureInfo.InvariantCulture) +
                                    "<br />Pediatría (30%): $" + pediatria.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese un presupuesto válido.";
            }
        }
    }
}