<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="Proyecto1.Ejercicio5" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 5 - Precio de Venta</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>5. Precio de venta (ganancia del 30%)</h3>
            <table>
                <tr>
                    <td>Ingrese el precio de compra:</td>
                    <td><asp:TextBox ID="TxtPrecioCompra" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br /><br />
            <asp:Label ID="LblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>