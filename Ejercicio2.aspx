<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Proyecto1.Ejercicio2" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 2 - Pulsaciones</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>2. Pulsaciones por cada 10 segundos</h3>
            <table>
                <tr>
                    <td>Ingrese la edad:</td>
                    <td><asp:TextBox ID="TxtEdad" runat="server"></asp:TextBox></td>
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