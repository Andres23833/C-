<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ciclos5.aspx.cs" Inherits="Proyecto1.ciclos5" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 5 - Zoológico</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Estudio de Edades en el Zoológico</h2>
            
            Seleccione el tipo de animal: 
            <asp:DropDownList ID="DdlAnimal" runat="server">
                <asp:ListItem Text="Elefantes (20 muestras)" Value="elefantes" />
                <asp:ListItem Text="Jirafas (15 muestras)" Value="jirafas" />
                <asp:ListItem Text="Chimpancés (40 muestras)" Value="chimpances" />
            </asp:DropDownList>
            <br /><br />

            Ingrese las edades de las muestras (separadas por comas):<br />
            <asp:TextBox ID="TxtEdades" runat="server" TextMode="MultiLine" Rows="4" Columns="50"></asp:TextBox>
            <br /><br />

            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
            <br /><br />

            <asp:Label ID="LblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>