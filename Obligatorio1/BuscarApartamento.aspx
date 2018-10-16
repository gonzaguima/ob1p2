<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarApartamento.aspx.cs" Inherits="Obligatorio1.BuscarApartamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            width: 63px;
        }
        .auto-style4 {
            text-decoration: underline;
        }
        .auto-style5 {
            width: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Listado de apartamentos</h1>
        <h2 class="auto-style4">Buscar por rango de precios</h2>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Buscar apartamentos</td>
                <td class="auto-style3">Desde $:</td>
                <td>
                    <%-- input menor precio--%>
                    <asp:TextBox ID="txtMenorPrecio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">Hasta $:</td>
                <td>
                    <%--input mayor precio--%>
                    <asp:TextBox ID="txtMayorPrecio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <%--boton buscar--%>
                    <asp:Button ID="btnBuscarAptoPrecio" runat="server" Text="Buscar" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style">Resultado:</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style">
                    <%--Lista apartamentos--%>
                    <asp:DropDownList ID="ddlAptoPrecio" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        
        <h2 class="auto-style4">Buscar si existe en rango de metraje</h2>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Buscar apartamentos</td>
                <td class="auto-style5">Desde m<sup>2</sup>:</td>
                <td>
                    <%-- input menor metraje--%>
                    <asp:TextBox ID="txtMenorMetraje" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">Hasta m<sup>2</sup>:</td>
                <td>
                    <%--input mayor metraje--%>
                    <asp:TextBox ID="txtMayorMetraje" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <%--boton buscar--%>
                    <asp:Button ID="btnBuscarAptoMetraje" runat="server" Text="Buscar" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style">Resultado:</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style">
                    <%--Lista apartamentos--%>
                    <asp:DropDownList ID="ddlAptoMetraje" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>

        <br /><hr />
        <%--link volver inicio--%>
        <asp:HyperLink runat="server" NavigateUrl="~/index.aspx">Volver al inicio</asp:HyperLink>
    </div>
    </form>
</body>
</html>
