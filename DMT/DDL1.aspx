<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DDL1.aspx.cs" Inherits="DDL1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Select the desired DDL command<br />
        <br />
        <asp:Button ID="ButtonCreate" runat="server" onclick="ButtonCreate_Click" 
            Text="Create Table" />
        <br />
        <br />
        <asp:Button ID="ButtonAlter" runat="server" onclick="ButtonAlter_Click" 
            Text="Alter Table" />
        <br />
        <br />
        <asp:Button ID="ButtonDrop" runat="server" onclick="ButtonDrop_Click" 
            Text="Drop Table" style="height: 26px" />
    
    </div>
    </form>
</body>
</html>
