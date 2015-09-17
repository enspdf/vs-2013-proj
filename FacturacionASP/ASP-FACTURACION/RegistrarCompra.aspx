<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCompra.aspx.cs" Inherits="ASP_FACTURACION.RegistrarCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/pepper-grinder/jquery-ui-1.10.4.custom.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/jquery-ui-1.10.4.custom.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
    <script src="Scripts/Facturacion.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>Cedula*</td>
                <td>
                    <asp:TextBox ID="cedula" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nombre Cliente *</td>
                <td>
                    <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fecha de Nacimiento*</td>
                <td>
                    <asp:TextBox ID="fecha" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email*</td>
                <td>
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Precio de la compra*</td>
                <td>
                    <asp:TextBox ID="precio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Cantidad*</td>
                <td>
                    <asp:TextBox ID="cantidad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Subtotal</td>
                <td>
                    <asp:TextBox ID="subtotal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Impuesto</td>
                <td>
                    <asp:TextBox ID="impuesto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Total Compra</td>
                <td>
                    <asp:TextBox ID="total" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Calcular" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>    
    </div>
    </form>
</body>
</html>
