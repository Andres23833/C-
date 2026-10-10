using System;
using System.Globalization;

namespace Proyecto1
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double precioCompra;

            if (double.TryParse(TxtPrecioCompra.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out precioCompra))
            {
                double precioVenta = precioCompra * 1.30;
                LblResultado.Text = "El precio de venta para obtener un 30% de ganancia es: $" + precioVenta.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese un precio de compra válido.";
            }
        }
    }
}