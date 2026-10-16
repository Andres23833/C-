using System;
using System.Globalization;
using System.Linq;
using System.Web.UI;

namespace Proyecto1
{
    public partial class ciclos2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double precioKilo;
            if (!double.TryParse(TxtPrecioKilo.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out precioKilo))
            {
                LblResultado.Text = "Ingrese un precio por kilo válido.";
                return;
            }

            string[] arrayKilos = TxtKilosClientes.Text.Split(',');
            if (arrayKilos.Length < 15)
            {
                LblResultado.Text = "Por favor, ingrese los kilos de los 15 clientes separados por comas.";
                return;
            }

            double totalTienda = 0;
            string detalleHtml = "<h3>Detalle de cobro:</h3><ul>";

            for (int i = 0; i < 15; i++)
            {
                double kilos;
                if (double.TryParse(arrayKilos[i].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out kilos))
                {
                    double subtotal = kilos * precioKilo;
                    double totalPagar = subtotal;

                    if (kilos > 10)
                    {
                        totalPagar = subtotal * 0.85;
                    }

                    totalTienda += totalPagar;
                    detalleHtml += $"<li>Cliente {i + 1}: {kilos} kg - Paga: ${totalPagar.ToString("F2", CultureInfo.InvariantCulture)}</li>";
                }
            }

            detalleHtml += "</ul>";
            detalleHtml += $"<br /><strong>Total percibido por la tienda: ${totalTienda.ToString("F2", CultureInfo.InvariantCulture)}</strong>";

            LblResultado.Text = detalleHtml;
        }
    }
}