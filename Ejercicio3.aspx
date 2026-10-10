<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="Proyecto1.Ejercicio3" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 3 - Nuevo Salario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>3. Nuevo salario (incremento del 25%)</h3>
            <table>
                <tr>
                    <td>Ingrese el salario anterior:</td>
                    <td><asp:TextBox ID="TxtSalarioAnterior" runat="server"></asp:TextBox></td>
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