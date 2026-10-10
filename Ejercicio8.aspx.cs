using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double matEx, matT1, matT2, matT3;
            double fisEx, fisT1, fisT2;
            double quiEx, quiT1, quiT2, quiT3;

            if (double.TryParse(TxtMatExamen.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out matEx) &&
                double.TryParse(TxtMatTarea1.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out matT1) &&
                double.TryParse(TxtMatTarea2.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out matT2) &&
                double.TryParse(TxtMatTarea3.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out matT3) &&
                double.TryParse(TxtFisExamen.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out fisEx) &&
                double.TryParse(TxtFisTarea1.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out fisT1) &&
                double.TryParse(TxtFisTarea2.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out fisT2) &&
                double.TryParse(TxtQuiExamen.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out quiEx) &&
                double.TryParse(TxtQuiTarea1.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out quiT1) &&
                double.TryParse(TxtQuiTarea2.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out quiT2) &&
                double.TryParse(TxtQuiTarea3.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out quiT3))
            {
                // Promedio Matemáticas (90% examen + 10% promedio de 3 tareas)
                double promMat = (matEx * 0.90) + (((matT1 + matT2 + matT3) / 3.0) * 0.10);

                // Promedio Física (80% examen + 20% promedio de 2 tareas)
                double promFis = (fisEx * 0.80) + (((fisT1 + fisT2) / 2.0) * 0.20);

                // Promedio Química (85% examen + 15% promedio de 3 tareas)
                double promQui = (quiEx * 0.85) + (((quiT1 + quiT2 + quiT3) / 3.0) * 0.15);

                LblResultado.Text = "Promedios finales:<br />" +
                                    "Matemáticas: " + promMat.ToString("F2", CultureInfo.InvariantCulture) + "<br />" +
                                    "Física: " + promFis.ToString("F2", CultureInfo.InvariantCulture) + "<br />" +
                                    "Química: " + promQui.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese notas numéricas válidas en todos los campos.";
            }
        }
    }
}