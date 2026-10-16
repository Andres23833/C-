<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ciclos2.aspx.cs" Inherits="Proyecto1.ciclos2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 2 - Naranjas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Expendio de Naranjas (15 Clientes)</h3>
            
            Precio por kilo: 
            <asp:TextBox ID="TxtPrecioKilo" runat="server"></asp:TextBox>
            <br /><br />

            Kilos comprados por los 15 clientes (separados por comas):<br />
            <asp:TextBox ID="TxtKilosClientes" runat="server" TextMode="MultiLine" Rows="4" Columns="50"></asp:TextBox>
            <br /><br />

            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br /><br />

            <asp:Label ID="LblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>