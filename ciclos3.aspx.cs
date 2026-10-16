using System;
using System.Globalization;
using System.Linq;
using System.Web.UI;

namespace Proyecto1
{
    public partial class ciclos3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            string[] arrayPuntos = TxtPuntosAutos.Text.Split(',');
            if (arrayPuntos.Length < 25)
            {
                LblResultado.Text = "Por favor, ingrese los puntos de los 25 automóviles separados por comas.";
                return;
            }

            double sumaPuntos = 0;
            double menorContaminacion = double.MaxValue;
            double mayorContaminacion = double.MinValue;
            int autosValidos = 0;

            for (int i = 0; i < 25; i++)
            {
                double puntos;
                if (double.TryParse(arrayPuntos[i].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out puntos))
                {
                    sumaPuntos += puntos;
                    if (puntos < menorContaminacion) menorContaminacion = puntos;
                    if (puntos > mayorContaminacion) mayorContaminacion = puntos;
                    autosValidos++;
                }
            }

            if (autosValidos > 0)
            {
                double promedio = sumaPuntos / autosValidos;
                LblResultado.Text = $"Promedio de puntos contaminantes: {promedio.ToString("F2", CultureInfo.InvariantCulture)}<br />" +
                                   $"Carro que menos contaminó: {menorContaminacion}<br />" +
                                   $"Carro que más contaminó: {mayorContaminacion}";
            }
            else
            {
                LblResultado.Text = "No se ingresaron valores válidos.";
            }
        }
    }
}