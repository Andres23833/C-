using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double salarioAnterior;

            if (double.TryParse(TxtSalarioAnterior.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out salarioAnterior))
            {
                double nuevoSalario = salarioAnterior * 1.25;
                LblResultado.Text = "El nuevo salario con el 25% de incremento es: $" + nuevoSalario.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese un monto de salario válido.";
            }
        }
    }
}