<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrosPresupuestosWebForm.aspx.cs" Inherits="_Parcial1_Ap2_JoseGonzalez_.UI.Registros.RegistrosPresupuestosWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 383px;
        }
        .auto-style3 {
            width: 343px;
        }
        .auto-style4 {
            width: 346px;
        }
        .auto-style5 {
            width: 299px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style7">Registros Presupuestos</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style7">Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" ValidationGroup="buscar" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="IdTextBox" ErrorMessage="*" Font-Bold="true" ForeColor="Blue" ValidationGroup="buscar"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="IdTextBox" ErrorMessage="*" Font-Bold="true" ForeColor="Blue" ValidationGroup="buscar"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>Fecha:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="FechaTextBox" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FechaTextBox" ErrorMessage="*" Font-Bold="true" ForeColor="Blue" ValidationGroup="guardar" ></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>Descripcion:&nbsp;
                    <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DescripcionTextBox" ErrorMessage="*" Font-Bold="true" ForeColor="Blue" ValidationGroup="guardar" ></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>Monto:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="MontoTextBox" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="MontoTextBox" ErrorMessage="*" Font-Bold="true" Font-Italic="true" ForeColor="Blue" ValidationGroup="guardar"  ></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style6">
            <tr>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" />
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" ValidationGroup="guardar" />
                </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="EliminarButton" runat="server" OnClick="EliminarButton_Click" Text="Eliminar" ValidationGroup="eliminar" />
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
