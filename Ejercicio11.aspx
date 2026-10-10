<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio11.aspx.cs" Inherits="Proyecto1.Ejercicio11" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 11 - Compra de Casa</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>11. Compra de casa de interés social</h3>
            <table>
                <tr>
                    <td>Costo de la casa:</td>
                    <td><asp:TextBox ID="TxtCostoCasa" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ingresos del comprador:</td>
                    <td><asp:TextBox ID="TxtIngresos" runat="server"></asp:TextBox></td>
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