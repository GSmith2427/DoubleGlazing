<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagementReport.aspx.cs" Inherits="DoubleGlazing.ManagementReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ManufacturerID,OrderID" DataSourceID="SqlDataSourceTotalsales" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="OrderID" ReadOnly="True" SortExpression="OrderID" />
                    <asp:BoundField DataField="Units Sold " HeaderText="Units Sold " SortExpression="Units Sold " />
                    <asp:BoundField DataField="ManufacturerID" HeaderText="ManufacturerID" InsertVisible="False" ReadOnly="True" SortExpression="ManufacturerID" />
                    <asp:BoundField DataField="Manufacturer Name " HeaderText="Manufacturer Name " SortExpression="Manufacturer Name " />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourceTotalsales" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Order].[Units Sold ], Manufacturer.ManufacturerID, Manufacturer.[Manufacturer Name ], [Order].OrderID FROM [Order] CROSS JOIN Manufacturer"></asp:SqlDataSource>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView5" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
