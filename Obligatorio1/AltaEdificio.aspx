<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaEdificio.aspx.cs" Inherits="Obligatorio1.AltaEdificio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nombre: <asp:TextBox ID="txtNombreEdificio" runat="server"></asp:TextBox>
        <br />
        Direccion: <asp:TextBox ID="txtDireccionEdificio" runat="server"></asp:TextBox>
        <br />
        <%--Ver como agregar el apartamento--%>
        <asp:Button ID="btnAltaEdificio" runat="server" Text="Agregar nuevo edificio" OnClick="btnAltaEdificio_Click" />
        <hr />
        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
