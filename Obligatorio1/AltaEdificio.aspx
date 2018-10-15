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
        .auto-style3 {
            width: 175px;
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
        Agregar un apartamento*<br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Seleccione tipo de apartamento:</td>
                <td class="auto-style7">
                    <%--lista edificios--%>
                    <asp:RadioButtonList ID="rbtTipoApto" runat="server"> 
                        <asp:ListItem>Oficina</asp:ListItem>
                        <asp:ListItem Selected="True" Value="CasaHabitacion">Casa Habitacion</asp:ListItem>
                    </asp:RadioButtonList>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Piso:</td>
                <td class="auto-style7">
                   <%-- input piso--%>
                    <asp:TextBox ID="txtPisoApto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Metraje:</td>
                <td class="auto-style6">
                    <%--input metraje--%>
                    <asp:TextBox ID="txtMetrajeApto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Orientacion:</td>
                <td class="auto-style7">
                    <%--lista orientacion--%>
                    <asp:DropDownList ID="ddlOrientacion" runat="server" >
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
            </tr>
        </table>
        <%--boton agregar edificio--%>
        <br />
        <br />
        <br />
        <asp:Button ID="btnAltaEdificio" runat="server" Text="Agregar Edificio y Apto" OnClick="btnAltaEdificio_Click" />
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
