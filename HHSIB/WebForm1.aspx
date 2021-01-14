<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LinqProject.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="StudentList" runat="server">
    <div id="SearchDiv">
    <table width="500px" border="0" cellpadding="5px 5px 5px 5px">
        <tr>
            <td colspan = "2" align="center">Search By:</td>
        </tr>
        <tr>
            <td width="30%">Class Of:</td>
            <td>
                <asp:DropDownList ID="ddlClass" runat="server" Width="75px">
                    <asp:ListItem>All</asp:ListItem>
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td width="30%">First name:</td>
            <td><asp:TextBox ID="txtFirstN" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="30%">Last name:</td>
            <td><asp:TextBox ID="txtLastN" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td width="30%"></td>
            <td>
                <asp:Button ID="btnGo" runat="server" Text="Go" onclick="btnGo_Click" />
            </td>
        </tr>
    </table>
        
        
        
        
    </div>
    <br /><br />
    <div id="ResultDiv">
        <asp:GridView ID="gdResult" runat="server" AllowPaging="True"            
            PageSize="30"  CellPadding="5" EmptyDataText = "No Student Found" 
            HeaderStyle-BackColor="AliceBlue" HeaderStyle-Font-Bold="true" 
            PagerSettings-FirstPageText="First" PagerSettings-LastPageText = "Last" 
            PagerSettings-Mode = "Numeric" PagerSettings-Position="Bottom" 
            PagerSettings-PreviousPageText="Prev"  PagerSettings-NextPageText="Next"
            PagerStyle-Font-Size="Medium" 
            RowStyle-Font-Size="15px" RowStyle-Width="75px" 
            onpageindexchanging="gdResult_PageIndexChanging" 
            AutoGenerateColumns="False" 
            onselectedindexchanging="gdResult_SelectedIndexChanging" 
            DataKeyNames="StudentNo" >
<PagerSettings FirstPageText="First" LastPageText="Last" NextPageText="Next" PreviousPageText="Prev"></PagerSettings>

            <RowStyle Width="100px" />
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name"/>
                <asp:BoundField DataField="Year" HeaderText="Class Of" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>

<PagerStyle Font-Size="Medium"></PagerStyle>

<HeaderStyle BackColor="AliceBlue" Font-Bold="True"></HeaderStyle>

            <AlternatingRowStyle BackColor="#CCFFFF" />
        </asp:GridView>
        
        
        
        
    </div>
    <br />
    <div id="Message">
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    
    </div>
    <br /><br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        Height="50px" Width="350px" DataSourceID="LinqDataSource1">
        <Fields>
            <asp:BoundField DataField="LastName" HeaderText="LastName" ReadOnly="True" 
                SortExpression="LastName" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" ReadOnly="True" 
                SortExpression="FirstName" />
            <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="True" 
                SortExpression="Address" />
            <asp:BoundField DataField="City" HeaderText="City" ReadOnly="True" 
                SortExpression="City" />
            <asp:BoundField DataField="Zip" HeaderText="Zip" ReadOnly="True" 
                SortExpression="Zip" />
            <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" 
                SortExpression="Email" />
            <asp:BoundField DataField="Phone1" HeaderText="Phone1" ReadOnly="True" 
                SortExpression="Phone1" />
            <asp:BoundField DataField="Phone2" HeaderText="Phone2" ReadOnly="True" 
                SortExpression="Phone2" />
            <asp:BoundField DataField="Homeroom" HeaderText="Homeroom" ReadOnly="True" 
                SortExpression="Homeroom" />
            <asp:BoundField DataField="Year" HeaderText="Year" ReadOnly="True" 
                SortExpression="Year" />
            <asp:BoundField DataField="Team" HeaderText="Team" ReadOnly="True" 
                SortExpression="Team" />
            <asp:BoundField DataField="Parents" HeaderText="Parents" ReadOnly="True" 
                SortExpression="Parents" />
            <asp:BoundField DataField="ParentEmail" HeaderText="ParentEmail" 
                ReadOnly="True" SortExpression="ParentEmail" />
        </Fields>
    </asp:DetailsView>
    
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="HHSIB.IBHhsDataContext" 
        TableName="StudentIBs" Where="StudentNo == @StudentNo" EntityTypeName="">
        <WhereParameters>
            <asp:ControlParameter ControlID="gdResult" Name="StudentNo" 
                PropertyName="SelectedValue" Type="String" />
        </WhereParameters>
    </asp:LinqDataSource>
    
    </form>
</body>
</html>
