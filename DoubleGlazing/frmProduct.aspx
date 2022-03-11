<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProduct.aspx.cs" Inherits="DoubleGlazing.P" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;Product Name:&nbsp;
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            <br />
            Product Price:&nbsp;&nbsp;
            <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            ManufacturerID:
            <asp:TextBox ID="txtManufacturerID" runat="server" OnTextChanged="txtManufacturerID_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnNewEntry" runat="server" OnClick="btnNewEntry_Click" Text="New Entry" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <asp:GridView ID="grdProduct" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="grdProduct_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="Item Name" HeaderText="Item Name" SortExpression="Item Name" />
                    <asp:BoundField DataField="Item Price" HeaderText="Item Price" SortExpression="Item Price" />
                    <asp:BoundField DataField="ManufacturerID" HeaderText="ManufacturerID" SortExpression="ManufacturerID" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
