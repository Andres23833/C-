<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio10.aspx.cs" Inherits="Proyecto1.Ejercicio10" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 10 - Colegiatura</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>10. Colegiatura del alumno</h3>
            <table>
                <tr>
                    <td>Número de materias cursadas:</td>
                    <td><asp:TextBox ID="TxtMaterias" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Costo por cada materia:</td>
                    <td><asp:TextBox ID="TxtCostoMateria" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Promedio del último periodo:</td>
                    <td><asp:TextBox ID="TxtPromedioAlumno" runat="server"></asp:TextBox></td>
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