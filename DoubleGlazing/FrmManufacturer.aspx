<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmManufacturer.aspx.cs" Inherits="DoubleGlazing.FrmManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
&nbsp;Manufacturer Name:&nbsp;
        <asp:TextBox ID="txtManufacturerName" runat="server"></asp:TextBox>
        <br />
        <br />
        Address:&nbsp;
        <asp:TextBox ID="txtManufacturerAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        Telephone Number:
        <asp:TextBox ID="txtManufacturerNum" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <br />
        <br />
        <asp:GridView ID="grdManufacturer" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
