<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio8.aspx.cs" Inherits="Proyecto1.Ejercicio8" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 8 - Promedios Materias</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>8. Promedio en Matemáticas, Física y Química</h3>
            <table>
                <tr><td>Matemáticas - Examen:</td><td><asp:TextBox ID="TxtMatExamen" runat="server"></asp:TextBox></td></tr>
                <tr><td>Matemáticas - Tarea 1:</td><td><asp:TextBox ID="TxtMatTarea1" runat="server"></asp:TextBox></td></tr>
                <tr><td>Matemáticas - Tarea 2:</td><td><asp:TextBox ID="TxtMatTarea2" runat="server"></asp:TextBox></td></tr>
                <tr><td>Matemáticas - Tarea 3:</td><td><asp:TextBox ID="TxtMatTarea3" runat="server"></asp:TextBox></td></tr>
                <tr><td>Física - Examen:</td><td><asp:TextBox ID="TxtFisExamen" runat="server"></asp:TextBox></td></tr>
                <tr><td>Física - Tarea 1:</td><td><asp:TextBox ID="TxtFisTarea1" runat="server"></asp:TextBox></td></tr>
                <tr><td>Física - Tarea 2:</td><td><asp:TextBox ID="TxtFisTarea2" runat="server"></asp:TextBox></td></tr>
                <tr><td>Química - Examen:</td><td><asp:TextBox ID="TxtQuiExamen" runat="server"></asp:TextBox></td></tr>
                <tr><td>Química - Tarea 1:</td><td><asp:TextBox ID="TxtQuiTarea1" runat="server"></asp:TextBox></td></tr>
                <tr><td>Química - Tarea 2:</td><td><asp:TextBox ID="TxtQuiTarea2" runat="server"></asp:TextBox></td></tr>
                <tr><td>Química - Tarea 3:</td><td><asp:TextBox ID="TxtQuiTarea3" runat="server"></asp:TextBox></td></tr>
            </table>
            <br />
            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br /><br />
            <asp:Label ID="LblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>