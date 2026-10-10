<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio9.aspx.cs" Inherits="Proyecto1.Ejercicio9" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 9 - Cuota de la fianza</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>9. Cuota de la fianza (5% del monto)</h3>
            <table>
                <tr>
                    <td>Ingrese el monto de la fianza:</td>
                    <td><asp:TextBox ID="TxtMontoFianza" runat="server"></asp:TextBox></td>
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