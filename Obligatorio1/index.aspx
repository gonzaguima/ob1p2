<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Obligatorio1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink runat="server" NavigateUrl="~/AltaEdificio.aspx">Ingresar edificio</asp:HyperLink><br />
        <asp:HyperLink runat="server" NavigateUrl="~/AltaApartamento.aspx">Ingresar apartamento</asp:HyperLink><br />
        <asp:HyperLink runat="server" NavigateUrl="~/BuscarEdificio.aspx">Buscar edificio</asp:HyperLink><br />
        <asp:HyperLink runat="server" NavigateUrl="~/BuscarApartamento.aspx">Buscar apartamento</asp:HyperLink>
    </div>
    </form>
</body>
</html>
