using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double salario, porcEmpresa, porcTrabajador, cuotaFija;

            if (double.TryParse(TxtSalarioSAR.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out salario) &&
                double.TryParse(TxtPorcEmpresa.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out porcEmpresa) &&
                double.TryParse(TxtPorcTrabajador.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out porcTrabajador) &&
                double.TryParse(TxtCuotaFija.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out cuotaFija))
            {
                double aporteEmpresa = salario * (porcEmpresa / 100.0);
                double aporteTrabajador = (salario * (porcTrabajador / 100.0)) + cuotaFija;
                double totalMensual = aporteEmpresa + aporteTrabajador;

                LblResultado.Text = "Desglose del Ahorro SAR:<br />" +
                                    "Aporte de la empresa: $" + aporteEmpresa.ToString("F2", CultureInfo.InvariantCulture) + "<br />" +
                                    "Aporte del trabajador: $" + aporteTrabajador.ToString("F2", CultureInfo.InvariantCulture) + "<br />" +
                                    "Total mensual aportado: $" + totalMensual.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese valores numéricos válidos en todos los campos.";
            }
        }
    }
}