<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Proyecto1.Ejercicio1" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 1 - Masa de aire</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>1. Masa de aire</h3>
            <table>
                <tr><td>Ingrese la temperatura:</td><td><asp:TextBox ID="TxtTemperatura" runat="server"></asp:TextBox></td></tr>
                <tr><td>Ingrese el volumen:</td><td><asp:TextBox ID="TxtVolumen" runat="server"></asp:TextBox></td></tr>
                <tr><td>Ingrese la presión:</td><td><asp:TextBox ID="TxtPresion" runat="server"></asp:TextBox></td></tr>
            </table>
            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br /><br />
            <asp:Label ID="LblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>