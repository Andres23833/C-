<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ciclos4.aspx.cs" Inherits="Proyecto1.ciclos4" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 4 - Evaluación de Atleta</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Evaluación de Tiempos de Atleta (10 Días)</h2>
            
            Ingrese los tiempos en minutos de las 10 pruebas (separados por comas):<br />
            <asp:TextBox ID="TxtTiempos" runat="server" TextMode="MultiLine" Rows="3" Columns="50"></asp:TextBox>
            <br /><br />

            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br /><br />

            <asp:Label ID="LblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>