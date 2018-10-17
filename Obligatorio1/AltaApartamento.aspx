﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaApartamento.aspx.cs" Inherits="Obligatorio1.AltaApartamento" %>

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
            height: 56px;
        }
        .auto-style9 {
            width: 139px;
            height: 56px;
        }
        .auto-style10 {
            width: 148px;
            height: 56px;
        }
        .auto-style11 {
            height: 56px;
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
                <td class="auto-style9">Seleccione Edificio: <br />
                    ó <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AltaEdificio.aspx">ingrese uno</asp:HyperLink>
                </td>
                <td class="auto-style10">
                    <%--lista edificios--%>
                    <asp:DropDownList ID="ddlElegirEdificio" runat="server">
                    </asp:DropDownList><br />
                    
                </td>
                <td class="auto-style10">
                    Seleccione tipo de apartamento:</td>
                <td class="auto-style10">
                    <%--radio button tipo apto--%>
                    <asp:RadioButtonList ID="rbtTipoApto" runat="server"> 
                        <asp:ListItem Value="oficina">Oficina</asp:ListItem>
                        <asp:ListItem Selected="True" Value="CasaHabitacion">Casa Habitacion</asp:ListItem>
                    </asp:RadioButtonList>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Piso:</td>
                <td class="auto-style7">
                   <%-- input piso--%>
                    <asp:TextBox ID="txtPisoApto" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    Puestos de trabajo:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtPuestoTrabajo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Metraje:</td>
                <td class="auto-style6">
                    <%--input metraje--%>
                    <asp:TextBox ID="txtMetrajeApto" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    Equipamiento:</td>
                <td class="auto-style6">
                    <asp:RadioButtonList ID="rblEquipamiento" runat="server">
                        <asp:ListItem>Si</asp:ListItem>
                        <asp:ListItem Selected="True">No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Orientacion:</td>
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
                <td class="auto-style7">
                    Dormitorio:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtDormitorio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style7">
                    Baño:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtBanio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style7">
                    Garaje:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtGaraje" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <br />
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