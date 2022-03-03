<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="DoubleGlazing.Staff1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            First Name:
            <asp:TextBox ID="txtFirst_Name" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name:
            <asp:TextBox ID="txtLast_Name" runat="server"></asp:TextBox>
        </p>
        <p>
            Date Of Birth:
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Calendar ID="calStaff" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;</p>
        <p>
            Telephone Number:
            <asp:TextBox ID="txtTeleNum" runat="server"></asp:TextBox>
        </p>
        <p>
            Role:&nbsp;
            <asp:TextBox ID="txtStaff_Role" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:GridView ID="grdStaff" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
