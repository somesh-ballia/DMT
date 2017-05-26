<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alter1.aspx.cs" Inherits="Alter1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Alter
        <br />
        <br />
        Table<br />
        <br />
        <asp:DropDownList ID="DropDownListTables" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Action<br />
        <br />
        <asp:DropDownList ID="DropDownListChoics" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonGo" runat="server" onclick="ButtonGo_Click" Text="Go" />
        <br />
        <br />
    <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
