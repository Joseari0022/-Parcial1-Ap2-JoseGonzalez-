<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultasPresupuestosWebForm.aspx.cs" Inherits="_Parcial1_Ap2_JoseGonzalez_.UI.Consultas.ConsultasPresupuestosWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 326px;
        }
        .auto-style2 {
            width: 262px;
        }
        .auto-style3 {
            width: 129px;
        }
        .auto-style4 {
            width: 641px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
label{display:inline-block;max-width:100%;margin-bottom:5px;font-weight:700}*{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}*{color:#000!important;text-shadow:none!important;background:0 0!important;-webkit-box-shadow:none!important;box-shadow:none!important}</style>
</head>
<body style="height: 109px">
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">Consulta Presupuestos</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Filtro:&nbsp;&nbsp;
                    <asp:DropDownList ID="FiltroDropDownList" runat="server">
                        <asp:ListItem>Id</asp:ListItem>
                        <asp:ListItem>Fecha</asp:ListItem>
                        <asp:ListItem>Descripcion</asp:ListItem>
                        <asp:ListItem>Monto</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="FiltroTextBox" runat="server" Width="241px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Desde&nbsp;
                    <label for="Desde:">
&nbsp;</label><asp:TextBox ID="desdeFecha" runat="server" Width="141px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp; Hasta&nbsp;&nbsp;
                    <asp:TextBox ID="hastaFecha" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:GridView ID="ConsultaPresupuestosGridView" runat="server" CssClass="auto-style5" Height="330px" Width="598px">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
