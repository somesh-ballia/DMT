<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddColumn1.aspx.cs" Inherits="AddColumn1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Add Column<br />
        <br />
        Name
        <asp:TextBox ID="TextBoxColumn" runat="server"></asp:TextBox>
&nbsp;Type
        <asp:DropDownList ID="DropDownListType" runat="server">
            <asp:ListItem>varchar</asp:ListItem>
            <asp:ListItem>int</asp:ListItem>
        </asp:DropDownList>
&nbsp;size
        <asp:TextBox ID="TextBoxSize" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonAlter" runat="server" onclick="ButtonAlter_Click" 
            style="height: 26px" Text="Alter" />
        <br />
        <br />
    <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
