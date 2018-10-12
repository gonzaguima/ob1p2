<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaEdificio.aspx.cs" Inherits="Obligatorio1.AltaEdificio" %>

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
            width: 96px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Ingresar Edificio</h1><br />
        <table class="auto-style1">
            <tr>
                
                <td class="auto-style2">Nombre:</td>
                <%--input nombre edificio--%>
                <td> <asp:TextBox ID="txtNombreEdificio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Dirección:</td>
                <%--input direccion edificio--%>
                <td> <asp:TextBox ID="txtDireccionEdificio" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <%--boton agregar edificio--%>
        <asp:Button ID="btnAltaEdificio" runat="server" Text="Agregar Edificio" OnClick="btnAltaEdificio_Click" />
        <hr />
        <%--label mensaje--%>
        <asp:Label ID="lblEnviarEdificio" runat="server" Text=""></asp:Label>

        <p>
            <%--link a inicio--%>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">Volver al inicio</asp:HyperLink>
        </p>
    </div>
    </form>
</body>
</html>
