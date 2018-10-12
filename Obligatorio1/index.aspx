<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Obligatorio1.index" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 38%;
        }
        .auto-style2 {
            width: 310px;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            width: 310px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Constructora BOB</h1>
        <h2 class="auto-style3">Formulario de venta de apartamentos</h2><br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Venta de apartamento en nuevo Edificio</td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AltaEdificio.aspx">Alta Edificio</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Venta de apartamento en Edificio existente</td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AltaApartamento.aspx">Alta Apartamento</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Listado Edificios por Metraje y Orientación</td>
                <td>
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/BuscarEdificios.aspx">Buscar Edificios</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Listado Apartamentos por rango de Precios o Existencia por metraje</td>
                <td>
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/BuscarApartamento.aspx">Buscar Apartamentos</asp:HyperLink>
                </td>
            </tr>
         
        </table>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
