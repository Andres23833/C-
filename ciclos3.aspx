<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ciclos3.aspx.cs" Inherits="Proyecto1.ciclos3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 3 - Verificación de Automóviles</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Centro de Verificación de Automóviles (25 Autos)</h2>
            
            Ingrese los puntos contaminantes de los 25 automóviles (separados por comas):<br />
            <asp:TextBox ID="TxtPuntosAutos" runat="server" TextMode="MultiLine" Rows="4" Columns="50"></asp:TextBox>
            <br /><br />

            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br /><br />

            <asp:Label ID="LblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>