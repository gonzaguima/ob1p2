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
        .auto-style6 {
            height: 24px;
            width: 148px;
        }
        .auto-style7 {
            width: 148px;
        }
        .auto-style10 {
            width: 148px;
            height: 56px;
        }
        .auto-style13 {
            width: 962px;
            height: 26px;
        }
        .auto-style14 {
            width: 962px;
            height: 24px;
        }
        .auto-style17 {
            width: 75px;
            height: 56px;
        }
        .auto-style19 {
            width: 75px;
            height: 24px;
        }
        .auto-style20 {
            width: 75px;
        }
        .auto-style24 {
            width: 88px;
            height: 56px;
        }
        .auto-style25 {
            width: 88px;
        }
        .auto-style26 {
            width: 88px;
            height: 24px;
        }
        .auto-style28 {
            width: 1034px;
        }
        .auto-style29 {
            width: 449px;
        }
        .auto-style30 {
            height: 26px;
            width: 421px;
        }
        .auto-style31 {
            height: 24px;
            width: 421px;
        }
        .auto-style32 {
            width: 124px;
            height: 56px;
        }
        .auto-style33 {
            width: 124px;
        }
        .auto-style34 {
            width: 124px;
            height: 24px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Ingresar Apartamento</h1>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style32">Seleccione Edificio: <br />
                    ó <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AltaEdificio.aspx">ingrese uno</asp:HyperLink>
                </td>
                <td class="auto-style24">
                    <%--lista edificios--%>
                    <asp:DropDownList ID="ddlElegirEdificio" runat="server">
                    </asp:DropDownList><br />
                    
                </td>
                <td class="auto-style17">
                    Seleccione tipo de apartamento:</td>
                <td class="auto-style10">
                    <%--radio button tipo apto--%>
                    <asp:RadioButtonList ID="rbtTipoApto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rbtTipoApto_SelectedIndexChanged"> 
                        <asp:ListItem Value="oficina">Oficina</asp:ListItem>
                        <asp:ListItem Selected="True" Value="CasaHabitacion">Casa Habitacion</asp:ListItem>
                    </asp:RadioButtonList>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style33">Piso:</td>
                <td class="auto-style25">
                    <%-- input piso--%>
                    <asp:TextBox ID="txtPisoApto" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style34">Metraje:</td>
                <td class="auto-style26">
                    <%--input metraje--%>
                    <asp:TextBox ID="txtMetrajeApto" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style19">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style33">Orientacion:</td>
                <td class="auto-style25">
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
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
        </table>
        <asp:Panel ID="Panel1" runat="server" Width="636px">
            <table class="auto-style1">
                <tr>
                    <td colspan="2"><h2>Oficina</h2></td>
                </tr>
                <tr>
                    <td class="auto-style30">Puestos de trabajo:</td>
                    <td class="auto-style13">
                        <%--radio equipamiento--%>
                        <asp:TextBox ID="txtPuestoTrabajo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">Equipamiento:</td>
                    <td class="auto-style14"><%--radio equipamiento--%>
                        <asp:RadioButtonList ID="rblEquipamiento" runat="server">
                            <asp:ListItem>Si</asp:ListItem>
                            <asp:ListItem Selected="True">No</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server" Width="642px">
            <table class="auto-style1">
                <tr>
                    <td colspan="2"><h2>Casa Habitacion</h2></td>
                </tr>
                <tr>
                    <td class="auto-style29">Dormitorios:</td>
                    <td class="auto-style28"><%--txt cantidad banios--%>
                        <asp:TextBox ID="txtDormitorio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29">Baños:</td>
                    <td class="auto-style28"><%--radio garaje--%>
                        <asp:TextBox ID="txtBanio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29">Garaje:</td>
                    <td class="auto-style28"><%--radio garaje--%>
                        <asp:RadioButtonList ID="rblGaraje" runat="server">
                            <asp:ListItem Selected="True">Si</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <br />
    </div>
        

        <p>
            <%--boton agregar apartamento--%>
            <asp:Button ID="btnEnviarApto" runat="server" Text="Agregar Apartamento" OnClick="btnEnviarApto_Click" />
        </p>
        <p>
            <%--label mensaje--%>
            <asp:Label ID="lblEnviarApto" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <hr /><p>
            <%--link inicio--%>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">Volver al inicio</asp:HyperLink>
        </p>
        
    </form>
</body>
</html>