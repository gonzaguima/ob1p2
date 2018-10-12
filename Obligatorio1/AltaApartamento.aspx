<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaApartamento.aspx.cs" Inherits="Obligatorio1.AltaApartamento" %>

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
            width: 139px;
        }
        .auto-style4 {
            width: 139px;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
            width: 148px;
        }
        .auto-style7 {
            width: 148px;
        }
        .auto-style8 {
            width: 201px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Ingresar Apartamento</h1>
        <br />
        <table align="left" class="auto-style1">
            <tr>
                <td class="auto-style2">Seleccione Edificio: <br />
                    ó <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AltaEdificio.aspx">ingrese uno</asp:HyperLink>
                </td>
                <td class="auto-style7">
                    <%--lista edificios--%>
                    <asp:DropDownList ID="ddlElegirEdificio" runat="server">
                    </asp:DropDownList><br />
                    
                </td>
                <td class="auto-style8">Seleccione tipo de apartamento:</td>
                <td>
                    <%--checkbox tipo apartamento--%>
                    <asp:CheckBoxList ID="chkTipoApto" runat="server">
                        <asp:ListItem>Oficina</asp:ListItem>
                        <asp:ListItem>CasaHabitacion</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Piso:</td>
                <td class="auto-style7">
                   <%-- input piso--%>
                    <asp:TextBox ID="txtPisoApto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Metraje:</td>
                <td class="auto-style6">
                    <%--input metraje--%>
                    <asp:TextBox ID="txtMetrajeApto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Orientacion:</td>
                <td class="auto-style7">
                    <%--lista orientacion--%>
                    <asp:DropDownList ID="ddlOrientacion" runat="server" OnSelectedIndexChanged="ddlOrientacion_SelectedIndexChanged">
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
        <br />
    </div>
        
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <%--boton agregar apartamento--%>
            <asp:Button ID="btnEnviarApto" runat="server" Text="Agregar Apartamento" />
        </p>
        <p>
            <%--label mensaje--%>
            <asp:Label ID="lblEnviarApto" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <%--link inicio--%>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">Volver al inicio</asp:HyperLink>
        </p>
        
    </form>
</body>
</html>