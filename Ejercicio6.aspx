<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio6.aspx.cs" Inherits="Proyecto1.Ejercicio6" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 6 - Tiempo Promedio</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>6. Tiempo promedio de la ruta (minutos)</h3>
            <table>
                <tr>
                    <td>Tiempo del lunes (min):</td>
                    <td><asp:TextBox ID="TxtLunes" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tiempo del miércoles (min):</td>
                    <td><asp:TextBox ID="TxtMiercoles" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tiempo del viernes (min):</td>
                    <td><asp:TextBox ID="TxtViernes" runat="server"></asp:TextBox></td>
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