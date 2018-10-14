<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarEdificios.aspx.cs" Inherits="Obligatorio1.BuscarEdificios" %>

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
            width: 222px;
        }
        .auto-style3 {
            width: 191px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Listado de Edificios</h1>


        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Seleccione Orientación: </td>
                <td class="auto-style3">
                    <%--listado orientaciones--%>
                    <asp:DropDownList ID="ddlBuscarOrientacion" runat="server" OnSelectedIndexChanged="ddlBuscarOrientacion_SelectedIndexChanged">
                        <asp:ListItem>N</asp:ListItem>
                        <asp:ListItem>NE</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                        <asp:ListItem>E</asp:ListItem>
                        <asp:ListItem>SE</asp:ListItem>
                        <asp:ListItem>S</asp:ListItem>
                        <asp:ListItem>SO</asp:ListItem>
                        <asp:ListItem>O</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Seleccione Rango de Metraje</td>
                <td class="auto-style3">Desde:&nbsp;&nbsp;
                    <%--input menor metraje--%>
                    <asp:TextBox ID="txtMenorMetraje" runat="server" Width="84px"></asp:TextBox> m<sup>2</sup>
                </td>
                <td>Hasta:&nbsp;&nbsp;
                    <%--input mayor metraje--%>
                    <asp:TextBox ID="txtMayorMetraje" runat="server" Width="84px"></asp:TextBox>m<sup>2</sup>
                </td>
            </tr>
        </table>

        <%--boton buscar edificio--%>
        <asp:Button ID="btnBuscarEdificio" runat="server" Text="Buscar Edificios" />
        <br />
        <br />
        Resultado de la búsqueda:&nbsp;&nbsp;&nbsp;
        <%--listado edificios buscados--%>
        <asp:DropDownList ID="ddlResultadoEdificios" runat="server">
        </asp:DropDownList>
        <br />


        <br />
        <%--link a inicio--%>
        <asp:HyperLink runat="server" NavigateUrl="~/index.aspx"> Volver al inicio</asp:HyperLink>
    </div>
    </form>
</body>
</html>
