<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio12.aspx.cs" Inherits="Proyecto1.Ejercicio12" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 12 - Ahorro SAR</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>12. Ahorro para el retiro (SAR)</h3>
            <table>
                <tr>
                    <td>Salario mensual:</td>
                    <td><asp:TextBox ID="TxtSalarioSAR" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>% obligatorio de la empresa:</td>
                    <td><asp:TextBox ID="TxtPorcEmpresa" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>% aporte del trabajador:</td>
                    <td><asp:TextBox ID="TxtPorcTrabajador" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Cuota fija del trabajador (si aplica):</td>
                    <td><asp:TextBox ID="TxtCuotaFija" runat="server"></asp:TextBox></td>
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