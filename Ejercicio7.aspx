<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio7.aspx.cs" Inherits="Proyecto1.Ejercicio7" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 7 - Porcentaje de Inversión</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>7. Porcentaje de inversión de tres personas</h3>
            <table>
                <tr>
                    <td>Inversión persona 1:</td>
                    <td><asp:TextBox ID="TxtInversion1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Inversión persona 2:</td>
                    <td><asp:TextBox ID="TxtInversion2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Inversión persona 3:</td>
                    <td><asp:TextBox ID="TxtInversion3" runat="server"></asp:TextBox></td>
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