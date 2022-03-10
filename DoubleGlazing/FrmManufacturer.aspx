<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmManufacturer.aspx.cs" Inherits="DoubleGlazing.FrmManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Manufacturer Name:&nbsp;
        <asp:TextBox ID="txtManufacturerName" runat="server" OnTextChanged="txtManufacturerName_TextChanged"></asp:TextBox>
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
        <asp:Button ID="txtAdd" runat="server" Text="Add " />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtUpdate" runat="server" Text="Update " OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtDelete" runat="server" Text="Delete" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:GridView ID="grdManufacturer" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ManufacturerID" DataSourceID="SqlDataSource3" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="ManufacturerID" HeaderText="ManufacturerID" InsertVisible="False" ReadOnly="True" SortExpression="ManufacturerID" />
                <asp:BoundField DataField="Manufacturer Name " HeaderText="Manufacturer Name " SortExpression="Manufacturer Name " />
                <asp:BoundField DataField="Address " HeaderText="Address " SortExpression="Address " />
                <asp:BoundField DataField="Telephone Number" HeaderText="Telephone Number" SortExpression="Telephone Number" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="Red" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ManufacturerID, [Manufacturer Name ], [Address ], [Telephone Number] FROM Manufacturer"></asp:SqlDataSource>
        </div>
        &nbsp;<br />
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
