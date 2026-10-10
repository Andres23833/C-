using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double materias, costoMateria, promedio;

            if (double.TryParse(TxtMaterias.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out materias) &&
                double.TryParse(TxtCostoMateria.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out costoMateria) &&
                double.TryParse(TxtPromedioAlumno.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out promedio))
            {
                double total = materias * costoMateria;

                if (promedio >= 9.0)
                {
                    double descuento = total * 0.30;
                    total -= descuento;
                    LblResultado.Text = "¡Excelente promedio! Aplica 30% de descuento.<br />Total a pagar: $" + total.ToString("F2", CultureInfo.InvariantCulture);
                }
                else
                {
                    double recargo = total * 0.10;
                    total += recargo;
                    LblResultado.Text = "Promedio menor a 9.0. Aplica 10% de recargo general.<br />Total a pagar: $" + total.ToString("F2", CultureInfo.InvariantCulture);
                }
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese valores numéricos válidos en todos los campos.";
            }
        }
    }
}