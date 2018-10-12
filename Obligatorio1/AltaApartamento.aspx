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
            width: 104px;
        }
        .auto-style4 {
            width: 104px;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
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
                <td class="auto-style2">Piso:</td>
                <td>
                    <asp:TextBox ID="txtPisoApto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Metraje:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtMetrajeApto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Orientacion:</td>
                <td>
                    <asp:DropDownList ID="ddlOrientacion" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
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
            <asp:Button ID="btnEnviarApto" runat="server" Text="Agregar Apartamento" />
        </p>
        <p>
            <asp:Label ID="lblEnviarApto" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">Volver al inicio</asp:HyperLink>
        </p>
        
    </form>
</body>
</html>