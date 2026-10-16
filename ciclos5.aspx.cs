using System;
using System.Globalization;
using System.Web.UI;

namespace Proyecto1
{
    public partial class ciclos5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            string animal = DdlAnimal.SelectedValue;
            int requeridos = 0;

            if (animal == "elefantes") requeridos = 20;
            else if (animal == "jirafas") requeridos = 15;
            else if (animal == "chimpances") requeridos = 40;

            string[] arrayEdades = TxtEdades.Text.Split(',');
            if (arrayEdades.Length < requeridos)
            {
                LblResultado.Text = $"Por favor, ingrese al menos {requeridos} edades para el tipo de animal seleccionado.";
                return;
            }

            int cat1 = 0; 
            int cat2 = 0; 
            int cat3 = 0; 

            for (int i = 0; i < requeridos; i++)
            {
                double edad;
                if (double.TryParse(arrayEdades[i].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out edad))
                {
                    if (edad >= 0 && edad <= 1) cat1++;
                    else if (edad > 1 && edad < 3) cat2++;
                    else if (edad >= 3) cat3++;
                }
            }

            double porc1 = ((double)cat1 / requeridos) * 100;
            double porc2 = ((double)cat2 / requeridos) * 100;
            double porc3 = ((double)cat3 / requeridos) * 100;

            LblResultado.Text = $"<strong>Resultados para {animal.ToUpper()} (Total muestra: {requeridos}):</strong><br />" +
                               $"- Categoría 0 a 1 año: {porc1.ToString("F2", CultureInfo.InvariantCulture)}%<br />" +
                               $"- Categoría más de 1 y menos de 3 años: {porc2.ToString("F2", CultureInfo.InvariantCulture)}%<br />" +
                               $"- Categoría 3 o más años: {porc3.ToString("F2", CultureInfo.InvariantCulture)}%";
        }
    }
}