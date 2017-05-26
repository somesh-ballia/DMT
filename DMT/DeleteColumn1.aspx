<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteColumn1.aspx.cs" Inherits="DeleteColumn1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Delete
        <br />
        <br />
        <asp:DropDownList ID="DropDownListColumn" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        from
        <br />
        <br />
        <asp:Label ID="LabelTable" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonDelete" runat="server" onclick="ButtonRetrieve_Click" 
            Text="Delete" Width="91px" />
        <br />
        <br />
    <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
