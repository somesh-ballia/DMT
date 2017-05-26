
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update3.aspx.cs" Inherits="Update3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Update into<br />
        <br />
        <asp:Label ID="LabelTabel" runat="server" Text="Table"></asp:Label>
        <br />
        <br />
        where<br />
        <br />
        <asp:Label ID="LabelWhere" runat="server" Text="Where"></asp:Label>
&nbsp;=<br />
        <br />
                                <asp:DropDownList ID="DropDownListValue" runat="server">
                                </asp:DropDownList>
                            <br />
                            <br />
    
    </div>
    <asp:Button ID="ButtonUpdate" runat="server" onclick="ButtonUpdate_Click" 
        Text="Update" />
    <br />
    <br />
        <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <br />
    values<br />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
