using System;
using System.Globalization;
using System.Web.UI;

namespace Proyecto1
{
    public partial class ciclos4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            string[] arrayTiempos = TxtTiempos.Text.Split(',');
            if (arrayTiempos.Length < 10)
            {
                LblResultado.Text = "Por favor, ingrese los 10 tiempos separados por comas.";
                return;
            }

            double sumaTiempos = 0;
            bool algunMayor16 = false;
            bool todosMenorOIgual16 = true;

            for (int i = 0; i < 10; i++)
            {
                double tiempo;
                if (double.TryParse(arrayTiempos[i].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out tiempo))
                {
                    sumaTiempos += tiempo;
                    if (tiempo > 16) algunMayor16 = true;
                    if (tiempo > 16) todosMenorOIgual16 = false;
                }
            }

            double promedio = sumaTiempos / 10;
            bool condicion1 = todosMenorOIgual16;
            bool condicion2 = algunMayor16;
            bool condicion3 = promedio <= 15;

            
            bool esApto = condicion1 || condicion2 || condicion3;

            string mensajeStatus = esApto ? "<strong style='color:green;'>EL ATLETA ES APTO</strong>" : "<strong style='color:red;'>EL ATLETA NO ES APTO (Debe buscar otra especialidad)</strong>";

            LblResultado.Text = $"Promedio de tiempos: {promedio.ToString("F2", CultureInfo.InvariantCulture)} minutos.<br />" +
                               $"Resultado: {mensajeStatus}";
        }
    }
}