<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4.aspx.cs" Inherits="Proyecto1.Ejercicio4" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 4 - Presupuesto Hospital</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>4. Distribución del Presupuesto Anual del Hospital</h3>
            <table>
                <tr>
                    <td>Ingrese el presupuesto total:</td>
                    <td><asp:TextBox ID="TxtPresupuesto" runat="server"></asp:TextBox></td>
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