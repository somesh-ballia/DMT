<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddKey1.aspx.cs" Inherits="AddKey1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Select Column to Make Primary key</div>
    <asp:RadioButtonList ID="RadioButtonListColumn" runat="server">
    </asp:RadioButtonList>
    <br />
    <br />
    <asp:Button ID="ButtonAlter" runat="server" onclick="ButtonAlter_Click" 
        style="font-style: italic" Text="Alter" />
    <br />
    <br />
    <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
